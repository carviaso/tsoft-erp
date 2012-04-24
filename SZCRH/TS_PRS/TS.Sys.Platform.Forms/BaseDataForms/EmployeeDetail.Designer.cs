namespace TS.Sys.Platform.Forms.BaseDataForms
{
    partial class EmployeeDetailForm
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
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cPhone = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cBank = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cBankAccount = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cEmail = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cDepartment = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.iSex = new TS.Sys.Platform.Widgets.LabelCombox();
            this.dBirthDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.cID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.dEnterDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.dExitDate = new TS.Sys.Platform.Widgets.LabelDateTime();
            this.cAddress = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cRemark = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolBtn = new System.Windows.Forms.ToolStrip();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCode.Enabled = false;
            this.cCode.Label = "编码：";
            this.cCode.LabelWidth = 85;
            this.cCode.Location = new System.Drawing.Point(3, 3);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(428, 26);
            this.cCode.TabIndex = 0;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cName.Label = "姓名：";
            this.cName.LabelWidth = 85;
            this.cName.Location = new System.Drawing.Point(3, 35);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(428, 26);
            this.cName.TabIndex = 1;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(3, 48);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(448, 522);
            this.tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tpControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.cName, 0, 1);
            this.tpControl.Controls.Add(this.cPhone, 0, 5);
            this.tpControl.Controls.Add(this.cBank, 0, 10);
            this.tpControl.Controls.Add(this.cBankAccount, 0, 11);
            this.tpControl.Controls.Add(this.cEmail, 0, 12);
            this.tpControl.Controls.Add(this.cDepartment, 0, 2);
            this.tpControl.Controls.Add(this.iSex, 0, 3);
            this.tpControl.Controls.Add(this.dBirthDate, 0, 4);
            this.tpControl.Controls.Add(this.cID, 0, 6);
            this.tpControl.Controls.Add(this.dEnterDate, 0, 7);
            this.tpControl.Controls.Add(this.dExitDate, 0, 8);
            this.tpControl.Controls.Add(this.cAddress, 0, 9);
            this.tpControl.Controls.Add(this.cGUID, 0, 14);
            this.tpControl.Controls.Add(this.cRemark, 0, 13);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(3, 3);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 16;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(434, 490);
            this.tpControl.TabIndex = 0;
            // 
            // cPhone
            // 
            this.cPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPhone.Label = "电话：";
            this.cPhone.LabelWidth = 85;
            this.cPhone.Location = new System.Drawing.Point(3, 163);
            this.cPhone.Name = "cPhone";
            this.cPhone.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cPhone.Size = new System.Drawing.Size(428, 26);
            this.cPhone.TabIndex = 11;
            this.cPhone.TextWidth = 100;
            this.cPhone.Value = "";
            // 
            // cBank
            // 
            this.cBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBank.Label = "开户银行：";
            this.cBank.LabelWidth = 85;
            this.cBank.Location = new System.Drawing.Point(3, 323);
            this.cBank.Name = "cBank";
            this.cBank.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cBank.Size = new System.Drawing.Size(428, 26);
            this.cBank.TabIndex = 12;
            this.cBank.TextWidth = 100;
            this.cBank.Value = "";
            // 
            // cBankAccount
            // 
            this.cBankAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBankAccount.Label = "银行账号：";
            this.cBankAccount.LabelWidth = 85;
            this.cBankAccount.Location = new System.Drawing.Point(3, 355);
            this.cBankAccount.Name = "cBankAccount";
            this.cBankAccount.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cBankAccount.Size = new System.Drawing.Size(428, 26);
            this.cBankAccount.TabIndex = 13;
            this.cBankAccount.TextWidth = 100;
            this.cBankAccount.Value = "";
            // 
            // cEmail
            // 
            this.cEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cEmail.Label = "EMAIL：";
            this.cEmail.LabelWidth = 85;
            this.cEmail.Location = new System.Drawing.Point(3, 387);
            this.cEmail.Name = "cEmail";
            this.cEmail.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cEmail.Size = new System.Drawing.Size(428, 26);
            this.cEmail.TabIndex = 14;
            this.cEmail.TextWidth = 100;
            this.cEmail.Value = "";
            // 
            // cDepartment
            // 
            this.cDepartment.DataTableName = "CM_Department";
            this.cDepartment.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Department;
            this.cDepartment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cDepartment.Label = "部门：";
            this.cDepartment.LabelWidth = 85;
            this.cDepartment.Location = new System.Drawing.Point(3, 67);
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.DepartmentForm";
            this.cDepartment.ReferMapping = "";
            this.cDepartment.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cDepartment.Size = new System.Drawing.Size(428, 26);
            this.cDepartment.TabIndex = 16;
            this.cDepartment.Value = null;
            // 
            // iSex
            // 
            this.iSex.CbxFont = null;
            this.iSex.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iSex.Editable = true;
            this.iSex.ItemValues = "1:男;0:女";
            this.iSex.Label = "性别：";
            this.iSex.LabelWidth = 85;
            this.iSex.Location = new System.Drawing.Point(3, 99);
            this.iSex.Name = "iSex";
            this.iSex.Require = TS.Sys.Platform.Widgets.LabelCombox.RequireSelect.True;
            this.iSex.Size = new System.Drawing.Size(428, 26);
            this.iSex.Sql = null;
            this.iSex.TabIndex = 17;
            this.iSex.Value = "1";
            // 
            // dBirthDate
            // 
            this.dBirthDate.DateTimeWidth = 100;
            this.dBirthDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dBirthDate.Label = "出生日期：";
            this.dBirthDate.LabelWidth = 85;
            this.dBirthDate.Location = new System.Drawing.Point(3, 131);
            this.dBirthDate.Name = "dBirthDate";
            this.dBirthDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.True;
            this.dBirthDate.Size = new System.Drawing.Size(428, 26);
            this.dBirthDate.TabIndex = 18;
            this.dBirthDate.Value = new System.DateTime(2011, 10, 19, 0, 0, 0, 0);
            // 
            // cID
            // 
            this.cID.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cID.Label = "身份证号码：";
            this.cID.LabelWidth = 85;
            this.cID.Location = new System.Drawing.Point(3, 195);
            this.cID.Name = "cID";
            this.cID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cID.Size = new System.Drawing.Size(428, 26);
            this.cID.TabIndex = 19;
            this.cID.TextWidth = 100;
            this.cID.Value = "";
            // 
            // dEnterDate
            // 
            this.dEnterDate.DateTimeWidth = 100;
            this.dEnterDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dEnterDate.Label = "入职日期：";
            this.dEnterDate.LabelWidth = 85;
            this.dEnterDate.Location = new System.Drawing.Point(3, 227);
            this.dEnterDate.Name = "dEnterDate";
            this.dEnterDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.True;
            this.dEnterDate.Size = new System.Drawing.Size(428, 26);
            this.dEnterDate.TabIndex = 20;
            this.dEnterDate.Value = new System.DateTime(2011, 10, 19, 0, 0, 0, 0);
            // 
            // dExitDate
            // 
            this.dExitDate.DateTimeWidth = 100;
            this.dExitDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dExitDate.Label = "离职日期：";
            this.dExitDate.LabelWidth = 85;
            this.dExitDate.Location = new System.Drawing.Point(3, 259);
            this.dExitDate.Name = "dExitDate";
            this.dExitDate.Require = TS.Sys.Platform.Widgets.LabelDateTime.RequireSelect.True;
            this.dExitDate.Size = new System.Drawing.Size(428, 26);
            this.dExitDate.TabIndex = 21;
            this.dExitDate.Value = new System.DateTime(2011, 10, 19, 0, 0, 0, 0);
            // 
            // cAddress
            // 
            this.cAddress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cAddress.Label = "住址：";
            this.cAddress.LabelWidth = 85;
            this.cAddress.Location = new System.Drawing.Point(3, 291);
            this.cAddress.Name = "cAddress";
            this.cAddress.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cAddress.Size = new System.Drawing.Size(428, 26);
            this.cAddress.TabIndex = 22;
            this.cAddress.TextWidth = 100;
            this.cAddress.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 451);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 26);
            this.cGUID.TabIndex = 15;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cRemark
            // 
            this.cRemark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRemark.Label = "备注：";
            this.cRemark.LabelWidth = 85;
            this.cRemark.Location = new System.Drawing.Point(3, 419);
            this.cRemark.Name = "cRemark";
            this.cRemark.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cRemark.Size = new System.Drawing.Size(428, 26);
            this.cRemark.TabIndex = 23;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 573);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // toolBtn
            // 
            this.toolBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBtn.Location = new System.Drawing.Point(0, 0);
            this.toolBtn.Name = "toolBtn";
            this.toolBtn.Size = new System.Drawing.Size(454, 45);
            this.toolBtn.TabIndex = 0;
            this.toolBtn.Text = "toolStrip1";
            // 
            // EmployeeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 573);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EmployeeDetailForm";
            this.Text = "职员属性";
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private TS.Sys.Platform.Widgets.LabelEdit cPhone;
        private TS.Sys.Platform.Widgets.LabelEdit cBank;
        private TS.Sys.Platform.Widgets.LabelEdit cBankAccount;
        private TS.Sys.Platform.Widgets.LabelEdit cEmail;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolBtn;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cDepartment;
        private TS.Sys.Platform.Widgets.LabelDateTime dBirthDate;
        private TS.Sys.Platform.Widgets.LabelEdit cID;
        private TS.Sys.Platform.Widgets.LabelDateTime dEnterDate;
        private TS.Sys.Platform.Widgets.LabelDateTime dExitDate;
        private TS.Sys.Platform.Widgets.LabelEdit cAddress;
        private TS.Sys.Platform.Widgets.LabelEdit cRemark;
        private TS.Sys.Platform.Widgets.LabelCombox iSex;
    }
}