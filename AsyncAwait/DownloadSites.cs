using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace AsyncAwait
{
  public partial class DownloadSites : Form
  {
    public DownloadSites()
    {
      InitializeComponent();
    }

    private void DownloadSites_Load(object sender, EventArgs e)
    {

    }

    private void btnSyncDownlaod_Click(object sender, EventArgs e)
    {
      txtResults.Text = string.Empty;
      Stopwatch sw = Stopwatch.StartNew();
      RunDownloadSync();
      sw.Stop();
      txtResults.Text += "\r\n Time elapsed is: " + sw.ElapsedMilliseconds.ToString();
    }

    private List<string> WebsiteList()
    {
      List<string> websites = new List<string>();

      websites.Add("http://www.marunadanmalayali.com/news/world/news-110015");
      websites.Add("http://www.mathrubhumi.com/sports");
      websites.Add("http://www.manoramaonline.com/home.html");
      websites.Add("http://www.marunadanmalayali.com/");    

      return websites;
    }

    private void RunDownloadSync()
    {
      List<string> webUrl = WebsiteList();

      foreach (var item in webUrl)
      {
        WebsiteDataModel wdm = DownloadSite(item);
        ReportWebsiteInfo(wdm);
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

    private async void btnAsyncDownlaod_Click(object sender, EventArgs e)
    {
      txtResults.Text = string.Empty;
      Stopwatch sw = Stopwatch.StartNew();
      await RunDownloadParallelAsync();
      sw.Stop();
      txtResults.Text += "\r\n Time elapsed is: " + sw.ElapsedMilliseconds.ToString();
    }

    private async Task RunDownloadAsync()
    {
      List<string> webUrl = WebsiteList();

      foreach (var item in webUrl)
      {
        WebsiteDataModel wdm = await Task.Run(() => DownloadSite(item));
        ReportWebsiteInfo(wdm);
      }
    }

    private async Task RunDownloadParallelAsync()
    {
      List<string> webUrl = WebsiteList();
      List<Task<WebsiteDataModel>> tasks = new List<Task<WebsiteDataModel>>();

      foreach (var item in webUrl)
      {
        tasks.Add(Task.Run(() => DownloadSite(item)));        
      }

      var results = await Task.WhenAll(tasks);
      foreach (var item in results)
      {
        ReportWebsiteInfo(item);
      }
    }

    private async Task<WebsiteDataModel> DownloadSiteAsync(string webUrl)
    {
      WebsiteDataModel wdm = new WebsiteDataModel();
      WebClient clnt = new WebClient();

      wdm.WebsiteUrl = webUrl;
      wdm.WebsiteData = await clnt.DownloadDataTaskAsync(webUrl);

      return wdm;
    }
  }
}
