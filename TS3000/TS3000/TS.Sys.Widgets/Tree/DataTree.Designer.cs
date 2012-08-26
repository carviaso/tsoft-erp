namespace TS.Sys.Platform.Widgets
{
    partial class DataTree
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataTree));
            this.treeView = new System.Windows.Forms.TreeView();
            this.image_tree = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 0);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(155, 334);
            this.treeView.TabIndex = 0;
            this.treeView.BeforeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeCheck);
            this.treeView.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCheck);
            this.treeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeCollapse);
            this.treeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeExpand);
            this.treeView.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeSelect);
            this.treeView.DoubleClick += new System.EventHandler(this.treeView_DoubleClick);
            // 
            // image_tree
            // 
            this.image_tree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_tree.ImageStream")));
            this.image_tree.TransparentColor = System.Drawing.Color.Transparent;
            this.image_tree.Images.SetKeyName(0, "folder.gif");
            this.image_tree.Images.SetKeyName(1, "folder-open.gif");
            this.image_tree.Images.SetKeyName(2, "tree-leaf.gif");
            // 
            // DataTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView);
            this.Name = "DataTree";
            this.Size = new System.Drawing.Size(155, 334);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ImageList image_tree;
    }
}
