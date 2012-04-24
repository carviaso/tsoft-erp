namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberSalaryDetailForm
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
            this.gridMember = new System.Windows.Forms.DataGridView();
            this.cMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDayNumPersonCurrMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDayNumDeptCurrMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDayNumPersonLastMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDayNumDeptLastMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOvertimeSum_workday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOvertimeSum_holiday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOvertimeSum_festival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOvertimeSum_allow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOwetimeSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAwaytimeSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOfftimeSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBaseSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOvertimeFeeSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNighttimeAllowSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOwetimeFeeSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSalarySum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDayNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iElectriBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iWaterBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGasBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDormBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iBillSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iAccidentInsure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPrePay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRecomBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCutManPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCutCertifyPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iCutEduPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMemberSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSalaryRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.iMemberSalarySum = new TS.Sys.Platform.Widgets.LabelEdit();
            this.iMemberNum = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.dDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.cRemark = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cCreator = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cDepartment = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cAuditor = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.dAuditDate = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.label5_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMember
            // 
            this.gridMember.AllowDrop = true;
            this.gridMember.AllowUserToAddRows = false;
            this.gridMember.AllowUserToDeleteRows = false;
            this.gridMember.AllowUserToResizeRows = false;
            this.gridMember.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridMember.ColumnHeadersHeight = 35;
            this.gridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMemberName,
            this.cMemberId,
            this.iDayNumPersonCurrMon,
            this.iDayNumDeptCurrMon,
            this.iDayNumPersonLastMon,
            this.iDayNumDeptLastMon,
            this.iOvertimeSum_workday,
            this.iOvertimeSum_holiday,
            this.iOvertimeSum_festival,
            this.iOvertimeSum_allow,
            this.iOwetimeSum,
            this.iAwaytimeSum,
            this.iOfftimeSum,
            this.iBaseSalary,
            this.iOvertimeFeeSum,
            this.iNighttimeAllowSum,
            this.iOwetimeFeeSum,
            this.iSalarySum,
            this.iDayNum,
            this.iElectriBill,
            this.iWaterBill,
            this.iGasBill,
            this.iDormBill,
            this.iBillSum,
            this.iAccidentInsure,
            this.iPrePay,
            this.iRecomBill,
            this.iCutManPay,
            this.iCutCertifyPay,
            this.iCutEduPay,
            this.iMemberSalary,
            this.cSalaryRemark});
            this.tpControl.SetColumnSpan(this.gridMember, 2);
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridMember.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridMember.Location = new System.Drawing.Point(3, 123);
            this.gridMember.Name = "gridMember";
            this.gridMember.RowTemplate.Height = 23;
            this.gridMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMember.Size = new System.Drawing.Size(1199, 343);
            this.gridMember.TabIndex = 21;
            // 
            // cMemberName
            // 
            this.cMemberName.Frozen = true;
            this.cMemberName.HeaderText = "会员名称";
            this.cMemberName.Name = "cMemberName";
            this.cMemberName.ReadOnly = true;
            // 
            // cMemberId
            // 
            this.cMemberId.Frozen = true;
            this.cMemberId.HeaderText = "会员身份证";
            this.cMemberId.Name = "cMemberId";
            this.cMemberId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // iDayNumPersonCurrMon
            // 
            this.iDayNumPersonCurrMon.HeaderText = "本月个人工作天数";
            this.iDayNumPersonCurrMon.Name = "iDayNumPersonCurrMon";
            // 
            // iDayNumDeptCurrMon
            // 
            this.iDayNumDeptCurrMon.HeaderText = "本月部门工作天数";
            this.iDayNumDeptCurrMon.Name = "iDayNumDeptCurrMon";
            // 
            // iDayNumPersonLastMon
            // 
            this.iDayNumPersonLastMon.HeaderText = "上月个人工作天数";
            this.iDayNumPersonLastMon.Name = "iDayNumPersonLastMon";
            // 
            // iDayNumDeptLastMon
            // 
            this.iDayNumDeptLastMon.HeaderText = "上月部门工作天数";
            this.iDayNumDeptLastMon.Name = "iDayNumDeptLastMon";
            // 
            // iOvertimeSum_workday
            // 
            this.iOvertimeSum_workday.HeaderText = "本月平时加班时数合计";
            this.iOvertimeSum_workday.Name = "iOvertimeSum_workday";
            // 
            // iOvertimeSum_holiday
            // 
            this.iOvertimeSum_holiday.HeaderText = "本月假日加班时数合计";
            this.iOvertimeSum_holiday.Name = "iOvertimeSum_holiday";
            // 
            // iOvertimeSum_festival
            // 
            this.iOvertimeSum_festival.HeaderText = "本月节日加班时数合计";
            this.iOvertimeSum_festival.Name = "iOvertimeSum_festival";
            // 
            // iOvertimeSum_allow
            // 
            this.iOvertimeSum_allow.HeaderText = "本月夜班津贴时数";
            this.iOvertimeSum_allow.Name = "iOvertimeSum_allow";
            // 
            // iOwetimeSum
            // 
            this.iOwetimeSum.HeaderText = "本月欠班时数合计";
            this.iOwetimeSum.Name = "iOwetimeSum";
            // 
            // iAwaytimeSum
            // 
            this.iAwaytimeSum.HeaderText = "本月旷职时数合计";
            this.iAwaytimeSum.Name = "iAwaytimeSum";
            // 
            // iOfftimeSum
            // 
            this.iOfftimeSum.HeaderText = "本月请假时数合计";
            this.iOfftimeSum.Name = "iOfftimeSum";
            // 
            // iBaseSalary
            // 
            this.iBaseSalary.HeaderText = "基本工资";
            this.iBaseSalary.Name = "iBaseSalary";
            // 
            // iOvertimeFeeSum
            // 
            this.iOvertimeFeeSum.HeaderText = "加班费合计";
            this.iOvertimeFeeSum.Name = "iOvertimeFeeSum";
            // 
            // iNighttimeAllowSum
            // 
            this.iNighttimeAllowSum.HeaderText = "夜班津贴合计";
            this.iNighttimeAllowSum.Name = "iNighttimeAllowSum";
            // 
            // iOwetimeFeeSum
            // 
            this.iOwetimeFeeSum.HeaderText = "缺勤扣款合计";
            this.iOwetimeFeeSum.Name = "iOwetimeFeeSum";
            // 
            // iSalarySum
            // 
            this.iSalarySum.HeaderText = "应领合计";
            this.iSalarySum.Name = "iSalarySum";
            // 
            // iDayNum
            // 
            this.iDayNum.HeaderText = "计费天数";
            this.iDayNum.Name = "iDayNum";
            // 
            // iElectriBill
            // 
            this.iElectriBill.HeaderText = "电费";
            this.iElectriBill.Name = "iElectriBill";
            // 
            // iWaterBill
            // 
            this.iWaterBill.HeaderText = "水费";
            this.iWaterBill.Name = "iWaterBill";
            // 
            // iGasBill
            // 
            this.iGasBill.HeaderText = "燃气费";
            this.iGasBill.Name = "iGasBill";
            // 
            // iDormBill
            // 
            this.iDormBill.HeaderText = "宿舍费用";
            this.iDormBill.Name = "iDormBill";
            // 
            // iBillSum
            // 
            this.iBillSum.HeaderText = "费用合计";
            this.iBillSum.Name = "iBillSum";
            // 
            // iAccidentInsure
            // 
            this.iAccidentInsure.HeaderText = "意外险";
            this.iAccidentInsure.Name = "iAccidentInsure";
            // 
            // iPrePay
            // 
            this.iPrePay.HeaderText = "预支工资";
            this.iPrePay.Name = "iPrePay";
            // 
            // iRecomBill
            // 
            this.iRecomBill.HeaderText = "推荐费";
            this.iRecomBill.Name = "iRecomBill";
            // 
            // iCutManPay
            // 
            this.iCutManPay.HeaderText = "扣杂费（含80元管理费）";
            this.iCutManPay.Name = "iCutManPay";
            // 
            // iCutCertifyPay
            // 
            this.iCutCertifyPay.HeaderText = "扣办证费";
            this.iCutCertifyPay.Name = "iCutCertifyPay";
            // 
            // iCutEduPay
            // 
            this.iCutEduPay.HeaderText = "扣大专费";
            this.iCutEduPay.Name = "iCutEduPay";
            // 
            // iMemberSalary
            // 
            this.iMemberSalary.HeaderText = "应发工资";
            this.iMemberSalary.Name = "iMemberSalary";
            // 
            // cSalaryRemark
            // 
            this.cSalaryRemark.HeaderText = "备注";
            this.cSalaryRemark.Name = "cSalaryRemark";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(3, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1205, 48);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1219, 704);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Location = new System.Drawing.Point(1, 1);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(1217, 45);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1211, 650);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tpControl
            // 
            this.tpControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tpControl.ColumnCount = 2;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tpControl.Controls.Add(this.gridMember, 0, 3);
            this.tpControl.Controls.Add(this.iMemberSalarySum, 1, 1);
            this.tpControl.Controls.Add(this.iMemberNum, 0, 1);
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.dDate, 1, 0);
            this.tpControl.Controls.Add(this.cRemark, 0, 2);
            this.tpControl.Controls.Add(this.cCreator, 0, 5);
            this.tpControl.Controls.Add(this.cDepartment, 1, 5);
            this.tpControl.Controls.Add(this.cAuditor, 0, 6);
            this.tpControl.Controls.Add(this.dAuditDate, 1, 6);
            this.tpControl.Controls.Add(this.cGUID, 0, 7);
            this.tpControl.Controls.Add(this.cTimeStamp, 1, 7);
            this.tpControl.Location = new System.Drawing.Point(3, 51);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 8;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(1205, 596);
            this.tpControl.TabIndex = 5;
            // 
            // iMemberSalarySum
            // 
            this.iMemberSalarySum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iMemberSalarySum.Enabled = false;
            this.iMemberSalarySum.Label = "工资总额：";
            this.iMemberSalarySum.LabelWidth = 75;
            this.iMemberSalarySum.Location = new System.Drawing.Point(605, 48);
            this.iMemberSalarySum.Name = "iMemberSalarySum";
            this.iMemberSalarySum.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.iMemberSalarySum.Size = new System.Drawing.Size(597, 29);
            this.iMemberSalarySum.TabIndex = 15;
            this.iMemberSalarySum.TextWidth = 100;
            this.iMemberSalarySum.Value = "";
            // 
            // iMemberNum
            // 
            this.iMemberNum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iMemberNum.Enabled = false;
            this.iMemberNum.Label = "会员人数：";
            this.iMemberNum.LabelWidth = 75;
            this.iMemberNum.Location = new System.Drawing.Point(3, 48);
            this.iMemberNum.Name = "iMemberNum";
            this.iMemberNum.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.iMemberNum.Size = new System.Drawing.Size(596, 29);
            this.iMemberNum.TabIndex = 14;
            this.iMemberNum.TextWidth = 100;
            this.iMemberNum.Value = "";
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCode.Enabled = false;
            this.cCode.Label = "编号：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 8);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(596, 29);
            this.cCode.TabIndex = 12;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // dDate
            // 
            this.dDate.DateTimeWidth = 100;
            this.dDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dDate.Label = "日期：";
            this.dDate.LabelWidth = 75;
            this.dDate.Location = new System.Drawing.Point(605, 8);
            this.dDate.Name = "dDate";
            this.dDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.True;
            this.dDate.Size = new System.Drawing.Size(597, 29);
            this.dDate.TabIndex = 13;
            this.dDate.Value = new System.DateTime(2011, 11, 26, 0, 0, 0, 0);
            // 
            // cRemark
            // 
            this.tpControl.SetColumnSpan(this.cRemark, 2);
            this.cRemark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRemark.Label = "备注：";
            this.cRemark.LabelWidth = 75;
            this.cRemark.Location = new System.Drawing.Point(3, 88);
            this.cRemark.Name = "cRemark";
            this.cRemark.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cRemark.Size = new System.Drawing.Size(1199, 29);
            this.cRemark.TabIndex = 16;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
            // 
            // cCreator
            // 
            this.cCreator.DataTableName = "Sys_User";
            this.cCreator.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.User;
            this.cCreator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCreator.Enabled = false;
            this.cCreator.Label = "制单人：";
            this.cCreator.LabelWidth = 75;
            this.cCreator.Location = new System.Drawing.Point(3, 511);
            this.cCreator.Name = "cCreator";
            this.cCreator.ReferForm = "TS.Sys.Platform.Forms.SysManager.UserForm";
            this.cCreator.ReferMapping = "";
            this.cCreator.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cCreator.Size = new System.Drawing.Size(596, 26);
            this.cCreator.TabIndex = 17;
            this.cCreator.Value = null;
            // 
            // cDepartment
            // 
            this.cDepartment.DataTableName = "CM_Department";
            this.cDepartment.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Department;
            this.cDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDepartment.Label = "部门：";
            this.cDepartment.LabelWidth = 75;
            this.cDepartment.Location = new System.Drawing.Point(605, 511);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.DepartmentForm";
            this.cDepartment.ReferMapping = "";
            this.cDepartment.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cDepartment.Size = new System.Drawing.Size(597, 26);
            this.cDepartment.TabIndex = 18;
            this.cDepartment.Value = null;
            // 
            // cAuditor
            // 
            this.cAuditor.DataTableName = "Sys_User";
            this.cAuditor.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.User;
            this.cAuditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cAuditor.Enabled = false;
            this.cAuditor.Label = "审核人：";
            this.cAuditor.LabelWidth = 75;
            this.cAuditor.Location = new System.Drawing.Point(3, 543);
            this.cAuditor.Name = "cAuditor";
            this.cAuditor.ReferForm = "TS.Sys.Platform.Forms.SysManager.UserForm";
            this.cAuditor.ReferMapping = "";
            this.cAuditor.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cAuditor.Size = new System.Drawing.Size(596, 27);
            this.cAuditor.TabIndex = 19;
            this.cAuditor.Value = null;
            // 
            // dAuditDate
            // 
            this.dAuditDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dAuditDate.Enabled = false;
            this.dAuditDate.Label = "审核时间：";
            this.dAuditDate.LabelWidth = 75;
            this.dAuditDate.Location = new System.Drawing.Point(605, 543);
            this.dAuditDate.Name = "dAuditDate";
            this.dAuditDate.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.dAuditDate.Size = new System.Drawing.Size(597, 27);
            this.dAuditDate.TabIndex = 20;
            this.dAuditDate.TextWidth = 100;
            this.dAuditDate.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 576);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 17);
            this.cGUID.TabIndex = 22;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 48;
            this.cTimeStamp.Location = new System.Drawing.Point(605, 576);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 17);
            this.cTimeStamp.TabIndex = 23;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
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
            // MemberSalaryDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 704);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5_value);
            this.Name = "MemberSalaryDetailForm";
            this.Text = "工资单据";
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMember;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private Widgets.LabelEdit iMemberSalarySum;
        private Widgets.LabelEdit iMemberNum;
        private Widgets.LabelEdit cCode;
        private Widgets.LabelDateTime dDate;
        private Widgets.LabelEdit cRemark;
        private Widgets.Refer.WidgetRefer.LabelRefer cCreator;
        private Widgets.Refer.WidgetRefer.LabelRefer cDepartment;
        private Widgets.Refer.WidgetRefer.LabelRefer cAuditor;
        private Widgets.LabelEdit dAuditDate;
        private Widgets.LabelEdit cGUID;
        private Widgets.LabelEdit cTimeStamp;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDayNumPersonCurrMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDayNumDeptCurrMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDayNumPersonLastMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDayNumDeptLastMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOvertimeSum_workday;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOvertimeSum_holiday;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOvertimeSum_festival;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOvertimeSum_allow;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOwetimeSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAwaytimeSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOfftimeSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBaseSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOvertimeFeeSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNighttimeAllowSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOwetimeFeeSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSalarySum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDayNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iElectriBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn iWaterBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGasBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDormBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBillSum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iAccidentInsure;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPrePay;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRecomBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCutManPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCutCertifyPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCutEduPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMemberSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSalaryRemark;
    }
}