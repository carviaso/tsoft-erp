namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberListFilterForm
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
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cCodeBegin = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cCodeEnd = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 223F));
            this.tableLayoutPanel1.Controls.Add(this.tpControl, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 413);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 2;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.60058F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.39942F));
            this.tpControl.Controls.Add(this.cCodeBegin, 0, 0);
            this.tpControl.Controls.Add(this.cCodeEnd, 1, 0);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(150, 48);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 3;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 294F));
            this.tpControl.Size = new System.Drawing.Size(343, 362);
            this.tpControl.TabIndex = 0;
            // 
            // cCodeBegin
            // 
            this.cCodeBegin.Label = "单据编号：";
            this.cCodeBegin.LabelWidth = 75;
            this.cCodeBegin.Location = new System.Drawing.Point(3, 3);
            this.cCodeBegin.Name = "cCodeBegin";
            this.cCodeBegin.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cCodeBegin.Size = new System.Drawing.Size(194, 24);
            this.cCodeBegin.TabIndex = 0;
            this.cCodeBegin.TextWidth = 100;
            this.cCodeBegin.Value = "";
            // 
            // cCodeEnd
            // 
            this.cCodeEnd.Label = "至";
            this.cCodeEnd.LabelWidth = 20;
            this.cCodeEnd.Location = new System.Drawing.Point(203, 3);
            this.cCodeEnd.Name = "cCodeEnd";
            this.cCodeEnd.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cCodeEnd.Size = new System.Drawing.Size(137, 24);
            this.cCodeEnd.TabIndex = 1;
            this.cCodeEnd.TextWidth = 100;
            this.cCodeEnd.Value = "";
            // 
            // MemberListFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 413);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MemberListFilterForm";
            this.Text = "会员查询";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tpControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private Widgets.LabelEdit cCodeBegin;
        private Widgets.LabelEdit cCodeEnd;
    }
}