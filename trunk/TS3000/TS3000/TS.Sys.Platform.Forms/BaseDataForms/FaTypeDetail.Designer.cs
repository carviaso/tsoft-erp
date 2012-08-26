namespace TS.Sys.Platform.Forms.BaseDataForms
{
    partial class FaTypeDetailForm
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
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.txtFaTypeDetail = new System.Windows.Forms.Label();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cAcctCode = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.cGUID = new TS.Sys.Platform.Widgets.LabelEdit();
            this.toolFaTypeDetail = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPre = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tpControl.SuspendLayout();
            this.toolFaTypeDetail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpControl
            // 
            this.tpControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tpControl.ColumnCount = 1;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.Controls.Add(this.txtFaTypeDetail, 0, 0);
            this.tpControl.Controls.Add(this.cCode, 0, 1);
            this.tpControl.Controls.Add(this.cName, 0, 2);
            this.tpControl.Controls.Add(this.cAcctCode, 0, 3);
            this.tpControl.Controls.Add(this.cGUID, 0, 4);
            this.tpControl.Location = new System.Drawing.Point(35, 48);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 5;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(230, 197);
            this.tpControl.TabIndex = 1;
            // 
            // txtFaTypeDetail
            // 
            this.txtFaTypeDetail.AutoSize = true;
            this.txtFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFaTypeDetail.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFaTypeDetail.Location = new System.Drawing.Point(3, 0);
            this.txtFaTypeDetail.Name = "txtFaTypeDetail";
            this.txtFaTypeDetail.Size = new System.Drawing.Size(224, 40);
            this.txtFaTypeDetail.TabIndex = 0;
            this.txtFaTypeDetail.Text = "收支类别";
            this.txtFaTypeDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCode.Label = "代码：";
            this.cCode.LabelWidth = 48;
            this.cCode.Location = new System.Drawing.Point(3, 48);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(224, 29);
            this.cCode.TabIndex = 1;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 48;
            this.cName.Location = new System.Drawing.Point(3, 88);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(224, 29);
            this.cName.TabIndex = 2;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cAcctCode
            // 
            this.cAcctCode.DataTableName = "CM_Account";
            this.cAcctCode.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Account;
            this.cAcctCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cAcctCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cAcctCode.Label = "科目：";
            this.cAcctCode.LabelWidth = 48;
            this.cAcctCode.Location = new System.Drawing.Point(3, 131);
            this.cAcctCode.Name = "cAcctCode";
            this.cAcctCode.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.AccountForm";
            this.cAcctCode.ReferMapping = "";
            this.cAcctCode.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cAcctCode.Size = new System.Drawing.Size(224, 26);
            this.cAcctCode.TabIndex = 3;
            this.cAcctCode.Value = null;
            // 
            // cGUID
            // 
            this.cGUID.Label = "cGUID";
            this.cGUID.LabelWidth = 48;
            this.cGUID.Location = new System.Drawing.Point(3, 163);
            this.cGUID.Name = "cGUID";
            this.cGUID.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cGUID.Size = new System.Drawing.Size(200, 29);
            this.cGUID.TabIndex = 4;
            this.cGUID.TextWidth = 100;
            this.cGUID.Value = "";
            this.cGUID.Visible = false;
            // 
            // toolFaTypeDetail
            // 
            this.toolFaTypeDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolFaTypeDetail.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnSave,
            this.toolStripSeparator1,
            this.btnFirst,
            this.btnPre,
            this.btnNext,
            this.btnLast,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolFaTypeDetail.Location = new System.Drawing.Point(0, 0);
            this.toolFaTypeDetail.Name = "toolFaTypeDetail";
            this.toolFaTypeDetail.Size = new System.Drawing.Size(300, 45);
            this.toolFaTypeDetail.TabIndex = 0;
            this.toolFaTypeDetail.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(36, 42);
            this.btnNew.Text = "新增";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 42);
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // btnFirst
            // 
            this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(36, 42);
            this.btnFirst.Text = "首张";
            this.btnFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPre
            // 
            this.btnPre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPre.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(36, 42);
            this.btnPre.Text = "前张";
            this.btnPre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 42);
            this.btnNext.Text = "后张";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(36, 42);
            this.btnLast.Text = "末张";
            this.btnLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // btnExit
            // 
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 42);
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolFaTypeDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tpControl, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(300, 262);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FaTypeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 262);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FaTypeDetailForm";
            this.Text = "收支类别";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaTypeDetailForm_FormClosing);
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.toolFaTypeDetail.ResumeLayout(false);
            this.toolFaTypeDetail.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpControl;
        private System.Windows.Forms.Label txtFaTypeDetail;
        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private System.Windows.Forms.ToolStrip toolFaTypeDetail;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer cAcctCode;
        private TS.Sys.Platform.Widgets.LabelEdit cGUID;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPre;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2; 

    }
}