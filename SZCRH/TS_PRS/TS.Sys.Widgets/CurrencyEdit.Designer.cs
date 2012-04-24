namespace TS.Sys.Platform.Widgets
{
    partial class CurrencyEdit
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAMT = new System.Windows.Forms.Label();
            this.textBoxAMT = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelAMT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAMT, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(184, 29);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelAMT
            // 
            this.labelAMT.AutoSize = true;
            this.labelAMT.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelAMT.Location = new System.Drawing.Point(4, 0);
            this.labelAMT.Name = "labelAMT";
            this.labelAMT.Size = new System.Drawing.Size(41, 29);
            this.labelAMT.TabIndex = 0;
            this.labelAMT.Text = "label1";
            this.labelAMT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAMT
            // 
            this.textBoxAMT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAMT.Font = new System.Drawing.Font("宋体", 11F);
            this.textBoxAMT.Location = new System.Drawing.Point(51, 3);
            this.textBoxAMT.Name = "textBoxAMT";
            this.textBoxAMT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAMT.Size = new System.Drawing.Size(130, 24);
            this.textBoxAMT.TabIndex = 1;
            this.textBoxAMT.Text = "￥0";
            this.textBoxAMT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAMT_KeyDown);
            this.textBoxAMT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAMT_KeyPress);
            this.textBoxAMT.Leave += new System.EventHandler(this.textBoxAMT_Leave);
            this.textBoxAMT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxAMT_MouseDown);
            // 
            // CurrencyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CurrencyEdit";
            this.Size = new System.Drawing.Size(184, 29);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelAMT;
        private System.Windows.Forms.TextBox textBoxAMT;

    }
}
