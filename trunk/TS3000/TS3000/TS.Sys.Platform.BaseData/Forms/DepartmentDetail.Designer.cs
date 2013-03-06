namespace TS.Sys.Platform.BaseData.Forms
{
    partial class DepartmentDetailForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolBtn = new System.Windows.Forms.ToolStrip();
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cParent = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cRemark = new TS.Sys.Platform.Widgets.LabelEdit();
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
            this.cCode.Size = new System.Drawing.Size(450, 26);
            this.cCode.TabIndex = 0;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 296);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // toolBtn
            // 
            this.toolBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBtn.Location = new System.Drawing.Point(0, 0);
            this.toolBtn.Name = "toolBtn";
            this.toolBtn.Size = new System.Drawing.Size(476, 45);
            this.toolBtn.TabIndex = 0;
            this.toolBtn.Text = "toolStrip1";
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControl.Location = new System.Drawing.Point(3, 48);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(470, 245);
            this.tbControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tpControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "部门属性";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.cName, 0, 1);
            this.tpControl.Controls.Add(this.cParent, 0, 2);
            this.tpControl.Controls.Add(this.cGUID, 0, 4);
            this.tpControl.Controls.Add(this.cRemark, 0, 3);
            this.tpControl.Controls.Add(this.cTimeStamp, 0, 5);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(3, 3);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 6;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(456, 213);
            this.tpControl.TabIndex = 0;
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(3, 35);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(450, 26);
            this.cName.TabIndex = 1;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cParent
            // 
            this.cParent.DataTableName = "CM_Department";
            this.cParent.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Department;
            this.cParent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cParent.Label = "所属部门：";
            this.cParent.LabelWidth = 75;
            this.cParent.Location = new System.Drawing.Point(3, 67);
            this.cParent.Name = "cParent";
            this.cParent.ReferForm = "TS.Sys.Platform.BaseData.Forms.DepartmentForm";
            this.cParent.ReferMapping = "";
            this.cParent.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.False;
            this.cParent.Size = new System.Drawing.Size(450, 26);
            this.cParent.TabIndex = 16;
            this.cParent.Value = null;
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 131);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 26);
            this.cGUID.TabIndex = 17;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // cRemark
            // 
            this.cRemark.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cRemark.Label = "备注：";
            this.cRemark.LabelWidth = 75;
            this.cRemark.Location = new System.Drawing.Point(3, 99);
            this.cRemark.Name = "cRemark";
            this.cRemark.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cRemark.Size = new System.Drawing.Size(450, 26);
            this.cRemark.TabIndex = 18;
            this.cRemark.TextWidth = 100;
            this.cRemark.Value = "";
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 48;
            this.cTimeStamp.Location = new System.Drawing.Point(3, 163);
            this.cTimeStamp.Name = "cTimeStamp";
            this.cTimeStamp.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTimeStamp.Size = new System.Drawing.Size(200, 26);
            this.cTimeStamp.TabIndex = 19;
            this.cTimeStamp.TextWidth = 100;
            this.cTimeStamp.Value = "";
            this.cTimeStamp.Visible = false;
            // 
            // DepartmentDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 296);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DepartmentDetailForm";
            this.Text = "部门属性";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolBtn;
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cParent;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private TS.Sys.Platform.Widgets.LabelEdit cRemark;
        private Widgets.LabelEdit cTimeStamp;
    }
}