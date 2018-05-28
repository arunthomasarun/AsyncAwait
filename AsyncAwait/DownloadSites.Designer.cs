namespace AsyncAwait
{
  partial class DownloadSites
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnSyncDownlaod = new System.Windows.Forms.Button();
      this.btnAsyncDownlaod = new System.Windows.Forms.Button();
      this.txtResults = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnSyncDownlaod
      // 
      this.btnSyncDownlaod.Location = new System.Drawing.Point(101, 25);
      this.btnSyncDownlaod.Name = "btnSyncDownlaod";
      this.btnSyncDownlaod.Size = new System.Drawing.Size(244, 23);
      this.btnSyncDownlaod.TabIndex = 0;
      this.btnSyncDownlaod.Text = "Sync Downlaod";
      this.btnSyncDownlaod.UseVisualStyleBackColor = true;
      this.btnSyncDownlaod.Click += new System.EventHandler(this.btnSyncDownlaod_Click);
      // 
      // btnAsyncDownlaod
      // 
      this.btnAsyncDownlaod.Location = new System.Drawing.Point(101, 72);
      this.btnAsyncDownlaod.Name = "btnAsyncDownlaod";
      this.btnAsyncDownlaod.Size = new System.Drawing.Size(244, 23);
      this.btnAsyncDownlaod.TabIndex = 1;
      this.btnAsyncDownlaod.Text = "Async Downlaod";
      this.btnAsyncDownlaod.UseVisualStyleBackColor = true;
      this.btnAsyncDownlaod.Click += new System.EventHandler(this.btnAsyncDownlaod_Click);
      // 
      // txtResults
      // 
      this.txtResults.Location = new System.Drawing.Point(101, 139);
      this.txtResults.Multiline = true;
      this.txtResults.Name = "txtResults";
      this.txtResults.Size = new System.Drawing.Size(840, 377);
      this.txtResults.TabIndex = 2;
      // 
      // DownloadSites
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1002, 562);
      this.Controls.Add(this.txtResults);
      this.Controls.Add(this.btnAsyncDownlaod);
      this.Controls.Add(this.btnSyncDownlaod);
      this.Name = "DownloadSites";
      this.Text = "DownloadSites";
      this.Load += new System.EventHandler(this.DownloadSites_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSyncDownlaod;
    private System.Windows.Forms.Button btnAsyncDownlaod;
    private System.Windows.Forms.TextBox txtResults;
  }
}