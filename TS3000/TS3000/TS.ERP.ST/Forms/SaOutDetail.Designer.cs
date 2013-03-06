namespace TS.ERP.ST
{
    partial class SaOutDetailForm
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
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.dDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.cRemark = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cCreator = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cDepartment = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cAuditor = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.dAuditDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.cSettleType = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cBankAccount = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cBankDetail = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.gridMember = new System.Windows.Forms.DataGridView();
            this.cSaOutType = new TS.Sys.Platform.Widgets.Refer.GridRefer.DataGridViewDataControlColumn();
            this.iSaOutAmt = new TS.Sys.Platform.Widgets.Money.GridMoney.DataGridViewMoneyColumn();
            this.cSubRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCustomerCode = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.label5_value = new System.Windows.Forms.Label();
            this.tpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpControl
            // 
            this.tpControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tpControl.ColumnCount = 3;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 461F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.dDate, 1, 0);
            this.tpControl.Controls.Add(this.cRemark, 0, 2);
            this.tpControl.Controls.Add(this.cCreator, 0, 4);
            this.tpControl.Controls.Add(this.cDepartment, 1, 4);
            this.tpControl.Controls.Add(this.cAuditor, 0, 5);
            this.tpControl.Controls.Add(this.dAuditDate, 1, 5);
            this.tpControl.Controls.Add(this.cSettleType, 0, 1);
            this.tpControl.Controls.Add(this.cBankAccount, 1, 1);
            this.tpControl.Controls.Add(this.cBankDetail, 2, 1);
            this.tpControl.Controls.Add(this.cTimeStamp, 2, 4);
            this.tpControl.Controls.Add(this.cGUID, 2, 5);
            this.tpControl.Controls.Add(this.gridMember, 0, 3);
            this.tpControl.Controls.Add(this.cCustomerCode, 2, 0);
            this.tpControl.Location = new System.Drawing.Point(3, 39);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 6;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 288F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(855, 452);
            this.tpControl.TabIndex = 5;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCode.Label = "单据编号：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 3);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cCode.Size = new System.Drawing.Size(239, 27);
            this.cCode.TabIndex = 22;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // dDate
            // 
            this.dDate.DateTimeWidth = 100;
            this.dDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dDate.Label = "单据日期：";
            this.dDate.LabelWidth = 75;
            this.dDate.Location = new System.Drawing.Point(248, 3);
            this.dDate.Name = "dDate";
            this.dDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.False;
            this.dDate.Size = new System.Drawing.Size(272, 27);
            this.dDate.TabIndex = 23;
            this.dDate.Value = new System.DateTime(2012, 9, 4, 11, 55, 43, 394);
            // 
            // cRemark
            // 
            this.tpControl.SetColumnSpan(this.cRemark, 3);
            this.cRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRemark.Label = "备注：";
            this.cRemark.LabelWidth = 75;
            this.cRemark.Location = new System.Drawing.Point(3, 69);
            this.cRemark.Name = "cRemark";
            this.cRemark.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cRemark.Size = new System.Drawing.Size(978, 25);
            this.cRemark.TabIndex = 27;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
            // 
            // cCreator
            // 
            this.cCreator.DataTableName = "Sys_User";
            this.cCreator.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.User;
            this.cCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCreator.Label = "制单人：";
            this.cCreator.LabelWidth = 75;
            this.cCreator.Location = new System.Drawing.Point(3, 388);
            this.cCreator.Name = "cCreator";
            this.cCreator.ReferForm = "TS.Sys.Platform.Forms.SysManager.UserForm";
            this.cCreator.ReferMapping = "";
            this.cCreator.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cCreator.Size = new System.Drawing.Size(239, 29);
            this.cCreator.TabIndex = 28;
            this.cCreator.Value = null;
            // 
            // cDepartment
            // 
            this.cDepartment.DataTableName = "CM_Department";
            this.cDepartment.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Department;
            this.cDepartment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cDepartment.Label = "部门：";
            this.cDepartment.LabelWidth = 75;
            this.cDepartment.Location = new System.Drawing.Point(248, 388);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.DepartmentForm";
            this.cDepartment.ReferMapping = "";
            this.cDepartment.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cDepartment.Size = new System.Drawing.Size(272, 29);
            this.cDepartment.TabIndex = 29;
            this.cDepartment.Value = null;
            // 
            // cAuditor
            // 
            this.cAuditor.DataTableName = "Sys_User";
            this.cAuditor.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.User;
            this.cAuditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cAuditor.Label = "审核人：";
            this.cAuditor.LabelWidth = 75;
            this.cAuditor.Location = new System.Drawing.Point(3, 423);
            this.cAuditor.Name = "cAuditor";
            this.cAuditor.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.UserForm";
            this.cAuditor.ReferMapping = "";
            this.cAuditor.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cAuditor.Size = new System.Drawing.Size(239, 27);
            this.cAuditor.TabIndex = 30;
            this.cAuditor.Value = null;
            // 
            // dAuditDate
            // 
            this.dAuditDate.DateTimeWidth = 100;
            this.dAuditDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dAuditDate.Label = "审核日期：";
            this.dAuditDate.LabelWidth = 75;
            this.dAuditDate.Location = new System.Drawing.Point(248, 423);
            this.dAuditDate.Name = "dAuditDate";
            this.dAuditDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.False;
            this.dAuditDate.Size = new System.Drawing.Size(272, 27);
            this.dAuditDate.TabIndex = 31;
            this.dAuditDate.Value = new System.DateTime(2012, 9, 4, 13, 5, 5, 943);
            // 
            // cSettleType
            // 
            this.cSettleType.DataTableName = "CM_SettleType";
            this.cSettleType.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.SettleType;
            this.cSettleType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cSettleType.Label = "结算方式：";
            this.cSettleType.LabelWidth = 75;
            this.cSettleType.Location = new System.Drawing.Point(3, 36);
            this.cSettleType.Name = "cSettleType";
            this.cSettleType.ReferForm = "TS.Sys.Platform.BaseData.Forms.SettleTypeForm";
            this.cSettleType.ReferMapping = "";
            this.cSettleType.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cSettleType.Size = new System.Drawing.Size(239, 27);
            this.cSettleType.TabIndex = 32;
            this.cSettleType.Value = null;
            // 
            // cBankAccount
            // 
            this.cBankAccount.DataTableName = "CM_Bank";
            this.cBankAccount.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Bank;
            this.cBankAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBankAccount.Label = "收款账户：";
            this.cBankAccount.LabelWidth = 75;
            this.cBankAccount.Location = new System.Drawing.Point(248, 36);
            this.cBankAccount.Name = "cBankAccount";
            this.cBankAccount.ReferForm = "TS.Sys.Platform.BaseData.Forms.BankForm";
            this.cBankAccount.ReferMapping = "cBankDetail:cBankAccount";
            this.cBankAccount.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cBankAccount.Size = new System.Drawing.Size(272, 27);
            this.cBankAccount.TabIndex = 33;
            this.cBankAccount.Value = null;
            // 
            // cBankDetail
            // 
            this.cBankDetail.Label = "账户信息：";
            this.cBankDetail.LabelWidth = 75;
            this.cBankDetail.Location = new System.Drawing.Point(526, 36);
            this.cBankDetail.Name = "cBankDetail";
            this.cBankDetail.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cBankDetail.Size = new System.Drawing.Size(327, 27);
            this.cBankDetail.TabIndex = 34;
            this.cBankDetail.TextWidth = 100;
            this.cBankDetail.Value = "";
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 48;
            this.cTimeStamp.Location = new System.Drawing.Point(526, 388);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 29);
            this.cTimeStamp.TabIndex = 35;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(526, 423);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 27);
            this.cGUID.TabIndex = 36;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // gridMember
            // 
            this.gridMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cSaOutType,
            this.iSaOutAmt,
            this.cSubRemark});
            this.tpControl.SetColumnSpan(this.gridMember, 3);
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMember.Location = new System.Drawing.Point(3, 100);
            this.gridMember.Name = "gridMember";
            this.gridMember.RowTemplate.Height = 23;
            this.gridMember.Size = new System.Drawing.Size(978, 282);
            this.gridMember.TabIndex = 37;
            // 
            // cSaOutType
            // 
            this.cSaOutType.DataFetcherImpl = null;
            this.cSaOutType.DataSource = null;
            this.cSaOutType.FillWeight = 76.822F;
            this.cSaOutType.HeaderText = "费用类别";
            this.cSaOutType.Name = "cSaOutType";
            this.cSaOutType.ReferMapping = null;
            this.cSaOutType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSaOutType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // iSaOutAmt
            // 
            this.iSaOutAmt.FillWeight = 152.2843F;
            this.iSaOutAmt.HeaderText = "支付金额";
            this.iSaOutAmt.LineBold = 0F;
            this.iSaOutAmt.LineSpace = 0;
            this.iSaOutAmt.Name = "iSaOutAmt";
            this.iSaOutAmt.NormalColor = System.Drawing.Color.Empty;
            this.iSaOutAmt.RedColor = System.Drawing.Color.Empty;
            this.iSaOutAmt.SpecialColor = System.Drawing.Color.Empty;
            // 
            // cSubRemark
            // 
            this.cSubRemark.FillWeight = 70.89375F;
            this.cSubRemark.HeaderText = "备注";
            this.cSubRemark.Name = "cSubRemark";
            this.cSubRemark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cSubRemark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cCustomerCode
            // 
            this.cCustomerCode.DataTableName = "CM_Customer";
            this.cCustomerCode.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Customer;
            this.cCustomerCode.Label = "客户：";
            this.cCustomerCode.LabelWidth = 75;
            this.cCustomerCode.Location = new System.Drawing.Point(526, 3);
            this.cCustomerCode.Name = "cCustomerCode";
            this.cCustomerCode.ReferForm = "TS.Sys.Platform.BaseData.Forms.SupplyForm";
            this.cCustomerCode.ReferMapping = "";
            this.cCustomerCode.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cCustomerCode.Size = new System.Drawing.Size(327, 27);
            this.cCustomerCode.TabIndex = 24;
            this.cCustomerCode.Value = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(869, 548);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Location = new System.Drawing.Point(1, 1);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(867, 45);
            this.toolItem.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tpControl, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.41688F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.58312F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(861, 494);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(3, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(855, 36);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5_value
            // 
            this.label5_value.AutoSize = true;
            this.label5_value.Location = new System.Drawing.Point(23, 30);
            this.label5_value.Name = "label5_value";
            this.label5_value.Size = new System.Drawing.Size(41, 12);
            this.label5_value.TabIndex = 10;
            this.label5_value.Text = "label6";
            // 
            // SaOutDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 548);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5_value);
            this.Name = "SaOutDetailForm";
            this.Text = "销售出库单";
            this.tpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpControl;
        private Sys.Platform.Widgets.LabelEdit cCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label label5_value;
        private Sys.Platform.Widgets.LabelDateTime dDate;
        private Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cCustomerCode;
        private Sys.Platform.Widgets.LabelEdit cRemark;
        private Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cCreator;
        private Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cDepartment;
        private Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cAuditor;
        private Sys.Platform.Widgets.LabelDateTime dAuditDate;
        private Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cSettleType;
        private Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cBankAccount;
        private Sys.Platform.Widgets.LabelEdit cBankDetail;
        private Sys.Platform.Widgets.LabelEdit cTimeStamp;
        private Sys.Platform.Widgets.LabelEdit cGUID;
        private System.Windows.Forms.DataGridView gridMember;
        private Sys.Platform.Widgets.Refer.GridRefer.DataGridViewDataControlColumn cSaOutType;
        private Sys.Platform.Widgets.Money.GridMoney.DataGridViewMoneyColumn iSaOutAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSubRemark;

    }
}

