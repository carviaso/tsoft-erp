namespace TS.Sys.Platform.Forms.BaseDataForms
{
    partial class BankAccountDetailForm
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
            this.toolBank = new System.Windows.Forms.ToolStrip();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cBankAcct = new TS.Sys.Platform.Widgets.LabelEdit();
            this.txtFaTypeDetail = new System.Windows.Forms.Label();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cBank = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolBank, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tpControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(438, 250);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toolBank
            // 
            this.toolBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBank.Location = new System.Drawing.Point(0, 0);
            this.toolBank.Name = "toolBank";
            this.toolBank.Size = new System.Drawing.Size(438, 45);
            this.toolBank.TabIndex = 0;
            this.toolBank.Text = "toolStrip1";
            // 
            // tpControl
            // 
            this.tpControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.cTimeStamp, 0, 6);
            this.tpControl.Controls.Add(this.cGUID, 0, 5);
            this.tpControl.Controls.Add(this.cBankAcct, 0, 4);
            this.tpControl.Controls.Add(this.txtFaTypeDetail, 0, 0);
            this.tpControl.Controls.Add(this.cCode, 0, 1);
            this.tpControl.Controls.Add(this.cBank, 0, 3);
            this.tpControl.Controls.Add(this.cName, 0, 2);
            this.tpControl.Location = new System.Drawing.Point(77, 48);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 7;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpControl.Size = new System.Drawing.Size(283, 191);
            this.tpControl.TabIndex = 1;
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 48;
            this.cTimeStamp.Location = new System.Drawing.Point(3, 199);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 15);
            this.cTimeStamp.TabIndex = 9;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID:";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 178);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 15);
            this.cGUID.TabIndex = 8;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cBankAcct
            // 
            this.cBankAcct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cBankAcct.Label = "银行账号：";
            this.cBankAcct.LabelWidth = 75;
            this.cBankAcct.Location = new System.Drawing.Point(3, 148);
            this.cBankAcct.Name = "cBankAcct";
            this.cBankAcct.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cBankAcct.Size = new System.Drawing.Size(277, 24);
            this.cBankAcct.TabIndex = 7;
            this.cBankAcct.TextWidth = 100;
            this.cBankAcct.Value = "";
            // 
            // txtFaTypeDetail
            // 
            this.txtFaTypeDetail.AutoSize = true;
            this.txtFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaTypeDetail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaTypeDetail.Location = new System.Drawing.Point(3, 0);
            this.txtFaTypeDetail.Name = "txtFaTypeDetail";
            this.txtFaTypeDetail.Size = new System.Drawing.Size(277, 35);
            this.txtFaTypeDetail.TabIndex = 0;
            this.txtFaTypeDetail.Text = "银行账号";
            this.txtFaTypeDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cCode.Enabled = false;
            this.cCode.Label = "编号：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 38);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(277, 29);
            this.cCode.TabIndex = 1;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cBank
            // 
            this.cBank.DataTableName = "CM_Bank";
            this.cBank.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Bank;
            this.cBank.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cBank.Label = "银行：";
            this.cBank.LabelWidth = 75;
            this.cBank.Location = new System.Drawing.Point(3, 108);
            this.cBank.Name = "cBank";
            this.cBank.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.BankForm";
            this.cBank.ReferMapping = "";
            this.cBank.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cBank.Size = new System.Drawing.Size(277, 26);
            this.cBank.TabIndex = 3;
            this.cBank.Value = null;
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cName.Enabled = false;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(3, 73);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(277, 29);
            this.cName.TabIndex = 6;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // BankAccountDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 250);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BankAccountDetailForm";
            this.Text = "账号管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolBank;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.Label txtFaTypeDetail;
        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cBank;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private TS.Sys.Platform.Widgets.LabelEdit cTimeStamp;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private TS.Sys.Platform.Widgets.LabelEdit cBankAcct;

    }
}