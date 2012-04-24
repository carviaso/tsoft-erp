namespace TS.Sys.Platform.Forms.BaseDataForms
{
    partial class CustomerDetailForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cAddress = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cFax = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cPhone = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cContactor = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cRegion = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cZip = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cBank = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cBankAccount = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cLegalRepre = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cCode.Enabled = false;
            this.cCode.Label = "编码：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 3);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(501, 26);
            this.cCode.TabIndex = 0;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(3, 35);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(501, 26);
            this.cName.TabIndex = 1;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 466);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Location = new System.Drawing.Point(0, 0);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(527, 45);
            this.toolItem.TabIndex = 0;
            this.toolItem.Text = "toolStrip1";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(3, 48);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(521, 415);
            this.tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tpControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 389);
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
            this.tpControl.Controls.Add(this.cAddress, 0, 2);
            this.tpControl.Controls.Add(this.cFax, 0, 7);
            this.tpControl.Controls.Add(this.cPhone, 0, 6);
            this.tpControl.Controls.Add(this.cContactor, 0, 5);
            this.tpControl.Controls.Add(this.cRegion, 0, 4);
            this.tpControl.Controls.Add(this.cZip, 0, 3);
            this.tpControl.Controls.Add(this.cBank, 0, 8);
            this.tpControl.Controls.Add(this.cBankAccount, 0, 9);
            this.tpControl.Controls.Add(this.cLegalRepre, 0, 10);
            this.tpControl.Controls.Add(this.cGUID, 0, 11);
            this.tpControl.Controls.Add(this.cTimeStamp, 0, 12);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(3, 3);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 13;
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
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(507, 383);
            this.tpControl.TabIndex = 0;
            // 
            // cAddress
            // 
            this.cAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cAddress.Label = "地址：";
            this.cAddress.LabelWidth = 75;
            this.cAddress.Location = new System.Drawing.Point(3, 67);
            this.cAddress.Name = "cAddress";
            this.cAddress.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cAddress.Size = new System.Drawing.Size(501, 26);
            this.cAddress.TabIndex = 4;
            this.cAddress.TextWidth = 100;
            this.cAddress.Value = "";
            // 
            // cFax
            // 
            this.cFax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cFax.Label = "传真：";
            this.cFax.LabelWidth = 75;
            this.cFax.Location = new System.Drawing.Point(3, 227);
            this.cFax.Name = "cFax";
            this.cFax.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cFax.Size = new System.Drawing.Size(501, 26);
            this.cFax.TabIndex = 10;
            this.cFax.TextWidth = 100;
            this.cFax.Value = "";
            // 
            // cPhone
            // 
            this.cPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPhone.Label = "电话：";
            this.cPhone.LabelWidth = 75;
            this.cPhone.Location = new System.Drawing.Point(3, 195);
            this.cPhone.Name = "cPhone";
            this.cPhone.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cPhone.Size = new System.Drawing.Size(501, 26);
            this.cPhone.TabIndex = 7;
            this.cPhone.TextWidth = 100;
            this.cPhone.Value = "";
            // 
            // cContactor
            // 
            this.cContactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cContactor.Label = "联系人：";
            this.cContactor.LabelWidth = 75;
            this.cContactor.Location = new System.Drawing.Point(3, 163);
            this.cContactor.Name = "cContactor";
            this.cContactor.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cContactor.Size = new System.Drawing.Size(501, 26);
            this.cContactor.TabIndex = 6;
            this.cContactor.TextWidth = 100;
            this.cContactor.Value = "";
            // 
            // cRegion
            // 
            this.cRegion.DataTableName = "CM_Region";
            this.cRegion.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Region;
            this.cRegion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRegion.Label = "区域：";
            this.cRegion.LabelWidth = 75;
            this.cRegion.Location = new System.Drawing.Point(3, 131);
            this.cRegion.Name = "cRegion";
            this.cRegion.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.RegionForm";
            this.cRegion.ReferMapping = "";
            this.cRegion.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cRegion.Size = new System.Drawing.Size(501, 26);
            this.cRegion.TabIndex = 5;
            this.cRegion.Value = null;
            // 
            // cZip
            // 
            this.cZip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cZip.Label = "邮编：";
            this.cZip.LabelWidth = 75;
            this.cZip.Location = new System.Drawing.Point(3, 99);
            this.cZip.Name = "cZip";
            this.cZip.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cZip.Size = new System.Drawing.Size(501, 26);
            this.cZip.TabIndex = 11;
            this.cZip.TextWidth = 100;
            this.cZip.Value = "";
            // 
            // cBank
            // 
            this.cBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBank.Label = "开户银行：";
            this.cBank.LabelWidth = 75;
            this.cBank.Location = new System.Drawing.Point(3, 259);
            this.cBank.Name = "cBank";
            this.cBank.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cBank.Size = new System.Drawing.Size(501, 26);
            this.cBank.TabIndex = 12;
            this.cBank.TextWidth = 100;
            this.cBank.Value = "";
            // 
            // cBankAccount
            // 
            this.cBankAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBankAccount.Label = "银行账号：";
            this.cBankAccount.LabelWidth = 75;
            this.cBankAccount.Location = new System.Drawing.Point(3, 291);
            this.cBankAccount.Name = "cBankAccount";
            this.cBankAccount.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cBankAccount.Size = new System.Drawing.Size(501, 26);
            this.cBankAccount.TabIndex = 13;
            this.cBankAccount.TextWidth = 100;
            this.cBankAccount.Value = "";
            // 
            // cLegalRepre
            // 
            this.cLegalRepre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLegalRepre.Label = "法人代表：";
            this.cLegalRepre.LabelWidth = 75;
            this.cLegalRepre.Location = new System.Drawing.Point(3, 323);
            this.cLegalRepre.Name = "cLegalRepre";
            this.cLegalRepre.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cLegalRepre.Size = new System.Drawing.Size(501, 26);
            this.cLegalRepre.TabIndex = 14;
            this.cLegalRepre.TextWidth = 100;
            this.cLegalRepre.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 355);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 11);
            this.cGUID.TabIndex = 15;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 48;
            this.cTimeStamp.Location = new System.Drawing.Point(3, 372);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 29);
            this.cTimeStamp.TabIndex = 16;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // CustomerDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CustomerDetailForm";
            this.Text = "客户";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private TS.Sys.Platform.Widgets.LabelEdit cAddress;
        private TS.Sys.Platform.Widgets.LabelEdit cFax;
        private TS.Sys.Platform.Widgets.LabelEdit cPhone;
        private TS.Sys.Platform.Widgets.LabelEdit cContactor;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cRegion;
        private TS.Sys.Platform.Widgets.LabelEdit cZip;
        private TS.Sys.Platform.Widgets.LabelEdit cBank;
        private TS.Sys.Platform.Widgets.LabelEdit cBankAccount;
        private TS.Sys.Platform.Widgets.LabelEdit cLegalRepre;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private Widgets.LabelEdit cTimeStamp;
    }
}