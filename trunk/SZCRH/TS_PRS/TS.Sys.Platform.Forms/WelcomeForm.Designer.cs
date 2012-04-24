namespace TS.Sys.Platform.Forms
{
    partial class WelcomeForm
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
            this.btnMember = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mainControl = new System.Windows.Forms.TableLayoutPanel();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolModual = new System.Windows.Forms.ToolStrip();
            this.mainControl.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // btnBase
            // 
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // mainControl
            // 
            this.mainControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainControl.BackColor = System.Drawing.Color.Transparent;
            this.mainControl.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.Main;
            this.mainControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainControl.ColumnCount = 2;
            this.mainControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.mainControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainControl.Controls.Add(this.tpControl, 1, 1);
            this.mainControl.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.mainControl.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.mainControl.Location = new System.Drawing.Point(0, 0);
            this.mainControl.Name = "mainControl";
            this.mainControl.RowCount = 2;
            this.mainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.mainControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainControl.Size = new System.Drawing.Size(1020, 710);
            this.mainControl.TabIndex = 0;
            // 
            // tpControl
            // 
            this.tpControl.BackColor = System.Drawing.Color.Transparent;
            this.tpControl.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.MainFrame;
            this.tpControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.label2, 0, 0);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(183, 83);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 2;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 588F));
            this.tpControl.Size = new System.Drawing.Size(834, 624);
            this.tpControl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(828, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "  功能导航";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolModual, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 618F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(174, 624);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toolModual
            // 
            this.toolModual.AutoSize = false;
            this.toolModual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolModual.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.MenuBG1;
            this.toolModual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolModual.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolModual.ImageScalingSize = new System.Drawing.Size(46, 46);
            this.toolModual.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolModual.Location = new System.Drawing.Point(0, 0);
            this.toolModual.Name = "toolModual";
            this.toolModual.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolModual.Size = new System.Drawing.Size(174, 624);
            this.toolModual.TabIndex = 1;
            this.toolModual.Text = "toolStrip1";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 710);
            this.Controls.Add(this.mainControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "主界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.mainControl.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainControl;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolModual;
        private System.Windows.Forms.ToolStripButton btnMember;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2; 

    }
}