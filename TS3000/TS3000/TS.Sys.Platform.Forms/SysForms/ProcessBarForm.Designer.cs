﻿namespace TS.Sys.Platform.Forms.SysForms
{
    partial class ProcessBarForm
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
            this.prcBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // prcBar
            // 
            this.prcBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prcBar.Location = new System.Drawing.Point(0, 0);
            this.prcBar.Name = "prcBar";
            this.prcBar.Size = new System.Drawing.Size(284, 29);
            this.prcBar.TabIndex = 0;
            // 
            // ProcessBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 29);
            this.ControlBox = false;
            this.Controls.Add(this.prcBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessBarForm";
            this.Text = "ProcessBarForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prcBar;
    }
}