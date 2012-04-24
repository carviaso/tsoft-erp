namespace TS.Sys.Platform.Forms.SysManager
{
    partial class RoleSecuForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpControl = new System.Windows.Forms.TableLayoutPanel();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.treeSecu = new TS.Sys.Platform.Widgets.DataTree();
            this.gridBtnSecu = new System.Windows.Forms.DataGridView();
            this.secStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cBtnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModualName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModualCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBtnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tpControl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBtnSecu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tpControl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 248F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 517);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(685, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "基本信息栏";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "基本信息栏";
            // 
            // tpControl
            // 
            this.tpControl.ColumnCount = 2;
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.65116F));
            this.tpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.34884F));
            this.tpControl.Controls.Add(this.cCode, 0, 0);
            this.tpControl.Controls.Add(this.cName, 1, 0);
            this.tpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpControl.Location = new System.Drawing.Point(3, 74);
            this.tpControl.Name = "tpControl";
            this.tpControl.RowCount = 1;
            this.tpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tpControl.Size = new System.Drawing.Size(685, 38);
            this.tpControl.TabIndex = 5;
            // 
            // cCode
            // 
            this.cCode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cCode.Enabled = false;
            this.cCode.Label = "编号：";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(3, 6);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cCode.Size = new System.Drawing.Size(299, 29);
            this.cCode.TabIndex = 0;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // cName
            // 
            this.cName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cName.Enabled = false;
            this.cName.Label = "名称：";
            this.cName.LabelWidth = 75;
            this.cName.Location = new System.Drawing.Point(308, 6);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.True;
            this.cName.Size = new System.Drawing.Size(374, 29);
            this.cName.TabIndex = 1;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.47646F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.52354F));
            this.tableLayoutPanel2.Controls.Add(this.treeSecu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gridBtnSecu, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 144);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(685, 370);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // treeSecu
            // 
            this.treeSecu.Active = TS.Sys.Platform.Widgets.DataTree.ActiveSelection.False;
            this.treeSecu.DisplayType = TS.Sys.Platform.Widgets.DataTree.DisplayTypeList.Name;
            this.treeSecu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeSecu.Location = new System.Drawing.Point(3, 3);
            this.treeSecu.Name = "treeSecu";
            this.treeSecu.Size = new System.Drawing.Size(250, 364);
            this.treeSecu.SqlFetcher = null;
            this.treeSecu.TabIndex = 0;
            this.treeSecu.Table = "Sys_SysMenu";
            this.treeSecu.AfterTreeNodeSelect += new System.EventHandler(this.treeSecu_AfterTreeNodeSelect);
            this.treeSecu.AfterTreeNodeCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeSecu_AfterTreeNodeCheck);
            this.treeSecu.BeforeTreeNodeCheck += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeSecu_BeforeTreeNodeCheck);
            // 
            // gridBtnSecu
            // 
            this.gridBtnSecu.AllowUserToAddRows = false;
            this.gridBtnSecu.AllowUserToDeleteRows = false;
            this.gridBtnSecu.AllowUserToResizeRows = false;
            this.gridBtnSecu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBtnSecu.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridBtnSecu.ColumnHeadersHeight = 35;
            this.gridBtnSecu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.secStatus,
            this.cBtnName,
            this.cModualName,
            this.cModualCode,
            this.cBtnCode});
            this.gridBtnSecu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBtnSecu.Location = new System.Drawing.Point(259, 3);
            this.gridBtnSecu.Name = "gridBtnSecu";
            this.gridBtnSecu.RowHeadersVisible = false;
            this.gridBtnSecu.RowTemplate.Height = 23;
            this.gridBtnSecu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBtnSecu.Size = new System.Drawing.Size(423, 364);
            this.gridBtnSecu.TabIndex = 1;
            this.gridBtnSecu.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridBtnSecu_CellMouseUp);
            // 
            // secStatus
            // 
            this.secStatus.FalseValue = "1";
            this.secStatus.FillWeight = 60.9137F;
            this.secStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secStatus.HeaderText = "权限";
            this.secStatus.Name = "secStatus";
            this.secStatus.TrueValue = "0";
            // 
            // cBtnName
            // 
            this.cBtnName.FillWeight = 119.5432F;
            this.cBtnName.HeaderText = "按钮名称";
            this.cBtnName.Name = "cBtnName";
            this.cBtnName.ReadOnly = true;
            this.cBtnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cModualName
            // 
            this.cModualName.FillWeight = 119.5432F;
            this.cModualName.HeaderText = "所属模块";
            this.cModualName.Name = "cModualName";
            this.cModualName.ReadOnly = true;
            this.cModualName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cModualCode
            // 
            this.cModualCode.HeaderText = "模块编号";
            this.cModualCode.Name = "cModualCode";
            this.cModualCode.ReadOnly = true;
            this.cModualCode.Visible = false;
            // 
            // cBtnCode
            // 
            this.cBtnCode.HeaderText = "按钮名称";
            this.cBtnCode.Name = "cBtnCode";
            this.cBtnCode.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClear,
            this.btnSave,
            this.btnQuit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(691, 45);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::TS.Sys.Platform.Forms.Properties.Resources.New;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 42);
            this.btnClear.Text = "清空";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Exit;
            this.btnQuit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(36, 42);
            this.btnQuit.Text = "退出";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 119.5432F;
            this.dataGridViewTextBoxColumn1.HeaderText = "按钮名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 129;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 119.5432F;
            this.dataGridViewTextBoxColumn2.HeaderText = "所属模块";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 129;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "模块编号";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "按钮名称";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // RoleSecuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 517);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RoleSecuForm";
            this.Text = "权限分配";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tpControl.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBtnSecu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tpControl;
        private Widgets.LabelEdit cCode;
        private Widgets.LabelEdit cName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Widgets.DataTree treeSecu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.DataGridView gridBtnSecu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn secStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBtnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModualName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cModualCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBtnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;


    }
}