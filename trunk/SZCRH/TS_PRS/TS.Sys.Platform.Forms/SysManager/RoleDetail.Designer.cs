namespace TS.Sys.Platform.Forms.SysManager
{
    partial class RoleDetailForm
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
            this.cTimeStamp = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.txtFaTypeDetail = new System.Windows.Forms.Label();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolBtn = new System.Windows.Forms.ToolStrip();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cParent = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cTimeStamp
            // 
            this.cTimeStamp.Label = "cTimeStamp";
            this.cTimeStamp.LabelWidth = 48;
            this.cTimeStamp.Location = new System.Drawing.Point(3, 108);
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
            this.cGUID.Location = new System.Drawing.Point(3, 129);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 15);
            this.cGUID.TabIndex = 8;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // txtFaTypeDetail
            // 
            this.txtFaTypeDetail.AutoSize = true;
            this.txtFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaTypeDetail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaTypeDetail.Location = new System.Drawing.Point(3, 0);
            this.txtFaTypeDetail.Name = "txtFaTypeDetail";
            this.txtFaTypeDetail.Size = new System.Drawing.Size(295, 35);
            this.txtFaTypeDetail.TabIndex = 0;
            this.txtFaTypeDetail.Text = "角色属性";
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
            this.cCode.Size = new System.Drawing.Size(295, 29);
            this.cCode.TabIndex = 1;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tpControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 195);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // toolBtn
            // 
            this.toolBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolBtn.Location = new System.Drawing.Point(0, 0);
            this.toolBtn.Name = "toolBtn";
            this.toolBtn.Size = new System.Drawing.Size(421, 45);
            this.toolBtn.TabIndex = 0;
            this.toolBtn.Text = "toolStrip1";
            // 
            // tpControl
            // 
            this.tpControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.txtFaTypeDetail, 0, 0);
            this.tpControl.Controls.Add(this.cCode, 0, 1);
            this.tpControl.Controls.Add(this.cName, 0, 2);
            this.tpControl.Controls.Add(this.cGUID, 0, 4);
            this.tpControl.Controls.Add(this.cTimeStamp, 0, 3);
            this.tpControl.Controls.Add(this.cParent, 0, 5);
            this.tpControl.Location = new System.Drawing.Point(60, 48);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 6;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(301, 138);
            this.tpControl.TabIndex = 1;
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(3, 73);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(295, 29);
            this.cName.TabIndex = 1;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cParent
            // 
            this.cParent.Label = "label1";
            this.cParent.LabelWidth = 48;
            this.cParent.Location = new System.Drawing.Point(3, 150);
            this.cParent.Name = "cParent";
            this.cParent.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cParent.Size = new System.Drawing.Size(200, 23);
            this.cParent.TabIndex = 10;
            this.cParent.TextWidth = 100;
            this.cParent.Value = "";
            this.cParent.Visible = false;
            // 
            // RoleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 195);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RoleDetailForm";
            this.Text = "角色明细信息";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TS.Sys.Platform.Widgets.LabelEdit cTimeStamp;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private System.Windows.Forms.Label txtFaTypeDetail;
        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolBtn;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private Widgets.LabelEdit cParent;
    }
}