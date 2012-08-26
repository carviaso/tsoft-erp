namespace TS.Sys.Platform.Forms.BaseDataForms
{
    partial class DepartmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolFaType = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnForbidden = new System.Windows.Forms.ToolStripButton();
            this.btnValueable = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeDepartment = new TS.Sys.Platform.Widgets.DataTree();
            this.gridDepartment = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolFaType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolFaType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 410);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // toolFaType
            // 
            this.toolFaType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolFaType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnView,
            this.btnDelete,
            this.btnRefresh,
            this.btnForbidden,
            this.btnValueable,
            this.btnExit});
            this.toolFaType.Location = new System.Drawing.Point(0, 0);
            this.toolFaType.Name = "toolFaType";
            this.toolFaType.Size = new System.Drawing.Size(668, 45);
            this.toolFaType.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::TS.Sys.Platform.Forms.Properties.Resources.New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 42);
            this.btnNew.Text = "新增";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnView
            // 
            this.btnView.Image = global::TS.Sys.Platform.Forms.Properties.Resources.See;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(36, 42);
            this.btnView.Text = "查看";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 42);
            this.btnDelete.Text = "删除";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 42);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnForbidden
            // 
            this.btnForbidden.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Cancellation;
            this.btnForbidden.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForbidden.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForbidden.Name = "btnForbidden";
            this.btnForbidden.Size = new System.Drawing.Size(36, 42);
            this.btnForbidden.Text = "禁用";
            this.btnForbidden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnForbidden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnForbidden.Click += new System.EventHandler(this.btnForbidden_Click);
            // 
            // btnValueable
            // 
            this.btnValueable.Image = global::TS.Sys.Platform.Forms.Properties.Resources.unblankout;
            this.btnValueable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValueable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnValueable.Name = "btnValueable";
            this.btnValueable.Size = new System.Drawing.Size(36, 42);
            this.btnValueable.Text = "启用";
            this.btnValueable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValueable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnValueable.Click += new System.EventHandler(this.btnValueable_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 42);
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 48);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeDepartment);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridDepartment);
            this.splitContainer1.Size = new System.Drawing.Size(662, 359);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeDepartment
            // 
            this.treeDepartment.Active = TS.Sys.Platform.Widgets.DataTree.ActiveSelection.False;
            this.treeDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeDepartment.Location = new System.Drawing.Point(0, 0);
            this.treeDepartment.Name = "treeDepartment";
            this.treeDepartment.Size = new System.Drawing.Size(160, 359);
            this.treeDepartment.SqlFetcher = null;
            this.treeDepartment.TabIndex = 0;
            this.treeDepartment.Table = "CM_Department";
            this.treeDepartment.AfterTreeNodeSelect += new System.EventHandler(this.treeDepartment_AfterTreeNodeSelect);
            // 
            // gridDepartment
            // 
            this.gridDepartment.AllowUserToAddRows = false;
            this.gridDepartment.AllowUserToDeleteRows = false;
            this.gridDepartment.AllowUserToResizeRows = false;
            this.gridDepartment.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridDepartment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDepartment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDepartment.ColumnHeadersHeight = 40;
            this.gridDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDepartment.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDepartment.Location = new System.Drawing.Point(0, 0);
            this.gridDepartment.MultiSelect = false;
            this.gridDepartment.Name = "gridDepartment";
            this.gridDepartment.ReadOnly = true;
            this.gridDepartment.RowHeadersVisible = false;
            this.gridDepartment.RowTemplate.Height = 23;
            this.gridDepartment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDepartment.Size = new System.Drawing.Size(498, 359);
            this.gridDepartment.TabIndex = 1;
            this.gridDepartment.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDepartment_CellDoubleClick);
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 410);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepartmentForm";
            this.Text = "部门";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolFaType.ResumeLayout(false);
            this.toolFaType.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDepartment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolFaType;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnForbidden;
        private System.Windows.Forms.ToolStripButton btnValueable;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridDepartment;
        private TS.Sys.Platform.Widgets.DataTree treeDepartment;
    }
}