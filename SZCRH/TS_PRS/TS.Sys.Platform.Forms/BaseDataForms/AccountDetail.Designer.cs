namespace TS.Sys.Platform.Forms.BaseDataForms
{
    partial class AccountDetailForm
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
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cShortCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cParent = new TS.Sys.Platform.Widgets.LabelCombox();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Location = new System.Drawing.Point(0, 0);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(434, 45);
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
            this.tbControl.Size = new System.Drawing.Size(428, 211);
            this.tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 185);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "科目设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tpControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 179);
            this.panel1.TabIndex = 0;
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 2;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.cName, 0, 1);
            this.tpControl.Controls.Add(this.cShortCode, 0, 2);
            this.tpControl.Controls.Add(this.cParent, 0, 3);
            this.tpControl.Controls.Add(this.cGUID, 0, 4);
            this.tpControl.Controls.Add(this.cTimeStamp, 1, 4);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(0, 0);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 5;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(412, 177);
            this.tpControl.TabIndex = 0;
            // 
            // cCode
            // 
            this.tpControl.SetColumnSpan(this.cCode, 2);
            this.cCode.Enabled = false;
            this.cCode.Label = "科目代码：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 3);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(406, 29);
            this.cCode.TabIndex = 0;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cName
            // 
            this.tpControl.SetColumnSpan(this.cName, 2);
            this.cName.Label = "科目名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(3, 38);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(406, 29);
            this.cName.TabIndex = 1;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cShortCode
            // 
            this.tpControl.SetColumnSpan(this.cShortCode, 2);
            this.cShortCode.Label = "助记码：";
            this.cShortCode.LabelWidth = 75;
            this.cShortCode.Location = new System.Drawing.Point(3, 73);
            this.cShortCode.Name = "cShortCode";
            this.cShortCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cShortCode.Size = new System.Drawing.Size(406, 29);
            this.cShortCode.TabIndex = 2;
            this.cShortCode.TextWidth = 75;
            this.cShortCode.Value = "";
            // 
            // cParent
            // 
            this.cParent.CbxFont = null;
            this.tpControl.SetColumnSpan(this.cParent, 2);
            this.cParent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cParent.Editable = true;
            this.cParent.ItemValues = null;
            this.cParent.Label = "科目类别";
            this.cParent.LabelWidth = 75;
            this.cParent.Location = new System.Drawing.Point(3, 109);
            this.cParent.Name = "cParent";
            this.cParent.Require = TS.Sys.Platform.Widgets.LabelCombox.RequireSelect.True;
            this.cParent.Size = new System.Drawing.Size(406, 28);
            this.cParent.Sql = "select cCode value,cName name from CM_Account";
            this.cParent.TabIndex = 3;
            this.cParent.Value = "1";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 143);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 26);
            this.cGUID.TabIndex = 4;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 75;
            this.cTimeStamp.Location = new System.Drawing.Point(209, 143);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 26);
            this.cTimeStamp.TabIndex = 5;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // AccountDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 300);
            this.MinimumSize = new System.Drawing.Size(450, 300);
            this.Name = "AccountDetailForm";
            this.Text = "科目设置";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        public TS.Sys.Platform.Widgets.LabelEdit cCode;
        public TS.Sys.Platform.Widgets.LabelEdit cName;
        public TS.Sys.Platform.Widgets.LabelEdit cShortCode;
        public TS.Sys.Platform.Widgets.LabelCombox cParent;
        public TS.Sys.Platform.Widgets.LabelEdit cGUID;
        public TS.Sys.Platform.Widgets.LabelEdit cTimeStamp;
    }
}