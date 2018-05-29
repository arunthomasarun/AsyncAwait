namespace AsyncAwait
{
  partial class DownloadSitesWithCancel
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
      this.txtResults = new System.Windows.Forms.TextBox();
      this.btnAsyncDownlaod = new System.Windows.Forms.Button();
      this.btnCancelDownlaod = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // txtResults
      // 
      this.txtResults.Location = new System.Drawing.Point(12, 127);
      this.txtResults.Multiline = true;
      this.txtResults.Name = "txtResults";
      this.txtResults.Size = new System.Drawing.Size(1115, 377);
      this.txtResults.TabIndex = 4;
      // 
      // btnAsyncDownlaod
      // 
      this.btnAsyncDownlaod.Location = new System.Drawing.Point(12, 61);
      this.btnAsyncDownlaod.Name = "btnAsyncDownlaod";
      this.btnAsyncDownlaod.Size = new System.Drawing.Size(244, 23);
      this.btnAsyncDownlaod.TabIndex = 3;
      this.btnAsyncDownlaod.Text = "Async Downlaod";
      this.btnAsyncDownlaod.UseVisualStyleBackColor = true;
      this.btnAsyncDownlaod.Click += new System.EventHandler(this.btnAsyncDownlaod_Click);
      // 
      // btnCancelDownlaod
      // 
      this.btnCancelDownlaod.Location = new System.Drawing.Point(262, 61);
      this.btnCancelDownlaod.Name = "btnCancelDownlaod";
      this.btnCancelDownlaod.Size = new System.Drawing.Size(244, 23);
      this.btnCancelDownlaod.TabIndex = 5;
      this.btnCancelDownlaod.Text = "Cancel Downlaod";
      this.btnCancelDownlaod.UseVisualStyleBackColor = true;
      this.btnCancelDownlaod.Click += new System.EventHandler(this.btnCancelDownlaod_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 525);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(1115, 23);
      this.progressBar1.TabIndex = 6;
      // 
      // DownloadSitesWithCancel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1139, 566);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.btnCancelDownlaod);
      this.Controls.Add(this.txtResults);
      this.Controls.Add(this.btnAsyncDownlaod);
      this.Name = "DownloadSitesWithCancel";
      this.Text = "DownloadSitesWithCancel";
      this.Load += new System.EventHandler(this.DownloadSitesWithCancel_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtResults;
    private System.Windows.Forms.Button btnAsyncDownlaod;
    private System.Windows.Forms.Button btnCancelDownlaod;
    private System.Windows.Forms.ProgressBar progressBar1;
  }
}