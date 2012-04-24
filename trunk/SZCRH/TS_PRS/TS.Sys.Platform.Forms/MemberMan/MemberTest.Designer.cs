namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberTest
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
            this.num = new TS.Sys.Platform.Widgets.LabelEdit();
            this.rec = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.button1 = new System.Windows.Forms.Button();
            this.cCompany = new TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer();
            this.SuspendLayout();
            // 
            // num
            // 
            this.num.Label = "人数：";
            this.num.LabelWidth = 75;
            this.num.Location = new System.Drawing.Point(12, 12);
            this.num.Name = "num";
            this.num.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.num.Size = new System.Drawing.Size(200, 29);
            this.num.TabIndex = 0;
            this.num.TextWidth = 100;
            this.num.Value = "";
            // 
            // rec
            // 
            this.rec.DataTableName = "CM_Member";
            this.rec.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Member;
            this.rec.Label = "推荐人：";
            this.rec.LabelWidth = 75;
            this.rec.Location = new System.Drawing.Point(12, 47);
            this.rec.Name = "rec";
            this.rec.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.MemberForm";
            this.rec.ReferMapping = "";
            this.rec.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.rec.Size = new System.Drawing.Size(200, 27);
            this.rec.TabIndex = 1;
            this.rec.Value = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cCompany
            // 
            this.cCompany.DataTableName = "CM_Customer";
            this.cCompany.DataType = TS.Sys.Platform.Widgets.Refer.ReferType.Customer;
            this.cCompany.Label = "公司:";
            this.cCompany.LabelWidth = 75;
            this.cCompany.Location = new System.Drawing.Point(12, 80);
            this.cCompany.Name = "cCompany";
            this.cCompany.ReferForm = "TS.Sys.Platform.Forms.BaseDataForms.CustomerForm";
            this.cCompany.ReferMapping = "";
            this.cCompany.Require = TS.Sys.Platform.Widgets.Refer.WidgetRefer.LabelRefer.RequireSelect.True;
            this.cCompany.Size = new System.Drawing.Size(200, 27);
            this.cCompany.TabIndex = 3;
            this.cCompany.Value = null;
            // 
            // MemberTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 172);
            this.Controls.Add(this.cCompany);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rec);
            this.Controls.Add(this.num);
            this.Name = "MemberTest";
            this.Text = "MemberTest";
            this.Load += new System.EventHandler(this.MemberTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Widgets.LabelEdit num;
        private Widgets.Refer.WidgetRefer.LabelRefer rec;
        private System.Windows.Forms.Button button1;
        private Widgets.Refer.WidgetRefer.LabelRefer cCompany;
    }
}