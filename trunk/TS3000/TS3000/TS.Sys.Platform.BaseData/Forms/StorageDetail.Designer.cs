namespace TS.Sys.Platform.BaseData.Forms
{
    partial class StorageDetailForm
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
            this.cPhone = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cParent = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cAddress = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cManager = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
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
            this.cCode.LabelWidth = 85;
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
            this.cName.LabelWidth = 85;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(527, 330);
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
            this.tbControl.Size = new System.Drawing.Size(521, 279);
            this.tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tpControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "仓库属性";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.cName, 0, 1);
            this.tpControl.Controls.Add(this.cAddress, 0, 3);
            this.tpControl.Controls.Add(this.cGUID, 0, 6);
            this.tpControl.Controls.Add(this.cTimeStamp, 0, 7);
            this.tpControl.Controls.Add(this.cManager, 0, 2);
            this.tpControl.Controls.Add(this.cParent, 0, 5);
            this.tpControl.Controls.Add(this.cPhone, 0, 4);
            this.tpControl.Location = new System.Drawing.Point(3, 3);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 8;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(507, 245);
            this.tpControl.TabIndex = 0;
            // 
            // cPhone
            // 
            this.cPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cPhone.Label = "电话：";
            this.cPhone.LabelWidth = 85;
            this.cPhone.Location = new System.Drawing.Point(3, 131);
            this.cPhone.Name = "cPhone";
            this.cPhone.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cPhone.Size = new System.Drawing.Size(501, 26);
            this.cPhone.TabIndex = 7;
            this.cPhone.TextWidth = 100;
            this.cPhone.Value = "";
            // 
            // cParent
            // 
            this.cParent.DataTableName = "CM_Storage";
            this.cParent.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Storage;
            this.cParent.Label = "上级仓库：";
            this.cParent.LabelWidth = 85;
            this.cParent.Location = new System.Drawing.Point(3, 163);
            this.cParent.Name = "cParent";
            this.cParent.ReferForm = "TS.Sys.Platform.BaseData.Forms.StorageForm";
            this.cParent.ReferMapping = "";
            this.cParent.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cParent.Size = new System.Drawing.Size(501, 26);
            this.cParent.TabIndex = 5;
            this.cParent.Value = null;
            this.cParent.Load += new System.EventHandler(this.cParent_Load);
            // 
            // cAddress
            // 
            this.cAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cAddress.Label = "仓库地址：";
            this.cAddress.LabelWidth = 85;
            this.cAddress.Location = new System.Drawing.Point(3, 99);
            this.cAddress.Name = "cAddress";
            this.cAddress.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cAddress.Size = new System.Drawing.Size(501, 26);
            this.cAddress.TabIndex = 11;
            this.cAddress.TextWidth = 100;
            this.cAddress.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 195);
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
            this.cTimeStamp.Location = new System.Drawing.Point(3, 212);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 29);
            this.cTimeStamp.TabIndex = 16;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // cManager
            // 
            this.cManager.DataTableName = "Sys_User";
            this.cManager.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.User;
            this.cManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cManager.Label = "仓库管理员：";
            this.cManager.LabelWidth = 85;
            this.cManager.Location = new System.Drawing.Point(3, 67);
            this.cManager.Name = "cManager";
            this.cManager.ReferForm = "TS.Sys.Platform.BaseData.Forms.UserForm";
            this.cManager.ReferMapping = "";
            this.cManager.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cManager.Size = new System.Drawing.Size(501, 26);
            this.cManager.TabIndex = 17;
            this.cManager.Value = null;
            // 
            // StorageDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 330);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StorageDetailForm";
            this.Text = "仓库信息";
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
        private TS.Sys.Platform.Widgets.LabelEdit cPhone;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cParent;
        private TS.Sys.Platform.Widgets.LabelEdit cAddress;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private Widgets.LabelEdit cTimeStamp;
        private Widgets.Refer.WidgetRefer.LabelRefer cManager;
    }
}