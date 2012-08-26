namespace TS.Sys.Platform.Forms.BaseDataForms
{
    partial class RegionDetailForm
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
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.txtFaTypeDetail = new System.Windows.Forms.Label();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tpControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 210);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Location = new System.Drawing.Point(0, 0);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(424, 45);
            this.toolItem.TabIndex = 0;
            this.toolItem.Text = "toolStrip1";
            // 
            // tpControl
            // 
            this.tpControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.txtFaTypeDetail, 0, 0);
            this.tpControl.Controls.Add(this.cCode, 0, 1);
            this.tpControl.Controls.Add(this.cName, 0, 2);
            this.tpControl.Controls.Add(this.cGUID, 0, 3);
            this.tpControl.Location = new System.Drawing.Point(90, 48);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 5;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(244, 159);
            this.tpControl.TabIndex = 1;
            // 
            // txtFaTypeDetail
            // 
            this.txtFaTypeDetail.AutoSize = true;
            this.txtFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaTypeDetail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaTypeDetail.Location = new System.Drawing.Point(3, 0);
            this.txtFaTypeDetail.Name = "txtFaTypeDetail";
            this.txtFaTypeDetail.Size = new System.Drawing.Size(238, 40);
            this.txtFaTypeDetail.TabIndex = 0;
            this.txtFaTypeDetail.Text = "区域属性";
            this.txtFaTypeDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.cCode.Enabled = false;
            this.cCode.Label = "代码：";
            this.cCode.LabelWidth = 48;
            this.cCode.Location = new System.Drawing.Point(3, 43);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(238, 29);
            this.cCode.TabIndex = 1;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Top;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 48;
            this.cName.Location = new System.Drawing.Point(3, 83);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(238, 29);
            this.cName.TabIndex = 2;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID:";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 123);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 14);
            this.cGUID.TabIndex = 4;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // RegionDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 210);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegionDetailForm";
            this.Text = "区域属性";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.Label txtFaTypeDetail;
        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
    }
}