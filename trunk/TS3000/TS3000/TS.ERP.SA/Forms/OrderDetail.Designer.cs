namespace TS.ERP.SA
{
    partial class OrderDetailForm
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
            this.cCreator = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cDepartment = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cAuditor = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.dAuditDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.gridMember = new System.Windows.Forms.DataGridView();
            this.cCustomerCode = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.currencyEdit2 = new TS.Sys.Platform.Widgets.CurrencyEdit();
            this.cRemark = new TS.Sys.Platform.Widgets.LabelEdit();
            this.currencyEdit1 = new TS.Sys.Platform.Widgets.CurrencyEdit();
            this.cBankDetail = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cBankAccount = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cStorage = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.label5_value = new System.Windows.Forms.Label();
            this.cMateriaCode = new TS.Sys.Platform.Widgets.Refer.GridRefer.DataGridViewDataControlColumn();
            this.cMateriaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iUnitePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tpControl.Controls.Add(this.cCreator, 0, 4);
            this.tpControl.Controls.Add(this.cDepartment, 1, 4);
            this.tpControl.Controls.Add(this.cAuditor, 0, 5);
            this.tpControl.Controls.Add(this.dAuditDate, 1, 5);
            this.tpControl.Controls.Add(this.cTimeStamp, 2, 4);
            this.tpControl.Controls.Add(this.cGUID, 2, 5);
            this.tpControl.Controls.Add(this.gridMember, 0, 3);
            this.tpControl.Controls.Add(this.cCustomerCode, 2, 0);
            this.tpControl.Controls.Add(this.currencyEdit2, 0, 2);
            this.tpControl.Controls.Add(this.cRemark, 2, 2);
            this.tpControl.Controls.Add(this.currencyEdit1, 1, 2);
            this.tpControl.Controls.Add(this.cBankDetail, 2, 1);
            this.tpControl.Controls.Add(this.cBankAccount, 1, 1);
            this.tpControl.Controls.Add(this.cStorage, 0, 1);
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
            this.tpControl.Size = new System.Drawing.Size(880, 453);
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
            this.gridMember.ColumnHeadersHeight = 40;
            this.gridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMateriaCode,
            this.cMateriaName,
            this.cUnite,
            this.cQuality,
            this.iUnitePrice,
            this.iDiscount,
            this.iNum,
            this.iSum});
            this.tpControl.SetColumnSpan(this.gridMember, 3);
            this.gridMember.Location = new System.Drawing.Point(3, 100);
            this.gridMember.Name = "gridMember";
            this.gridMember.RowTemplate.Height = 23;
            this.gridMember.Size = new System.Drawing.Size(872, 282);
            this.gridMember.TabIndex = 37;
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
            // currencyEdit2
            // 
            this.currencyEdit2.iPrecision = null;
            this.currencyEdit2.Label = "实付金额：";
            this.currencyEdit2.LabelWidth = 75;
            this.currencyEdit2.Location = new System.Drawing.Point(3, 69);
            this.currencyEdit2.Name = "currencyEdit2";
            this.currencyEdit2.Require = TS.Sys.Platform.Widgets.CurrencyEdit.RequireSelect.True;
            this.currencyEdit2.Size = new System.Drawing.Size(239, 25);
            this.currencyEdit2.TabIndex = 39;
            this.currencyEdit2.TextWidth = 100;
            this.currencyEdit2.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // cRemark
            // 
            this.cRemark.Label = "备注：";
            this.cRemark.LabelWidth = 75;
            this.cRemark.Location = new System.Drawing.Point(526, 69);
            this.cRemark.Name = "cRemark";
            this.cRemark.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cRemark.Size = new System.Drawing.Size(327, 25);
            this.cRemark.TabIndex = 27;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
            // 
            // currencyEdit1
            // 
            this.currencyEdit1.iPrecision = null;
            this.currencyEdit1.Label = "应付金额：";
            this.currencyEdit1.LabelWidth = 75;
            this.currencyEdit1.Location = new System.Drawing.Point(248, 69);
            this.currencyEdit1.Name = "currencyEdit1";
            this.currencyEdit1.Require = TS.Sys.Platform.Widgets.CurrencyEdit.RequireSelect.True;
            this.currencyEdit1.Size = new System.Drawing.Size(272, 25);
            this.currencyEdit1.TabIndex = 38;
            this.currencyEdit1.TextWidth = 100;
            this.currencyEdit1.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
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
            // cBankAccount
            // 
            this.cBankAccount.DataTableName = "CM_Bank";
            this.cBankAccount.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Bank;
            this.cBankAccount.Label = "收款账户：";
            this.cBankAccount.LabelWidth = 75;
            this.cBankAccount.Location = new System.Drawing.Point(248, 36);
            this.cBankAccount.Name = "cBankAccount";
            this.cBankAccount.ReferForm = "TS.Sys.PlatformBaseData.Forms.RoleForm";
            this.cBankAccount.ReferMapping = "cBankDetail:cBankAccount";
            this.cBankAccount.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cBankAccount.Size = new System.Drawing.Size(272, 27);
            this.cBankAccount.TabIndex = 33;
            this.cBankAccount.Value = null;
            // 
            // cStorage
            // 
            this.cStorage.DataTableName = "CM_Storage";
            this.cStorage.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Storage;
            this.cStorage.Label = "出货仓库：";
            this.cStorage.LabelWidth = 75;
            this.cStorage.Location = new System.Drawing.Point(3, 36);
            this.cStorage.Name = "cStorage";
            this.cStorage.ReferForm = "TS.Sys.Platform.BaseData.Forms.StorageForm";
            this.cStorage.ReferMapping = "";
            this.cStorage.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cStorage.Size = new System.Drawing.Size(239, 27);
            this.cStorage.TabIndex = 40;
            this.cStorage.Value = null;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(894, 549);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Location = new System.Drawing.Point(1, 1);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(892, 45);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(886, 495);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(3, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(880, 36);
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
            // cMateriaCode
            // 
            this.cMateriaCode.DataFetcherImpl = null;
            this.cMateriaCode.DataSource = null;
            this.cMateriaCode.FillWeight = 358.5556F;
            this.cMateriaCode.HeaderText = "商品编号";
            this.cMateriaCode.Name = "cMateriaCode";
            this.cMateriaCode.ReferMapping = null;
            this.cMateriaCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cMateriaCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cMateriaName
            // 
            this.cMateriaName.FillWeight = 106.1513F;
            this.cMateriaName.HeaderText = "商品名称";
            this.cMateriaName.Name = "cMateriaName";
            this.cMateriaName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cMateriaName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cUnite
            // 
            this.cUnite.FillWeight = 43.48861F;
            this.cUnite.HeaderText = "单位";
            this.cUnite.Name = "cUnite";
            // 
            // cQuality
            // 
            this.cQuality.FillWeight = 69.70603F;
            this.cQuality.HeaderText = "规格";
            this.cQuality.Name = "cQuality";
            this.cQuality.ReadOnly = true;
            // 
            // iUnitePrice
            // 
            this.iUnitePrice.FillWeight = 69.70603F;
            this.iUnitePrice.HeaderText = "商品单价";
            this.iUnitePrice.Name = "iUnitePrice";
            this.iUnitePrice.ReadOnly = true;
            // 
            // iDiscount
            // 
            this.iDiscount.FillWeight = 42.08661F;
            this.iDiscount.HeaderText = "折扣";
            this.iDiscount.Name = "iDiscount";
            // 
            // iNum
            // 
            this.iNum.FillWeight = 69.70603F;
            this.iNum.HeaderText = "数量";
            this.iNum.Name = "iNum";
            // 
            // iSum
            // 
            this.iSum.FillWeight = 69.70603F;
            this.iSum.HeaderText = "总金额";
            this.iSum.Name = "iSum";
            this.iSum.ReadOnly = true;
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5_value);
            this.Name = "OrderDetailForm";
            this.Text = "销售订单";
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
        private Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cBankAccount;
        private Sys.Platform.Widgets.LabelEdit cBankDetail;
        private Sys.Platform.Widgets.LabelEdit cTimeStamp;
        private Sys.Platform.Widgets.LabelEdit cGUID;
        private System.Windows.Forms.DataGridView gridMember;
        private Sys.Platform.Widgets.CurrencyEdit currencyEdit1;
        private Sys.Platform.Widgets.CurrencyEdit currencyEdit2;
        private Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cStorage;
        private Sys.Platform.Widgets.Refer.GridRefer.DataGridViewDataControlColumn cMateriaCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMateriaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnite;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuality;
        private System.Windows.Forms.DataGridViewTextBoxColumn iUnitePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSum;

    }
}

