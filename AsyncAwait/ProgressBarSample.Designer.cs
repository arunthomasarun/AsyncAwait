﻿namespace AsyncAwait
{
  partial class ProgressBarSample
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
      this.button1 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.progressBar2 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(311, 53);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(171, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(85, 136);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(720, 23);
      this.progressBar1.TabIndex = 1;
      // 
      // progressBar2
      // 
      this.progressBar2.Location = new System.Drawing.Point(85, 184);
      this.progressBar2.Name = "progressBar2";
      this.progressBar2.Size = new System.Drawing.Size(720, 23);
      this.progressBar2.TabIndex = 2;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(868, 440);
      this.Controls.Add(this.progressBar2);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.ProgressBar progressBar2;
  }
}

