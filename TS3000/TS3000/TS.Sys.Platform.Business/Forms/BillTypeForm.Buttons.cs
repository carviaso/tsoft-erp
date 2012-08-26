using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TS.Sys.Platform.Business.Forms
{
    partial class BillTypeForm
    {
        private ToolStripButton btnNew;
        private ToolStripButton btnSave;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnAudit;
        private ToolStripButton btnUnAudit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnFirst;
        private ToolStripButton btnPre;
        private ToolStripButton btnNext;
        private ToolStripButton btnLast;
        private ToolStripButton btnInfo;
        private ToolStripButton btnExit;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private void InitButton()
        {
            btnNew = new System.Windows.Forms.ToolStripButton();
            btnSave = new System.Windows.Forms.ToolStripButton();
            btnDelete = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnAudit = new System.Windows.Forms.ToolStripButton();
            btnUnAudit = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            btnFirst = new System.Windows.Forms.ToolStripButton();
            btnPre = new System.Windows.Forms.ToolStripButton();
            btnNext = new System.Windows.Forms.ToolStripButton();
            btnLast = new System.Windows.Forms.ToolStripButton();
            btnInfo = new System.Windows.Forms.ToolStripButton();
            btnExit = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._toolBtn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            btnNew,
            btnSave,
            btnDelete,
            toolStripSeparator1,
            btnAudit,
            btnUnAudit,
            toolStripSeparator2,
            btnFirst,
            btnPre,
            btnNext,
            btnLast,
            toolStripSeparator3,
            btnInfo,
            toolStripSeparator4,
            btnExit});
            
            // 
            // btnNew
            // 
            btnNew.Image = global::TS.Sys.Platform.Business.Properties.Resources.New;
            btnNew.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(36, 42);
            btnNew.Text = "新增";
            btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnNew.Click += new EventHandler(btnNew_Click);
            // 
            // btnSave
            // 
            btnSave.Image = global::TS.Sys.Platform.Business.Properties.Resources.Save;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(36, 42);
            btnSave.Text = "保存";
            btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSave.Click += new EventHandler(btnSave_Click);
            // 
            // btnDelete
            // 
            btnDelete.Image = global::TS.Sys.Platform.Business.Properties.Resources.Delete;
            btnDelete.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(36, 42);
            btnDelete.Text = "删除";
            btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnDelete.Click += new EventHandler(btnDelete_Click);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 45);
            // 
            // btnAudit
            // 
            btnAudit.Image = global::TS.Sys.Platform.Business.Properties.Resources.auditor;
            btnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAudit.Name = "btnAudit";
            btnAudit.Size = new System.Drawing.Size(36, 42);
            btnAudit.Text = "审核";
            btnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAudit.Click += new EventHandler(btnAudit_Click);
            // 
            // btnUnAudit
            // 
            btnUnAudit.Image = global::TS.Sys.Platform.Business.Properties.Resources.unauditor;
            btnUnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnUnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnUnAudit.Name = "btnUnAudit";
            btnUnAudit.Size = new System.Drawing.Size(48, 42);
            btnUnAudit.Text = "反审核";
            btnUnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnUnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnUnAudit.Click += new EventHandler(btnUnAudit_Click);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 45);
            // 
            // btnFirst
            // 
            btnFirst.Image = global::TS.Sys.Platform.Business.Properties.Resources.page_first;
            btnFirst.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new System.Drawing.Size(36, 42);
            btnFirst.Text = "首张";
            btnFirst.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnFirst.Click += new EventHandler(btnFirst_Click);
            // 
            // btnPre
            // 
            btnPre.Image = global::TS.Sys.Platform.Business.Properties.Resources.page_prev;
            btnPre.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnPre.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPre.Name = "btnPre";
            btnPre.Size = new System.Drawing.Size(36, 42);
            btnPre.Text = "前张";
            btnPre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnPre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnPre.Click += new EventHandler(btnPre_Click);
            // 
            // btnNext
            // 
            btnNext.Image = global::TS.Sys.Platform.Business.Properties.Resources.page_next;
            btnNext.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(36, 42);
            btnNext.Text = "后张";
            btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnNext.Click += new EventHandler(btnNext_Click);
            // 
            // btnLast
            // 
            btnLast.Image = global::TS.Sys.Platform.Business.Properties.Resources.page_last;
            btnLast.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnLast.Name = "btnLast";
            btnLast.Size = new System.Drawing.Size(36, 42);
            btnLast.Text = "末张";
            btnLast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLast.Click += new EventHandler(btnLast_Click);
            // 
            // btnInfo
            // 
            btnInfo.Enabled = false;
            btnInfo.Image = global::TS.Sys.Platform.Business.Properties.Resources.See;
            btnInfo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(36, 42);
            btnInfo.Text = "资料";
            btnInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnInfo.Click += new EventHandler(btnInfo_Click);

            // 
            // btnExit
            // 
            btnExit.Image = global::TS.Sys.Platform.Business.Properties.Resources.Exit;
            btnExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(36, 42);
            btnExit.Text = "退出";
            btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnExit.Click += new EventHandler(btnExit_Click);

            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 45);
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 45);
        } 
    }
}
