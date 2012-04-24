namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberImportForm
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
            this.gridMember = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolAccount = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMemberImport = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAllImport = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlusImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cCompanyCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            this.toolAccount.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gridMember, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.toolAccount, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridMember
            // 
            this.gridMember.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cId});
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMember.Location = new System.Drawing.Point(3, 68);
            this.gridMember.Name = "gridMember";
            this.gridMember.RowTemplate.Height = 23;
            this.gridMember.Size = new System.Drawing.Size(418, 464);
            this.gridMember.TabIndex = 5;
            // 
            // cName
            // 
            this.cName.HeaderText = "会员姓名";
            this.cName.Name = "cName";
            // 
            // cId
            // 
            this.cId.HeaderText = "身份证";
            this.cId.Name = "cId";
            // 
            // toolAccount
            // 
            this.toolAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnMemberImport,
            this.toolStripSeparator2,
            this.btnExit});
            this.toolAccount.Location = new System.Drawing.Point(0, 0);
            this.toolAccount.Name = "toolAccount";
            this.toolAccount.Size = new System.Drawing.Size(424, 45);
            this.toolAccount.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 42);
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(36, 42);
            this.btnCancel.Text = "取消";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
            // 
            // btnMemberImport
            // 
            this.btnMemberImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAllImport,
            this.btnPlusImport});
            this.btnMemberImport.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Import;
            this.btnMemberImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMemberImport.Name = "btnMemberImport";
            this.btnMemberImport.Size = new System.Drawing.Size(69, 42);
            this.btnMemberImport.Text = "会员导入";
            this.btnMemberImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMemberImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAllImport
            // 
            this.btnAllImport.Name = "btnAllImport";
            this.btnAllImport.Size = new System.Drawing.Size(124, 22);
            this.btnAllImport.Text = "全量导入";
            this.btnAllImport.Click += new System.EventHandler(this.btnAllImport_Click);
            // 
            // btnPlusImport
            // 
            this.btnPlusImport.Name = "btnPlusImport";
            this.btnPlusImport.Size = new System.Drawing.Size(124, 22);
            this.btnPlusImport.Text = "追加导入";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 42);
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.98039F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.01961F));
            this.tableLayoutPanel2.Controls.Add(this.cCompanyCode, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(418, 14);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // cCompanyCode
            // 
            this.cCompanyCode.Label = "公司编号：";
            this.cCompanyCode.LabelWidth = 80;
            this.cCompanyCode.Location = new System.Drawing.Point(216, 3);
            this.cCompanyCode.Name = "cCompanyCode";
            this.cCompanyCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cCompanyCode.Size = new System.Drawing.Size(199, 8);
            this.cCompanyCode.TabIndex = 0;
            this.cCompanyCode.TextWidth = 100;
            this.cCompanyCode.Value = "";
            this.cCompanyCode.Visible = false;
            // 
            // MemberImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MemberImportForm";
            this.Text = "会员导入";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.toolAccount.ResumeLayout(false);
            this.toolAccount.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolAccount;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton btnMemberImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnAllImport;
        private System.Windows.Forms.ToolStripMenuItem btnPlusImport;
        private System.Windows.Forms.DataGridView gridMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Widgets.LabelEdit cCompanyCode;
    }
}