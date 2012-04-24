namespace TS.Sys.Platform.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.statusBottom = new System.Windows.Forms.StatusStrip();
            this.labelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelLoginDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSyncMember = new System.Windows.Forms.ToolStripMenuItem();
            this.清空业务数据慎用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除垃圾数据慎用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.窗口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArrHoriz = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArrVert = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMax = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMin = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.cfContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭所有ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量添加测试数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBottom.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.cfContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBottom
            // 
            this.statusBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelUser,
            this.toolStripStatusLabel1,
            this.labelRole,
            this.toolStripStatusLabel2,
            this.labelLoginDate});
            this.statusBottom.Location = new System.Drawing.Point(0, 720);
            this.statusBottom.Name = "statusBottom";
            this.statusBottom.Size = new System.Drawing.Size(984, 22);
            this.statusBottom.TabIndex = 1;
            this.statusBottom.Text = "statusStrip1";
            // 
            // labelUser
            // 
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // labelRole
            // 
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // labelLoginDate
            // 
            this.labelLoginDate.Name = "labelLoginDate";
            this.labelLoginDate.Size = new System.Drawing.Size(0, 17);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.文件ToolStripMenuItem,
            this.操作ToolStripMenuItem,
            this.窗口ToolStripMenuItem,
            this.btnHelp});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.MdiWindowListItem = this.窗口ToolStripMenuItem;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(984, 25);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePwd,
            this.btnLogout});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // btnChangePwd
            // 
            this.btnChangePwd.Name = "btnChangePwd";
            this.btnChangePwd.Size = new System.Drawing.Size(124, 22);
            this.btnChangePwd.Text = "修改密码";
            this.btnChangePwd.Click += new System.EventHandler(this.btnChangePwd_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(124, 22);
            this.btnLogout.Text = "注销登录";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSyncMember,
            this.清空业务数据慎用ToolStripMenuItem,
            this.清除垃圾数据慎用ToolStripMenuItem,
            this.批量添加测试数据ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // btnSyncMember
            // 
            this.btnSyncMember.Name = "btnSyncMember";
            this.btnSyncMember.Size = new System.Drawing.Size(196, 22);
            this.btnSyncMember.Text = "同步会员数据";
            this.btnSyncMember.Click += new System.EventHandler(this.btnSyncMember_Click);
            // 
            // 清空业务数据慎用ToolStripMenuItem
            // 
            this.清空业务数据慎用ToolStripMenuItem.Name = "清空业务数据慎用ToolStripMenuItem";
            this.清空业务数据慎用ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.清空业务数据慎用ToolStripMenuItem.Text = "清空业务数据（慎用）";
            this.清空业务数据慎用ToolStripMenuItem.Click += new System.EventHandler(this.清空业务数据慎用ToolStripMenuItem_Click);
            // 
            // 清除垃圾数据慎用ToolStripMenuItem
            // 
            this.清除垃圾数据慎用ToolStripMenuItem.Name = "清除垃圾数据慎用ToolStripMenuItem";
            this.清除垃圾数据慎用ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.清除垃圾数据慎用ToolStripMenuItem.Text = "清除垃圾数据（慎用）";
            this.清除垃圾数据慎用ToolStripMenuItem.Click += new System.EventHandler(this.清除垃圾数据慎用ToolStripMenuItem_Click);
            // 
            // 窗口ToolStripMenuItem
            // 
            this.窗口ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCascade,
            this.btnArrHoriz,
            this.btnArrVert,
            this.btnMax,
            this.btnMin});
            this.窗口ToolStripMenuItem.Name = "窗口ToolStripMenuItem";
            this.窗口ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.窗口ToolStripMenuItem.Text = "窗口";
            // 
            // btnCascade
            // 
            this.btnCascade.Name = "btnCascade";
            this.btnCascade.Size = new System.Drawing.Size(124, 22);
            this.btnCascade.Text = "层叠";
            this.btnCascade.Click += new System.EventHandler(this.btnCascade_Click);
            // 
            // btnArrHoriz
            // 
            this.btnArrHoriz.Name = "btnArrHoriz";
            this.btnArrHoriz.Size = new System.Drawing.Size(124, 22);
            this.btnArrHoriz.Text = "水平平铺";
            this.btnArrHoriz.Click += new System.EventHandler(this.btnArrHoriz_Click);
            // 
            // btnArrVert
            // 
            this.btnArrVert.Name = "btnArrVert";
            this.btnArrVert.Size = new System.Drawing.Size(124, 22);
            this.btnArrVert.Text = "垂直平铺";
            this.btnArrVert.Click += new System.EventHandler(this.btnArrVert_Click);
            // 
            // btnMax
            // 
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(124, 22);
            this.btnMax.Text = "最大化";
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(124, 22);
            this.btnMin.Text = "最小化";
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(44, 21);
            this.btnHelp.Text = "帮助";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // cfContextMenu
            // 
            this.cfContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.最小化ToolStripMenuItem,
            this.最大化ToolStripMenuItem,
            this.关闭ToolStripMenuItem,
            this.关闭所有ToolStripMenuItem});
            this.cfContextMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.cfContextMenu.Name = "cfContextMenu";
            this.cfContextMenu.Size = new System.Drawing.Size(125, 114);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.closeToolStripMenuItem.Text = "层叠";
            // 
            // 最小化ToolStripMenuItem
            // 
            this.最小化ToolStripMenuItem.Name = "最小化ToolStripMenuItem";
            this.最小化ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最小化ToolStripMenuItem.Text = "最小化";
            // 
            // 最大化ToolStripMenuItem
            // 
            this.最大化ToolStripMenuItem.Name = "最大化ToolStripMenuItem";
            this.最大化ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最大化ToolStripMenuItem.Text = "最大化";
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭ToolStripMenuItem.Text = "关闭";
            // 
            // 关闭所有ToolStripMenuItem
            // 
            this.关闭所有ToolStripMenuItem.Name = "关闭所有ToolStripMenuItem";
            this.关闭所有ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭所有ToolStripMenuItem.Text = "关闭所有";
            // 
            // 批量添加测试数据ToolStripMenuItem
            // 
            this.批量添加测试数据ToolStripMenuItem.Name = "批量添加测试数据ToolStripMenuItem";
            this.批量添加测试数据ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.批量添加测试数据ToolStripMenuItem.Text = "批量添加测试数据";
            this.批量添加测试数据ToolStripMenuItem.Click += new System.EventHandler(this.批量添加测试数据ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 742);
            this.Controls.Add(this.statusBottom);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.statusBottom.ResumeLayout(false);
            this.statusBottom.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.cfContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBottom;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 窗口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem btnCascade;
        private System.Windows.Forms.ToolStripMenuItem btnArrHoriz;
        private System.Windows.Forms.ToolStripMenuItem btnArrVert;
        private System.Windows.Forms.ToolStripMenuItem btnMax;
        private System.Windows.Forms.ToolStripMenuItem btnMin;
        private System.Windows.Forms.ContextMenuStrip cfContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最小化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭所有ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnLogout;
        private System.Windows.Forms.ToolStripMenuItem btnChangePwd;
        private System.Windows.Forms.ToolStripStatusLabel labelUser;
        private System.Windows.Forms.ToolStripStatusLabel labelRole;
        private System.Windows.Forms.ToolStripStatusLabel labelLoginDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem btnSyncMember;
        private System.Windows.Forms.ToolStripMenuItem 清空业务数据慎用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除垃圾数据慎用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 批量添加测试数据ToolStripMenuItem;
    }
}