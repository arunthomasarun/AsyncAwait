using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
  class ProgressReportModel
  {
    public int Percentage { get; set; } = 0;

    public WebsiteDataModel sitesDownloaded { get; set; } = new WebsiteDataModel();
  }
}
