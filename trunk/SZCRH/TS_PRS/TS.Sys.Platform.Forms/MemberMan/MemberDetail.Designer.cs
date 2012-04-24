namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberDetailForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cId = new TS.Sys.Platform.Widgets.LabelEdit();
            this.dRecommendDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.cRecomMember = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cCompany = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.toolBtn = new System.Windows.Forms.ToolStrip();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 281);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(516, 230);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tabPage1.Controls.Add(this.tpControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(508, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "会员属性";
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.34884F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.cGUID, 0, 6);
            this.tpControl.Controls.Add(this.cTimeStamp, 0, 7);
            this.tpControl.Controls.Add(this.cName, 0, 1);
            this.tpControl.Controls.Add(this.cId, 0, 2);
            this.tpControl.Controls.Add(this.dRecommendDate, 0, 5);
            this.tpControl.Controls.Add(this.cRecomMember, 0, 4);
            this.tpControl.Controls.Add(this.cCompany, 0, 3);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(3, 3);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 9;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(502, 198);
            this.tpControl.TabIndex = 1;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCode.Enabled = false;
            this.cCode.Label = "会员编号：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 3);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(496, 26);
            this.cCode.TabIndex = 27;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 195);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(181, 14);
            this.cGUID.TabIndex = 31;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 48;
            this.cTimeStamp.Location = new System.Drawing.Point(3, 224);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 14);
            this.cTimeStamp.TabIndex = 32;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cName.Label = "姓名：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(3, 35);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(496, 26);
            this.cName.TabIndex = 0;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cId
            // 
            this.cId.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cId.Label = "身份证号：";
            this.cId.LabelWidth = 75;
            this.cId.Location = new System.Drawing.Point(3, 67);
            this.cId.Name = "cId";
            this.cId.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cId.Size = new System.Drawing.Size(496, 26);
            this.cId.TabIndex = 9;
            this.cId.TextWidth = 100;
            this.cId.Value = "";
            // 
            // dRecommendDate
            // 
            this.dRecommendDate.DateTimeWidth = 100;
            this.dRecommendDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dRecommendDate.Label = "推荐时间：";
            this.dRecommendDate.LabelWidth = 75;
            this.dRecommendDate.Location = new System.Drawing.Point(3, 163);
            this.dRecommendDate.Name = "dRecommendDate";
            this.dRecommendDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.False;
            this.dRecommendDate.Size = new System.Drawing.Size(496, 26);
            this.dRecommendDate.TabIndex = 30;
            this.dRecommendDate.Value = new System.DateTime(2011, 11, 27, 0, 0, 0, 0);
            // 
            // cRecomMember
            // 
            this.cRecomMember.DataTableName = "CM_Member";
            this.cRecomMember.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Member;
            this.cRecomMember.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRecomMember.Label = "推荐人：";
            this.cRecomMember.LabelWidth = 75;
            this.cRecomMember.Location = new System.Drawing.Point(3, 131);
            this.cRecomMember.Name = "cRecomMember";
            this.cRecomMember.ReferForm = "TS.Sys.Platform.Forms.MemberMan.MemberListForm";
            this.cRecomMember.ReferMapping = "";
            this.cRecomMember.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cRecomMember.Size = new System.Drawing.Size(496, 26);
            this.cRecomMember.TabIndex = 29;
            this.cRecomMember.Value = null;
            // 
            // cCompany
            // 
            this.cCompany.DataTableName = "CM_Customer";
            this.cCompany.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Customer;
            this.cCompany.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCompany.Label = "任职公司：";
            this.cCompany.LabelWidth = 75;
            this.cCompany.Location = new System.Drawing.Point(3, 99);
            this.cCompany.Name = "cCompany";
            this.cCompany.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.CustomerForm";
            this.cCompany.ReferMapping = "";
            this.cCompany.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cCompany.Size = new System.Drawing.Size(496, 26);
            this.cCompany.TabIndex = 28;
            this.cCompany.Value = null;
            // 
            // toolBtn
            // 
            this.toolBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBtn.Location = new System.Drawing.Point(0, 0);
            this.toolBtn.Name = "toolBtn";
            this.toolBtn.Size = new System.Drawing.Size(522, 45);
            this.toolBtn.TabIndex = 1;
            this.toolBtn.Text = "toolStrip1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 241;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "关系";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 241;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "工作单位";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 241;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "开始时间";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 145;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "结束时间";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 144;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "培训名称";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 145;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "培训地点";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 144;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "培训单位";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 145;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "开始时间";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "结束时间";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "毕业院校";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "专业";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // MemberDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 280);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MemberDetailForm";
            this.Text = "会员信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private TS.Sys.Platform.Widgets.LabelEdit cId;
        private System.Windows.Forms.ToolStrip toolBtn;
        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Widgets.Refer.WidgetRefer.LabelRefer cCompany;
        private Widgets.Refer.WidgetRefer.LabelRefer cRecomMember;
        private Widgets.LabelDateTime dRecommendDate;
        private Widgets.LabelEdit cGUID;
        private Widgets.LabelEdit cTimeStamp;
    }
}

