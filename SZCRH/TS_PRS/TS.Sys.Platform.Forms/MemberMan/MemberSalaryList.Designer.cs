namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberSalaryListForm
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
            this.gridMemberSalary = new System.Windows.Forms.DataGridView();
            this.btnUnAudit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnAudit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gridMemberSalary)).BeginInit();
            this.toolItem.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMemberSalary
            // 
            this.gridMemberSalary.AllowUserToAddRows = false;
            this.gridMemberSalary.AllowUserToDeleteRows = false;
            this.gridMemberSalary.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridMemberSalary.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMemberSalary.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMemberSalary.ColumnHeadersHeight = 35;
            this.gridMemberSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMemberSalary.Location = new System.Drawing.Point(3, 48);
            this.gridMemberSalary.MultiSelect = false;
            this.gridMemberSalary.Name = "gridMemberSalary";
            this.gridMemberSalary.ReadOnly = true;
            this.gridMemberSalary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridMemberSalary.RowHeadersVisible = false;
            this.gridMemberSalary.RowTemplate.Height = 23;
            this.gridMemberSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMemberSalary.Size = new System.Drawing.Size(923, 379);
            this.gridMemberSalary.TabIndex = 3;
            this.gridMemberSalary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMemberSalary_CellDoubleClick);
            // 
            // btnUnAudit
            // 
            this.btnUnAudit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.unauditor;
            this.btnUnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnAudit.Name = "btnUnAudit";
            this.btnUnAudit.Size = new System.Drawing.Size(48, 42);
            this.btnUnAudit.Text = "反审核";
            this.btnUnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnAudit.Click += new System.EventHandler(this.btnUnAudit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
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
            // btnAudit
            // 
            this.btnAudit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.auditor;
            this.btnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(36, 42);
            this.btnAudit.Text = "审核";
            this.btnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAudit.Click += new System.EventHandler(this.btnAudit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnView,
            this.btnDelete,
            this.btnRefresh,
            this.toolStripSeparator1,
            this.btnAudit,
            this.btnUnAudit,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolItem.Location = new System.Drawing.Point(0, 0);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(929, 45);
            this.toolItem.TabIndex = 2;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 926F));
            this.tableLayoutPanel1.Controls.Add(this.toolItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridMemberSalary, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(929, 430);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // MemberSalaryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 430);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MemberSalaryListForm";
            this.Text = "会员工资管理";
            ((System.ComponentModel.ISupportInitialize)(this.gridMemberSalary)).EndInit();
            this.toolItem.ResumeLayout(false);
            this.toolItem.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMemberSalary;
        private System.Windows.Forms.ToolStripButton btnUnAudit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnAudit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}