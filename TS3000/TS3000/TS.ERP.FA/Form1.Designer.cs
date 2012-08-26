namespace TS.ERP.FA
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gridMember = new System.Windows.Forms.DataGridView();
            this.cMemberCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMemberAllow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRecNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTeamNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolItem = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.Label();
            this.label5_value = new System.Windows.Forms.Label();
            this.labelEdit1 = new TS.Sys.Platform.Widgets.LabelEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).BeginInit();
            this.tpControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridMember
            // 
            this.gridMember.AllowDrop = true;
            this.gridMember.AllowUserToAddRows = false;
            this.gridMember.AllowUserToDeleteRows = false;
            this.gridMember.AllowUserToResizeRows = false;
            this.gridMember.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridMember.ColumnHeadersHeight = 35;
            this.gridMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMemberCode,
            this.cMemberName,
            this.iMemberAllow,
            this.iRecNum,
            this.iTeamNum});
            this.tpControl.SetColumnSpan(this.gridMember, 2);
            this.gridMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridMember.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridMember.Location = new System.Drawing.Point(3, 123);
            this.gridMember.Name = "gridMember";
            this.gridMember.ReadOnly = true;
            this.gridMember.RowTemplate.Height = 23;
            this.gridMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMember.Size = new System.Drawing.Size(1015, 358);
            this.gridMember.TabIndex = 21;
            // 
            // cMemberCode
            // 
            this.cMemberCode.Frozen = true;
            this.cMemberCode.HeaderText = "会员编号";
            this.cMemberCode.Name = "cMemberCode";
            this.cMemberCode.ReadOnly = true;
            // 
            // cMemberName
            // 
            this.cMemberName.Frozen = true;
            this.cMemberName.HeaderText = "会员名称";
            this.cMemberName.Name = "cMemberName";
            this.cMemberName.ReadOnly = true;
            // 
            // iMemberAllow
            // 
            this.iMemberAllow.HeaderText = "当月津贴";
            this.iMemberAllow.Name = "iMemberAllow";
            this.iMemberAllow.ReadOnly = true;
            // 
            // iRecNum
            // 
            this.iRecNum.HeaderText = "推荐人数";
            this.iRecNum.Name = "iRecNum";
            this.iRecNum.ReadOnly = true;
            // 
            // iTeamNum
            // 
            this.iTeamNum.HeaderText = "团队人数";
            this.iTeamNum.Name = "iTeamNum";
            this.iTeamNum.ReadOnly = true;
            // 
            // tpControl
            // 
            this.tpControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tpControl.ColumnCount = 2;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tpControl.Controls.Add(this.gridMember, 0, 3);
            this.tpControl.Controls.Add(this.labelEdit1, 0, 0);
            this.tpControl.Location = new System.Drawing.Point(3, 49);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 8;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 368F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpControl.Size = new System.Drawing.Size(1021, 578);
            this.tpControl.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1035, 684);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Location = new System.Drawing.Point(1, 1);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(1033, 45);
            this.toolItem.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtTitle, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tpControl, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 50);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.41688F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.58312F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1027, 630);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(3, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1021, 46);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5_value
            // 
            this.label5_value.AutoSize = true;
            this.label5_value.Location = new System.Drawing.Point(23, 30);
            this.label5_value.Name = "label5_value";
            this.label5_value.Size = new System.Drawing.Size(41, 12);
            this.label5_value.TabIndex = 10;
            this.label5_value.Text = "label6";
            // 
            // labelEdit1
            // 
            this.labelEdit1.Label = "label1";
            this.labelEdit1.LabelWidth = 48;
            this.labelEdit1.Location = new System.Drawing.Point(3, 3);
            this.labelEdit1.Name = "labelEdit1";
            this.labelEdit1.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.labelEdit1.Size = new System.Drawing.Size(200, 29);
            this.labelEdit1.TabIndex = 22;
            this.labelEdit1.TextWidth = 100;
            this.labelEdit1.Value = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 684);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label5_value);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridMember)).EndInit();
            this.tpControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemberCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMemberAllow;
        private System.Windows.Forms.DataGridViewTextBoxColumn iRecNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTeamNum;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private Sys.Platform.Widgets.LabelEdit labelEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Label label5_value;

    }
}

