namespace Tool
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.treeSecu = new TS.Sys.Platform.Widgets.DataTree();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.save = new System.Windows.Forms.Button();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnModual = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cParent = new TS.Sys.Platform.Widgets.LabelEdit();
            this.btnDel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.treeSecu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(837, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // treeSecu
            // 
            this.treeSecu.Active = TS.Sys.Platform.Widgets.DataTree.ActiveSelection.False;
            this.treeSecu.DisplayType = TS.Sys.Platform.Widgets.DataTree.DisplayTypeList.CodeAndName;
            this.treeSecu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSecu.Location = new System.Drawing.Point(3, 38);
            this.treeSecu.Name = "treeSecu";
            this.treeSecu.Size = new System.Drawing.Size(204, 280);
            this.treeSecu.SqlFetcher = null;
            this.treeSecu.TabIndex = 0;
            this.treeSecu.Table = "Sys_SysMenu";
            this.treeSecu.AfterTreeNodeSelect += new System.EventHandler(this.treeSecu_AfterTreeNodeSelect);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cCode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cParent, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.save, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDel, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(213, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(621, 280);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(615, 243);
            this.dataGridView1.TabIndex = 6;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCode.Label = "按钮编号：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 3);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cCode.Size = new System.Drawing.Size(157, 25);
            this.cCode.TabIndex = 1;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(512, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(50, 23);
            this.save.TabIndex = 3;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cName.Label = "按钮名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(166, 3);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cName.Size = new System.Drawing.Size(163, 25);
            this.cName.TabIndex = 2;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 2);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModual,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(837, 35);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnModual
            // 
            this.btnModual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnModual.Image = ((System.Drawing.Image)(resources.GetObject("btnModual.Image")));
            this.btnModual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModual.Name = "btnModual";
            this.btnModual.Size = new System.Drawing.Size(60, 32);
            this.btnModual.Text = "添加模块";
            this.btnModual.Click += new System.EventHandler(this.btnModual_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 17);
            this.toolStripButton1.Text = "添加菜单";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cParent
            // 
            this.cParent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cParent.Label = "cParent";
            this.cParent.LabelWidth = 65;
            this.cParent.Location = new System.Drawing.Point(335, 3);
            this.cParent.Name = "cParent";
            this.cParent.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cParent.Size = new System.Drawing.Size(171, 25);
            this.cParent.TabIndex = 4;
            this.cParent.TextWidth = 100;
            this.cParent.Value = "";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(568, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TS.Sys.Platform.Widgets.DataTree treeSecu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnModual;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private TS.Sys.Platform.Widgets.LabelEdit cParent;
        private System.Windows.Forms.Button btnDel;
    }
}

