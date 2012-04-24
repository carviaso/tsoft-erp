namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberAllowFomula
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
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.gbParamControl = new System.Windows.Forms.GroupBox();
            this.labMemberNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllowBase = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnMemberNumAdd = new TS.Sys.Platform.Widgets.LabelEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMemberAllowAdd = new TS.Sys.Platform.Widgets.LabelEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.MemberAllowInit = new TS.Sys.Platform.Widgets.LabelEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.MemberNumMax = new TS.Sys.Platform.Widgets.LabelEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolItem.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.gbParamControl.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.toolItem, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbParamControl, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 292);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // toolItem
            // 
            this.toolItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.toolExit});
            this.toolItem.Location = new System.Drawing.Point(0, 0);
            this.toolItem.Name = "toolItem";
            this.toolItem.Size = new System.Drawing.Size(386, 45);
            this.toolItem.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(36, 42);
            this.btnSave.Text = "保存";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolExit
            // 
            this.toolExit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Exit;
            this.toolExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(36, 42);
            this.toolExit.Text = "退出";
            this.toolExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.label7);
            this.gbControl.Controls.Add(this.label6);
            this.gbControl.Controls.Add(this.label5);
            this.gbControl.Controls.Add(this.label4);
            this.gbControl.Controls.Add(this.label3);
            this.gbControl.Controls.Add(this.label2);
            this.gbControl.Controls.Add(this.btnAllowBase);
            this.gbControl.Controls.Add(this.label1);
            this.gbControl.Controls.Add(this.labMemberNum);
            this.gbControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbControl.Location = new System.Drawing.Point(3, 48);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(380, 74);
            this.gbControl.TabIndex = 5;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "津贴计算公式";
            // 
            // gbParamControl
            // 
            this.gbParamControl.Controls.Add(this.tpControl);
            this.gbParamControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbParamControl.Location = new System.Drawing.Point(3, 128);
            this.gbParamControl.Name = "gbParamControl";
            this.gbParamControl.Size = new System.Drawing.Size(380, 161);
            this.gbParamControl.TabIndex = 6;
            this.gbParamControl.TabStop = false;
            this.gbParamControl.Text = "公式参数";
            // 
            // labMemberNum
            // 
            this.labMemberNum.AutoSize = true;
            this.labMemberNum.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMemberNum.Location = new System.Drawing.Point(32, 35);
            this.labMemberNum.Name = "labMemberNum";
            this.labMemberNum.Size = new System.Drawing.Size(47, 19);
            this.labMemberNum.TabIndex = 0;
            this.labMemberNum.Text = "人数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(84, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "*";
            // 
            // btnAllowBase
            // 
            this.btnAllowBase.AutoSize = true;
            this.btnAllowBase.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAllowBase.Location = new System.Drawing.Point(115, 35);
            this.btnAllowBase.Name = "btnAllowBase";
            this.btnAllowBase.Size = new System.Drawing.Size(29, 19);
            this.btnAllowBase.TabIndex = 2;
            this.btnAllowBase.Text = "40";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(153, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(183, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "(";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(200, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(217, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "+";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(234, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "津贴幅度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(317, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = ")";
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 2;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tpControl.Controls.Add(this.label11, 1, 3);
            this.tpControl.Controls.Add(this.label10, 1, 2);
            this.tpControl.Controls.Add(this.label9, 1, 1);
            this.tpControl.Controls.Add(this.btnMemberNumAdd, 0, 0);
            this.tpControl.Controls.Add(this.label8, 1, 0);
            this.tpControl.Controls.Add(this.btnMemberAllowAdd, 0, 1);
            this.tpControl.Controls.Add(this.MemberAllowInit, 0, 2);
            this.tpControl.Controls.Add(this.MemberNumMax, 0, 3);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(3, 17);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 5;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tpControl.Size = new System.Drawing.Size(374, 141);
            this.tpControl.TabIndex = 0;
            // 
            // btnMemberNumAdd
            // 
            this.btnMemberNumAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMemberNumAdd.Label = "会员增长人数：";
            this.btnMemberNumAdd.LabelWidth = 100;
            this.btnMemberNumAdd.Location = new System.Drawing.Point(3, 3);
            this.btnMemberNumAdd.Name = "btnMemberNumAdd";
            this.btnMemberNumAdd.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.btnMemberNumAdd.Size = new System.Drawing.Size(251, 24);
            this.btnMemberNumAdd.TabIndex = 0;
            this.btnMemberNumAdd.TextWidth = 100;
            this.btnMemberNumAdd.Value = "";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "人";
            // 
            // btnMemberAllowAdd
            // 
            this.btnMemberAllowAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMemberAllowAdd.Label = "津贴增长幅度：";
            this.btnMemberAllowAdd.LabelWidth = 100;
            this.btnMemberAllowAdd.Location = new System.Drawing.Point(3, 33);
            this.btnMemberAllowAdd.Name = "btnMemberAllowAdd";
            this.btnMemberAllowAdd.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.btnMemberAllowAdd.Size = new System.Drawing.Size(251, 24);
            this.btnMemberAllowAdd.TabIndex = 2;
            this.btnMemberAllowAdd.TextWidth = 100;
            this.btnMemberAllowAdd.Value = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(260, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "%";
            // 
            // MemberAllowInit
            // 
            this.MemberAllowInit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MemberAllowInit.Label = "津贴起始额度：";
            this.MemberAllowInit.LabelWidth = 100;
            this.MemberAllowInit.Location = new System.Drawing.Point(3, 63);
            this.MemberAllowInit.Name = "MemberAllowInit";
            this.MemberAllowInit.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.MemberAllowInit.Size = new System.Drawing.Size(251, 26);
            this.MemberAllowInit.TabIndex = 4;
            this.MemberAllowInit.TextWidth = 100;
            this.MemberAllowInit.Value = "";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "%";
            // 
            // MemberNumMax
            // 
            this.MemberNumMax.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MemberNumMax.Label = "会员人数上限：";
            this.MemberNumMax.LabelWidth = 100;
            this.MemberNumMax.Location = new System.Drawing.Point(3, 95);
            this.MemberNumMax.Name = "MemberNumMax";
            this.MemberNumMax.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.MemberNumMax.Size = new System.Drawing.Size(251, 25);
            this.MemberNumMax.TabIndex = 6;
            this.MemberNumMax.TextWidth = 100;
            this.MemberNumMax.Value = "";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(260, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "人";
            // 
            // MemberAllowFomula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 292);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MemberAllowFomula";
            this.Text = "MemberAllowFomula";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolItem.ResumeLayout(false);
            this.toolItem.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.gbParamControl.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.tpControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolItem;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.GroupBox gbParamControl;
        private System.Windows.Forms.Label labMemberNum;
        private System.Windows.Forms.Label btnAllowBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private Widgets.LabelEdit btnMemberNumAdd;
        private System.Windows.Forms.Label label8;
        private Widgets.LabelEdit btnMemberAllowAdd;
        private System.Windows.Forms.Label label9;
        private Widgets.LabelEdit MemberAllowInit;
        private System.Windows.Forms.Label label10;
        private Widgets.LabelEdit MemberNumMax;
        private System.Windows.Forms.Label label11;
    }
}