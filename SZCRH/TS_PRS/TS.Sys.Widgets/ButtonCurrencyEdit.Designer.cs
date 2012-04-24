namespace TS.Sys.Platform.Widgets
{
    partial class ButtonCurrencyEdit
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
            this.textBoxAMT = new System.Windows.Forms.TextBox();
            this.btnLabel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxAMT, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(188, 32);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxAMT
            // 
            this.textBoxAMT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAMT.Font = new System.Drawing.Font("宋体", 11F);
            this.textBoxAMT.Location = new System.Drawing.Point(51, 4);
            this.textBoxAMT.Name = "textBoxAMT";
            this.textBoxAMT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxAMT.Size = new System.Drawing.Size(134, 24);
            this.textBoxAMT.TabIndex = 1;
            this.textBoxAMT.Text = "￥0";
            this.textBoxAMT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAMT_KeyDown);
            this.textBoxAMT.Leave += new System.EventHandler(this.textBoxAMT_Leave);
            this.textBoxAMT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxAMT_MouseDown);
            // 
            // btnLabel
            // 
            this.btnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLabel.Location = new System.Drawing.Point(3, 3);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(42, 26);
            this.btnLabel.TabIndex = 2;
            this.btnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLabel.UseVisualStyleBackColor = true;
            // 
            // ButtonCurrencyEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ButtonCurrencyEdit";
            this.Size = new System.Drawing.Size(188, 32);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxAMT;
        private System.Windows.Forms.Button btnLabel;
    }
}
