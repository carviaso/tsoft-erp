namespace TS.ERP.ST.Forms
{
    partial class StockListForm
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
            this.cCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSettleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dAuditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAuditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPuInAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
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
            this.gridMemberSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCode,
            this.dDate,
            this.cSettleType,
            this.cDepartment,
            this.cCreator,
            this.dAuditDate,
            this.cAuditor,
            this.cRemark,
            this.iPuInAmt,
            this.cGUID,
            this.cTimeStamp});
            this.gridMemberSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMemberSalary.Location = new System.Drawing.Point(3, 48);
            this.gridMemberSalary.MultiSelect = false;
            this.gridMemberSalary.Name = "gridMemberSalary";
            this.gridMemberSalary.ReadOnly = true;
            this.gridMemberSalary.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridMemberSalary.RowHeadersVisible = false;
            this.gridMemberSalary.RowTemplate.Height = 23;
            this.gridMemberSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMemberSalary.Size = new System.Drawing.Size(943, 447);
            this.gridMemberSalary.TabIndex = 3;
            // 
            // cCode
            // 
            this.cCode.Frozen = true;
            this.cCode.HeaderText = "单据编号";
            this.cCode.Name = "cCode";
            this.cCode.ReadOnly = true;
            // 
            // dDate
            // 
            this.dDate.HeaderText = "单据日期";
            this.dDate.Name = "dDate";
            this.dDate.ReadOnly = true;
            // 
            // cSettleType
            // 
            this.cSettleType.HeaderText = "结算方式";
            this.cSettleType.Name = "cSettleType";
            this.cSettleType.ReadOnly = true;
            // 
            // cDepartment
            // 
            this.cDepartment.HeaderText = "部门";
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReadOnly = true;
            // 
            // cCreator
            // 
            this.cCreator.HeaderText = "制单人";
            this.cCreator.Name = "cCreator";
            this.cCreator.ReadOnly = true;
            // 
            // dAuditDate
            // 
            this.dAuditDate.HeaderText = "审核日期";
            this.dAuditDate.Name = "dAuditDate";
            this.dAuditDate.ReadOnly = true;
            // 
            // cAuditor
            // 
            this.cAuditor.HeaderText = "审核人";
            this.cAuditor.Name = "cAuditor";
            this.cAuditor.ReadOnly = true;
            // 
            // cRemark
            // 
            this.cRemark.HeaderText = "备注";
            this.cRemark.Name = "cRemark";
            this.cRemark.ReadOnly = true;
            // 
            // iPuInAmt
            // 
            this.iPuInAmt.HeaderText = "单据金额";
            this.iPuInAmt.Name = "iPuInAmt";
            this.iPuInAmt.ReadOnly = true;
            // 
            // cGUID
            // 
            this.cGUID.HeaderText = "cGUID";
            this.cGUID.Name = "cGUID";
            this.cGUID.ReadOnly = true;
            this.cGUID.Visible = false;
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.HeaderText = "cTimeStamp";
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.ReadOnly = true;
            this.cTimeStamp.Visible = false;
            // 
            // btnView
            // 
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(36, 42);
            this.btnView.Text = "查看";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 42);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnView,
            this.btnRefresh,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolItem.Location = new System.Drawing.Point(0, 0);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(949, 45);
            this.toolItem.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 42);
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 949F));
            this.tableLayoutPanel1.Controls.Add(this.toolItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridMemberSalary, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 498);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // StockListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockListForm";
            this.Text = "库存信息列表";
            ((System.ComponentModel.ISupportInitialize)(this.gridMemberSalary)).EndInit();
            this.toolItem.ResumeLayout(false);
            this.toolItem.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMemberSalary;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSettleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCreator;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAuditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAuditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPuInAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTimeStamp;
    }
}