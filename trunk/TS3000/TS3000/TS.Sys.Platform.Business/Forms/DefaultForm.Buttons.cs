using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace TS.Sys.Platform.Business.Forms
{
    partial class DefaultForm
    {
        private ToolStripButton btnNew;
        private ToolStripButton btnSave;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnFirst;
        private ToolStripButton btnPre;
        private ToolStripButton btnNext;
        private ToolStripButton btnLast;
        private ToolStripButton btnInfo;
        private ToolStripButton btnExit;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripSeparator toolStripSeparator5;
        private void InitButton()
        {
            btnNew = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator3 = new ToolStripSeparator();
            btnFirst = new ToolStripButton();
            btnPre = new ToolStripButton();
            btnNext = new ToolStripButton();
            btnLast = new ToolStripButton();
            btnInfo = new ToolStripButton();
            btnExit = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripSeparator5 = new ToolStripSeparator();
            //添加固定按钮，新增，修改，删除
            this.toolBtn.Items.AddRange(new ToolStripItem[] {
            btnNew,
            btnSave,
            btnDelete,
            toolStripSeparator1});
            //如果存在自定义工具栏，则添加
            if (_baseItems != null)
            {
                this.toolBtn.Items.AddRange(_baseItems);
                this.toolBtn.Items.Add(toolStripSeparator2);
            }
            //如果存在自定义工具栏，则添加
            else if (_businessItems != null)
            {
                this.toolBtn.Items.AddRange(_businessItems);
                this.toolBtn.Items.Add(toolStripSeparator2);
            }
            //如果存在自定义工具栏，则添加
            if (_items != null)
            {
                this.toolBtn.Items.AddRange(_items);
                this.toolBtn.Items.Add(toolStripSeparator3);
            }
            this.toolBtn.Items.AddRange(new ToolStripItem[] {
            btnFirst,
            btnPre,
            btnNext,
            btnLast,
            toolStripSeparator4,
            btnInfo,
            toolStripSeparator5,
            btnExit});

            // 
            // btnNew
            // 
            btnNew.Image = global::TS.Sys.Platform.Business.Properties.Resources.New;
            btnNew.ImageAlign = ContentAlignment.BottomCenter;
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(36, 42);
            btnNew.Text = "新增";
            btnNew.TextAlign = ContentAlignment.BottomCenter;
            btnNew.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNew.Click += new EventHandler(btnNew_Click);
            // 
            // btnSave
            // 
            btnSave.Image = global::TS.Sys.Platform.Business.Properties.Resources.Save;
            btnSave.ImageAlign = ContentAlignment.BottomCenter;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(36, 42);
            btnSave.Text = "保存";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSave.Click += new EventHandler(btnSave_Click);
            // 
            // btnDelete
            // 
            btnDelete.Image = global::TS.Sys.Platform.Business.Properties.Resources.Delete;
            btnDelete.ImageAlign = ContentAlignment.BottomCenter;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(36, 42);
            btnDelete.Text = "删除";
            btnDelete.TextAlign = ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDelete.Click += new EventHandler(btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
             
            // 
            // btnFirst
            // 
            btnFirst.Image = global::TS.Sys.Platform.Business.Properties.Resources.page_first;
            btnFirst.ImageAlign = ContentAlignment.BottomCenter;
            btnFirst.ImageTransparentColor = Color.Magenta;
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(36, 42);
            btnFirst.Text = "首张";
            btnFirst.TextAlign = ContentAlignment.BottomCenter;
            btnFirst.TextImageRelation = TextImageRelation.ImageAboveText;
            btnFirst.Click += new EventHandler(btnFirst_Click);
            // 
            // btnPre
            // 
            btnPre.Image = global::TS.Sys.Platform.Business.Properties.Resources.page_prev;
            btnPre.ImageAlign = ContentAlignment.BottomCenter;
            btnPre.ImageTransparentColor = Color.Magenta;
            btnPre.Name = "btnPre";
            btnPre.Size = new Size(36, 42);
            btnPre.Text = "前张";
            btnPre.TextAlign = ContentAlignment.BottomCenter;
            btnPre.TextImageRelation = TextImageRelation.ImageAboveText;
            btnPre.Click += new EventHandler(btnPre_Click);
            // 
            // btnNext
            // 
            btnNext.Image = global::TS.Sys.Platform.Business.Properties.Resources.page_next;
            btnNext.ImageAlign = ContentAlignment.BottomCenter;
            btnNext.ImageTransparentColor = Color.Magenta;
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(36, 42);
            btnNext.Text = "后张";
            btnNext.TextAlign = ContentAlignment.BottomCenter;
            btnNext.TextImageRelation = TextImageRelation.ImageAboveText;
            btnNext.Click += new EventHandler(btnNext_Click);
            // 
            // btnLast
            // 
            btnLast.Image = global::TS.Sys.Platform.Business.Properties.Resources.page_last;
            btnLast.ImageAlign = ContentAlignment.BottomCenter;
            btnLast.ImageTransparentColor = Color.Magenta;
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(36, 42);
            btnLast.Text = "末张";
            btnLast.TextAlign = ContentAlignment.BottomCenter;
            btnLast.TextImageRelation = TextImageRelation.ImageAboveText;
            btnLast.Click += new EventHandler(btnLast_Click);
            // 
            // btnInfo
            // 
            btnInfo.Enabled = false;
            btnInfo.Image = global::TS.Sys.Platform.Business.Properties.Resources.See;
            btnInfo.ImageAlign = ContentAlignment.BottomCenter;
            btnInfo.ImageTransparentColor = Color.Magenta;
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(36, 42);
            btnInfo.Text = "资料";
            btnInfo.TextAlign = ContentAlignment.BottomCenter;
            btnInfo.TextImageRelation = TextImageRelation.ImageAboveText;
            btnInfo.Click += new EventHandler(btnInfo_Click);

            // 
            // btnExit
            // 
            btnExit.Image = global::TS.Sys.Platform.Business.Properties.Resources.Exit;
            btnExit.ImageAlign = ContentAlignment.BottomCenter;
            btnExit.ImageTransparentColor = Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(36, 42);
            btnExit.Text = "退出";
            btnExit.TextAlign = ContentAlignment.BottomCenter;
            btnExit.TextImageRelation = TextImageRelation.ImageAboveText;
            btnExit.Click += new EventHandler(btnExit_Click);

            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 45);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 45);
        } 

    }
}
