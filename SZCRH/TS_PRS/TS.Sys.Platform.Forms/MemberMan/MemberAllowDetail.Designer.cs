namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberAllowDetailForm
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.gridMember = new System.Windows.Forms.DataGridView();
            this.iAllowSum = new TS.Sys.Platform.Widgets.LabelEdit();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.label5_value = new System.Windows.Forms.Label();
            this.cMemberCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMemberAllow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRecNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTeamNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(776, 608);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(3, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(770, 45);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tpControl.Controls.Add(this.iAllowSum, 1, 1);
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
            this.tpControl.Location = new System.Drawing.Point(3, 48);
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
            this.tpControl.Size = new System.Drawing.Size(770, 557);
            this.tpControl.TabIndex = 5;
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
            this.cMemberCode,
            this.cMemberName,
            this.iMemberAllow,
            this.iRecNum,
            this.iTeamNum});
            this.tpControl.SetColumnSpan(this.gridMember, 2);
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridMember.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridMember.Location = new System.Drawing.Point(3, 123);
            this.gridMember.Name = "gridMember";
            this.gridMember.ReadOnly = true;
            this.gridMember.RowTemplate.Height = 23;
            this.gridMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMember.Size = new System.Drawing.Size(764, 343);
            this.gridMember.TabIndex = 21;
            // 
            // iAllowSum
            // 
            this.iAllowSum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iAllowSum.Enabled = false;
            this.iAllowSum.Label = "津贴总额：";
            this.iAllowSum.LabelWidth = 75;
            this.iAllowSum.Location = new System.Drawing.Point(387, 48);
            this.iAllowSum.Name = "iAllowSum";
            this.iAllowSum.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.iAllowSum.Size = new System.Drawing.Size(380, 29);
            this.iAllowSum.TabIndex = 15;
            this.iAllowSum.TextWidth = 100;
            this.iAllowSum.Value = "";
            // 
            // iMemberNum
            // 
            this.iMemberNum.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iMemberNum.Enabled = false;
            this.iMemberNum.Label = "会员人数：";
            this.iMemberNum.LabelWidth = 75;
            this.iMemberNum.Location = new System.Drawing.Point(3, 48);
            this.iMemberNum.Name = "iMemberNum";
            this.iMemberNum.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.iMemberNum.Size = new System.Drawing.Size(378, 29);
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
            this.cCode.Size = new System.Drawing.Size(378, 29);
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
            this.dDate.Location = new System.Drawing.Point(387, 8);
            this.dDate.Name = "dDate";
            this.dDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.True;
            this.dDate.Size = new System.Drawing.Size(380, 29);
            this.dDate.TabIndex = 13;
            this.dDate.Value = new System.DateTime(2011, 11, 26, 0, 0, 0, 0);
            this.dDate.ValueChanged += new System.EventHandler(this.dDate_ValueChanged);
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
            this.cRemark.Size = new System.Drawing.Size(764, 29);
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
            this.cCreator.Location = new System.Drawing.Point(3, 472);
            this.cCreator.Name = "cCreator";
            this.cCreator.ReferForm = "TS.Sys.Platform.Forms.SysManager.UserForm";
            this.cCreator.ReferMapping = "";
            this.cCreator.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cCreator.Size = new System.Drawing.Size(378, 26);
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
            this.cDepartment.Location = new System.Drawing.Point(387, 472);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.DepartmentForm";
            this.cDepartment.ReferMapping = "";
            this.cDepartment.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cDepartment.Size = new System.Drawing.Size(380, 26);
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
            this.cAuditor.Location = new System.Drawing.Point(3, 504);
            this.cAuditor.Name = "cAuditor";
            this.cAuditor.ReferForm = "TS.Sys.Platform.Forms.SysManager.UserForm";
            this.cAuditor.ReferMapping = "";
            this.cAuditor.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cAuditor.Size = new System.Drawing.Size(378, 27);
            this.cAuditor.TabIndex = 19;
            this.cAuditor.Value = null;
            // 
            // dAuditDate
            // 
            this.dAuditDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dAuditDate.Enabled = false;
            this.dAuditDate.Label = "审核时间：";
            this.dAuditDate.LabelWidth = 75;
            this.dAuditDate.Location = new System.Drawing.Point(387, 504);
            this.dAuditDate.Name = "dAuditDate";
            this.dAuditDate.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.dAuditDate.Size = new System.Drawing.Size(380, 27);
            this.dAuditDate.TabIndex = 20;
            this.dAuditDate.TextWidth = 100;
            this.dAuditDate.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 537);
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
            this.cTimeStamp.Location = new System.Drawing.Point(387, 537);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 17);
            this.cTimeStamp.TabIndex = 23;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 662);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Location = new System.Drawing.Point(1, 1);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(782, 45);
            this.toolItem.TabIndex = 3;
            // 
            // label5_value
            // 
            this.label5_value.AutoSize = true;
            this.label5_value.Location = new System.Drawing.Point(23, 30);
            this.label5_value.Name = "label5_value";
            this.label5_value.Size = new System.Drawing.Size(41, 12);
            this.label5_value.TabIndex = 8;
            this.label5_value.Text = "label6";
            // 
            // cMemberCode
            // 
            this.cMemberCode.Frozen = true;
            this.cMemberCode.HeaderText = "会员编号";
            this.cMemberCode.Name = "cMemberCode";
            this.cMemberCode.ReadOnly = true;
            // 
            // cMemberName
            // 
            this.cMemberName.Frozen = true;
            this.cMemberName.HeaderText = "会员名称";
            this.cMemberName.Name = "cMemberName";
            this.cMemberName.ReadOnly = true;
            // 
            // iMemberAllow
            // 
            this.iMemberAllow.HeaderText = "当月津贴";
            this.iMemberAllow.Name = "iMemberAllow";
            this.iMemberAllow.ReadOnly = true;
            // 
            // iRecNum
            // 
            this.iRecNum.HeaderText = "推荐人数";
            this.iRecNum.Name = "iRecNum";
            this.iRecNum.ReadOnly = true;
            // 
            // iTeamNum
            // 
            this.iTeamNum.HeaderText = "团队人数";
            this.iTeamNum.Name = "iTeamNum";
            this.iTeamNum.ReadOnly = true;
            // 
            // MemberAllowDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 662);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5_value);
            this.Name = "MemberAllowDetailForm";
            this.Text = "津贴单据";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.Label label5_value;
        private Widgets.LabelEdit cCode;
        private Widgets.LabelDateTime dDate;
        private Widgets.LabelEdit iMemberNum;
        private Widgets.LabelEdit iAllowSum;
        private Widgets.LabelEdit cRemark;
        private Widgets.Refer.WidgetRefer.LabelRefer cCreator;
        private Widgets.Refer.WidgetRefer.LabelRefer cDepartment;
        private Widgets.Refer.WidgetRefer.LabelRefer cAuditor;
        private Widgets.LabelEdit dAuditDate;
        private System.Windows.Forms.DataGridView gridMember;
        private Widgets.LabelEdit cGUID;
        private Widgets.LabelEdit cTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemberCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMemberAllow;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRecNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTeamNum;

    }
}