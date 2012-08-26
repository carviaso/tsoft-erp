namespace TS.Sys.Widgets
{
    partial class PageDataGridView
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.textPos = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.cbxPageSize = new System.Windows.Forms.ComboBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grid, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 389);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnFirst);
            this.flowLayoutPanel1.Controls.Add(this.btnPre);
            this.flowLayoutPanel1.Controls.Add(this.textPos);
            this.flowLayoutPanel1.Controls.Add(this.labelCount);
            this.flowLayoutPanel1.Controls.Add(this.btnNext);
            this.flowLayoutPanel1.Controls.Add(this.btnLast);
            this.flowLayoutPanel1.Controls.Add(this.cbxPageSize);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 359);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(559, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnFirst
            // 
            this.btnFirst.Enabled = false;
            this.btnFirst.Location = new System.Drawing.Point(3, 3);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(26, 23);
            this.btnFirst.TabIndex = 8;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPre
            // 
            this.btnPre.Enabled = false;
            this.btnPre.Location = new System.Drawing.Point(35, 3);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(26, 23);
            this.btnPre.TabIndex = 7;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // textPos
            // 
            this.textPos.Location = new System.Drawing.Point(67, 3);
            this.textPos.Name = "textPos";
            this.textPos.Size = new System.Drawing.Size(29, 21);
            this.textPos.TabIndex = 9;
            this.textPos.Text = "1";
            this.textPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textPos_KeyUp);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCount.Location = new System.Drawing.Point(102, 8);
            this.labelCount.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(19, 12);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "/1";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(127, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(26, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(159, 3);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(26, 23);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // cbxPageSize
            // 
            this.cbxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPageSize.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxPageSize.FormattingEnabled = true;
            this.cbxPageSize.Items.AddRange(new object[] {
            "15",
            "50",
            "100",
            "200"});
            this.cbxPageSize.Location = new System.Drawing.Point(191, 3);
            this.cbxPageSize.Name = "cbxPageSize";
            this.cbxPageSize.Size = new System.Drawing.Size(61, 22);
            this.cbxPageSize.TabIndex = 11;
            this.cbxPageSize.TextChanged += new System.EventHandler(this.cbxPageSize_TextChanged);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Margin = new System.Windows.Forms.Padding(0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 23;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(559, 359);
            this.grid.TabIndex = 1;
            this.grid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grid_RowPostPaint);
            // 
            // PageDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PageDataGridView";
            this.Size = new System.Drawing.Size(559, 389);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.TextBox textPos;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        public System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ComboBox cbxPageSize;

    }
}
