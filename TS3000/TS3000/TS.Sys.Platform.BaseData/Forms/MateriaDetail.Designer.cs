namespace TS.Sys.Platform.BaseData.Forms
{
    partial class MateriaDetailForm
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
            this.cUnit = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cParent = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cLocation = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cFullName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.iInPrice = new TS.Sys.Platform.Widgets.CurrencyEdit();
            this.iOutPrice = new TS.Sys.Platform.Widgets.CurrencyEdit();
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
            this.cCode.Label = "商品编码：";
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
            this.cName.Label = "商品名称：";
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
            this.tabPage1.Text = "属性";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.cName, 0, 1);
            this.tpControl.Controls.Add(this.cAddress, 0, 2);
            this.tpControl.Controls.Add(this.cUnit, 0, 5);
            this.tpControl.Controls.Add(this.cParent, 0, 4);
            this.tpControl.Controls.Add(this.cLocation, 0, 8);
            this.tpControl.Controls.Add(this.cGUID, 0, 11);
            this.tpControl.Controls.Add(this.cTimeStamp, 0, 12);
            this.tpControl.Controls.Add(this.cFullName, 0, 3);
            this.tpControl.Controls.Add(this.iInPrice, 0, 6);
            this.tpControl.Controls.Add(this.iOutPrice, 0, 7);
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
            this.cAddress.Label = "助记码：";
            this.cAddress.LabelWidth = 75;
            this.cAddress.Location = new System.Drawing.Point(3, 67);
            this.cAddress.Name = "cAddress";
            this.cAddress.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cAddress.Size = new System.Drawing.Size(501, 26);
            this.cAddress.TabIndex = 4;
            this.cAddress.TextWidth = 100;
            this.cAddress.Value = "";
            // 
            // cUnit
            // 
            this.cUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cUnit.Label = "商品单位：";
            this.cUnit.LabelWidth = 75;
            this.cUnit.Location = new System.Drawing.Point(3, 163);
            this.cUnit.Name = "cUnit";
            this.cUnit.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cUnit.Size = new System.Drawing.Size(501, 26);
            this.cUnit.TabIndex = 6;
            this.cUnit.TextWidth = 100;
            this.cUnit.Value = "";
            // 
            // cParent
            // 
            this.cParent.DataTableName = "CM_MateriaClass";
            this.cParent.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.MateriaClass;
            this.cParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cParent.Label = "所属分类：";
            this.cParent.LabelWidth = 75;
            this.cParent.Location = new System.Drawing.Point(3, 131);
            this.cParent.Name = "cParent";
            this.cParent.ReferForm = "TS.Sys.Platform.BaseData.Forms.MateriaClassForm";
            this.cParent.ReferMapping = "";
            this.cParent.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cParent.Size = new System.Drawing.Size(501, 26);
            this.cParent.TabIndex = 5;
            this.cParent.Value = null;
            // 
            // cLocation
            // 
            this.cLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLocation.Label = "产地：";
            this.cLocation.LabelWidth = 75;
            this.cLocation.Location = new System.Drawing.Point(3, 259);
            this.cLocation.Name = "cLocation";
            this.cLocation.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cLocation.Size = new System.Drawing.Size(501, 26);
            this.cLocation.TabIndex = 12;
            this.cLocation.TextWidth = 100;
            this.cLocation.Value = "";
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
            // cFullName
            // 
            this.cFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cFullName.Label = "商品全称：";
            this.cFullName.LabelWidth = 75;
            this.cFullName.Location = new System.Drawing.Point(3, 99);
            this.cFullName.Name = "cFullName";
            this.cFullName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cFullName.Size = new System.Drawing.Size(501, 26);
            this.cFullName.TabIndex = 17;
            this.cFullName.TextWidth = 100;
            this.cFullName.Value = "";
            this.cFullName.Load += new System.EventHandler(this.cFullName_Load);
            // 
            // iInPrice
            // 
            this.iInPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iInPrice.iPrecision = null;
            this.iInPrice.Label = "预设进价：";
            this.iInPrice.LabelWidth = 75;
            this.iInPrice.Location = new System.Drawing.Point(3, 195);
            this.iInPrice.Name = "iInPrice";
            this.iInPrice.Require = TS.Sys.Platform.Widgets.CurrencyEdit.RequireSelect.True;
            this.iInPrice.Size = new System.Drawing.Size(501, 26);
            this.iInPrice.TabIndex = 18;
            this.iInPrice.TextWidth = 100;
            this.iInPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // iOutPrice
            // 
            this.iOutPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iOutPrice.iPrecision = null;
            this.iOutPrice.Label = "预设售价：";
            this.iOutPrice.LabelWidth = 75;
            this.iOutPrice.Location = new System.Drawing.Point(3, 227);
            this.iOutPrice.Name = "iOutPrice";
            this.iOutPrice.Require = TS.Sys.Platform.Widgets.CurrencyEdit.RequireSelect.True;
            this.iOutPrice.Size = new System.Drawing.Size(501, 26);
            this.iOutPrice.TabIndex = 19;
            this.iOutPrice.TextWidth = 100;
            this.iOutPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // MateriaDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDetailForm";
            this.Text = "商品信息";
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
        private TS.Sys.Platform.Widgets.LabelEdit cUnit;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cParent;
        private TS.Sys.Platform.Widgets.LabelEdit cLocation;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private Widgets.LabelEdit cTimeStamp;
        private Widgets.LabelEdit cFullName;
        private Widgets.CurrencyEdit iInPrice;
        private Widgets.CurrencyEdit iOutPrice;
    }
}