using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwait
{
  public partial class DownloadSitesWithCancel : Form
  {
    CancellationTokenSource cts = new CancellationTokenSource();
    public DownloadSitesWithCancel()
    {
      InitializeComponent();
    }

    private void DownloadSitesWithCancel_Load(object sender, EventArgs e)
    {

    }

    private List<string> WebsiteList()
    {
      List<string> websites = new List<string>();

      websites.Add("http://www.marunadanmalayali.com/news/world/news-110015");
      websites.Add("http://www.mathrubhumi.com/sports");
      websites.Add("http://www.manoramaonline.com/home.html");
      websites.Add("http://www.marunadanmalayali.com/");
      websites.Add("http://www.mathrubhumi.com/news/kerala/kevin-murder-case-dyfi-suspended-two-supporters-1.2844116");
      websites.Add("http://www.mathrubhumi.com/movies-music/news/irumbuthirai-controversial-scene-adhaar-car-digital-india-vishal-mithran-bjp-1.2844002/");
      websites.Add("http://www.marunadanmalayali.com/news/special-report/pinarayi-vijayan-share-venue-with-thanku-brother-110300");
      websites.Add("http://www.marunadanmalayali.com/news/special-report/pinarayi-vijayan-angry-with-asianet-news-reporter-110321");
      //websites.Add("http://www.marunadanmalayali.com/news/investigation/ankamali-new-born-baby-death-incident-110328");
      //websites.Add("http://www.marunadanmalayali.com/politics/state/kummanam-rajasekharan-governer-post-110256");
      
      return websites;
    }

    private async void btnAsyncDownlaod_Click(object sender, EventArgs e)
    {
      cts = new CancellationTokenSource();
      Progress<ProgressReportModel> prm = new Progress<ProgressReportModel>();
      prm.ProgressChanged += Prm_ProgressChanged;
      Stopwatch sw = Stopwatch.StartNew();
      try
      {
        await RunDownloadAsync(prm, cts.Token);
      }
      catch (OperationCanceledException)
      {
        txtResults.Text += "\r\n Task cancelled by the user!!! ";
      }
      sw.Stop();
      txtResults.Text += "\r\n Time elapsed in ms: " + sw.ElapsedMilliseconds.ToString();
    }

    private void Prm_ProgressChanged(object sender, ProgressReportModel e)
    {
      progressBar1.Value = e.Percentage;
      ReportWebsiteInfo(e.sitesDownloaded);
    }

    private async Task RunDownloadAsync(IProgress<ProgressReportModel> progress, CancellationToken ct)
    {
      List<string> webUrl = WebsiteList();
      ProgressReportModel prm = new ProgressReportModel();
      int i = 0;
      foreach (var item in webUrl)
      {
        ct.ThrowIfCancellationRequested();
        WebsiteDataModel wdm = await Task.Run(() => DownloadSite(item));
        i += 1;
        //ReportWebsiteInfo(wdm);
        prm.sitesDownloaded = wdm;
        prm.Percentage = (i * 100) / webUrl.Count;

        progress.Report(prm);
      }
    }


    private WebsiteDataModel DownloadSite(string webUrl)
    {
      WebsiteDataModel wdm = new WebsiteDataModel();
      WebClient clnt = new WebClient();

      wdm.WebsiteUrl = webUrl;
      wdm.WebsiteData = clnt.DownloadData(webUrl);

      return wdm;
    }


    private void ReportWebsiteInfo(WebsiteDataModel wdm)
    {
      txtResults.Text += "\r\n Downloaded " + wdm.WebsiteUrl + " , Size is: " + wdm.WebsiteData.Length.ToString();
    }
    

    private void btnCancelDownlaod_Click(object sender, EventArgs e)
    {
      cts.Cancel();
    }
  }
}
