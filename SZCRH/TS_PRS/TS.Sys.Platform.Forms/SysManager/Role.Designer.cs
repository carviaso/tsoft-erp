namespace TS.Sys.Platform.Forms.SysManager
{
    partial class RoleForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridRole = new System.Windows.Forms.DataGridView();
            this.toolAccount = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnForbidden = new System.Windows.Forms.ToolStripButton();
            this.btnValueable = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSecu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRole)).BeginInit();
            this.toolAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 663F));
            this.tableLayoutPanel1.Controls.Add(this.gridRole, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolAccount, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(512, 366);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // gridRole
            // 
            this.gridRole.AllowUserToAddRows = false;
            this.gridRole.AllowUserToDeleteRows = false;
            this.gridRole.AllowUserToResizeRows = false;
            this.gridRole.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridRole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridRole.Location = new System.Drawing.Point(3, 48);
            this.gridRole.MultiSelect = false;
            this.gridRole.Name = "gridRole";
            this.gridRole.ReadOnly = true;
            this.gridRole.RowHeadersVisible = false;
            this.gridRole.RowTemplate.Height = 23;
            this.gridRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridRole.Size = new System.Drawing.Size(657, 315);
            this.gridRole.TabIndex = 3;
            this.gridRole.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRole_CellDoubleClick);
            this.gridRole.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRole_RowEnter);
            // 
            // toolAccount
            // 
            this.toolAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnView,
            this.btnDelete,
            this.btnRefresh,
            this.toolStripSeparator1,
            this.btnForbidden,
            this.btnValueable,
            this.toolStripSeparator2,
            this.btnSecu,
            this.toolStripSeparator3,
            this.btnExit});
            this.toolAccount.Location = new System.Drawing.Point(0, 0);
            this.toolAccount.Name = "toolAccount";
            this.toolAccount.Size = new System.Drawing.Size(663, 45);
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // btnForbidden
            // 
            this.btnForbidden.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Cancellation;
            this.btnForbidden.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btnValueable.Name = "btnValueable";
            this.btnValueable.Size = new System.Drawing.Size(36, 42);
            this.btnValueable.Text = "启用";
            this.btnValueable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnValueable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnValueable.Click += new System.EventHandler(this.btnValueable_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // btnSecu
            // 
            this.btnSecu.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Delete;
            this.btnSecu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSecu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSecu.Name = "btnSecu";
            this.btnSecu.Size = new System.Drawing.Size(60, 42);
            this.btnSecu.Text = "权限分配";
            this.btnSecu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSecu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSecu.Click += new System.EventHandler(this.btnSecu_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
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
            // RoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 366);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RoleForm";
            this.Text = "角色管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRole)).EndInit();
            this.toolAccount.ResumeLayout(false);
            this.toolAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolAccount;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnForbidden;
        private System.Windows.Forms.ToolStripButton btnValueable;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.DataGridView gridRole;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSecu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}