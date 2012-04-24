namespace TS.Sys.Platform.Forms.MemberMan
{
    partial class MemberRecommendForm
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
            this.treeMemberRecommend = new TS.Sys.Platform.Widgets.DataTree();
            this.SuspendLayout();
            // 
            // treeMemberRecommend
            // 
            this.treeMemberRecommend.Active = TS.Sys.Platform.Widgets.DataTree.ActiveSelection.False;
            this.treeMemberRecommend.DisplayType = TS.Sys.Platform.Widgets.DataTree.DisplayTypeList.CodeAndName;
            this.treeMemberRecommend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMemberRecommend.Location = new System.Drawing.Point(0, 0);
            this.treeMemberRecommend.Name = "treeMemberRecommend";
            this.treeMemberRecommend.Size = new System.Drawing.Size(591, 521);
            this.treeMemberRecommend.SqlFetcher = null;
            this.treeMemberRecommend.TabIndex = 0;
            this.treeMemberRecommend.Table = null;
            // 
            // MemberRecommendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 521);
            this.Controls.Add(this.treeMemberRecommend);
            this.Name = "MemberRecommendForm";
            this.Text = "会员推荐关系";
            this.ResumeLayout(false);

        }

        #endregion

        private Widgets.DataTree treeMemberRecommend;
    }
}