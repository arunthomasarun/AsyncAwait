using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


//https://stephenhaunts.com/2014/10/14/using-async-and-await-to-update-the-ui-thread/
//https://codingjourneyman.com/2015/10/05/async-await-and-the-ui-thread/

namespace AsyncAwait
{
  public partial class ProgressBarSample : Form
  {
    private readonly SynchronizationContext syncContext;
    public ProgressBarSample()
    {
      InitializeComponent();
      //CheckForIllegalCrossThreadCalls = false;
      syncContext = SynchronizationContext.Current;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      Stopwatch sw = Stopwatch.StartNew();

      Task<string> op1 = DoLongOperation1Async();
      Task<string> op2 = DoLongOperation2Async();

      await Task.WhenAll(op1, op2);

      button1.Text = op2.Result;
      //string s= await DoLongOperation1Async();
      //string t = await DoLongOperation2Async();
      //sw.Stop();

      MessageBox.Show("Time Elapsed in ms: " + sw.ElapsedMilliseconds);
    }

    private async Task<string> DoLongOperation1Async()
    {
      await Task.Run(() =>
      {
        while (progressBar1.Value != 100)
        {
          //progressBar1.Value++;
          UpdateProgressBar(progressBar1, progressBar1.Value);
          Thread.Sleep(10);
        }
        
        //Thread.Sleep(2000);
        //return "DoLongOperation1";

        //string s = string.Empty;
        //for (int i = 0; i < 50000; i++)
        //{
        //  s = s + i.ToString();
        //}
      }
      );
      return "DoLongOperation1";
    }

    private async Task<string> DoLongOperation2Async()
    {
      await Task.Run(() =>
        {
          //Thread.Sleep(2000);
          //return "DoLongOperation2";

          //string s = string.Empty;
          //for (int i = 0; i < 50000; i++)
          //{
          //  s = s + i.ToString();
          //}

          while (progressBar2.Value != 50)
          {
            //progressBar2.Value++;
            UpdateProgressBar(progressBar2, progressBar2.Value);
            Thread.Sleep(10);
          }
        }
      );
      return "DoLongOperation2";
    }

    private void UpdateProgressBar(ProgressBar pb, int counter)
    {
      syncContext.Post(new SendOrPostCallback(o =>
      {
        pb.Value++;
      }),null);      
    }
  }
}
