namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolAccount = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeCustomer = new System.Windows.Forms.TreeView();
            this.gridMember = new System.Windows.Forms.DataGridView();
            this.btnMemberImport = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 781F));
            this.tableLayoutPanel1.Controls.Add(this.toolAccount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 460);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // toolAccount
            // 
            this.toolAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnView,
            this.btnDelete,
            this.btnRefresh,
            this.toolStripSeparator3,
            this.btnMemberImport,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnExit});
            this.toolAccount.Location = new System.Drawing.Point(0, 0);
            this.toolAccount.Name = "toolAccount";
            this.toolAccount.Size = new System.Drawing.Size(781, 45);
            this.toolAccount.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::TS.Sys.Platform.Forms.Properties.Resources.New;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Filter;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(36, 42);
            this.toolStripButton1.Text = "查询";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.splitContainer1.Panel1.Controls.Add(this.treeCustomer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridMember);
            this.splitContainer1.Size = new System.Drawing.Size(775, 409);
            this.splitContainer1.SplitterDistance = 162;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeCustomer
            // 
            this.treeCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeCustomer.Location = new System.Drawing.Point(0, 0);
            this.treeCustomer.Name = "treeCustomer";
            this.treeCustomer.Size = new System.Drawing.Size(162, 409);
            this.treeCustomer.TabIndex = 0;
            this.treeCustomer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCustomer_AfterSelect);
            // 
            // gridMember
            // 
            this.gridMember.AllowUserToAddRows = false;
            this.gridMember.AllowUserToDeleteRows = false;
            this.gridMember.AllowUserToResizeRows = false;
            this.gridMember.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridMember.ColumnHeadersHeight = 40;
            this.gridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridMember.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMember.Location = new System.Drawing.Point(0, 0);
            this.gridMember.MultiSelect = false;
            this.gridMember.Name = "gridMember";
            this.gridMember.ReadOnly = true;
            this.gridMember.RowHeadersVisible = false;
            this.gridMember.RowTemplate.Height = 23;
            this.gridMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMember.Size = new System.Drawing.Size(609, 409);
            this.gridMember.TabIndex = 4;
            this.gridMember.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMember_CellDoubleClick);
            // 
            // btnMemberImport
            // 
            this.btnMemberImport.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Import;
            this.btnMemberImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMemberImport.Name = "btnMemberImport";
            this.btnMemberImport.Size = new System.Drawing.Size(60, 42);
            this.btnMemberImport.Text = "会员导入";
            this.btnMemberImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMemberImport.Click += new System.EventHandler(this.btnMemberImport_Click);
            // 
            // MemberListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MemberListForm";
            this.Text = "会员列表";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolAccount.ResumeLayout(false);
            this.toolAccount.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolAccount;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridMember;
        private System.Windows.Forms.TreeView treeCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnImportMember;
        private System.Windows.Forms.ToolStripButton btnMemberImport;

    }
}