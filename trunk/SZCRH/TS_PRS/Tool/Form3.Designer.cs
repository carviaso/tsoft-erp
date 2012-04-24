namespace Tool
{
    partial class Form3
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
            this.gridField = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.cField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.gridParent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modualCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.iOrder = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cImgPath = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cForm = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTitle = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cCode = new TS.Sys.Platform.Widgets.LabelEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridField
            // 
            this.gridField.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridField.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridField.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridField.ColumnHeadersHeight = 20;
            this.gridField.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cField});
            this.gridField.Location = new System.Drawing.Point(90, 82);
            this.gridField.Name = "gridField";
            this.gridField.RowHeadersVisible = false;
            this.gridField.RowTemplate.Height = 23;
            this.gridField.Size = new System.Drawing.Size(122, 88);
            this.gridField.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 243);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(391, 389);
            this.dataGridView2.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(90, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cField
            // 
            this.cField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cField.HeaderText = "cField";
            this.cField.Items.AddRange(new object[] {
            "base",
            "bill",
            "list",
            "report",
            "item"});
            this.cField.Name = "cField";
            // 
            // gridParent
            // 
            this.gridParent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridParent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridParent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.gridParent.ColumnHeadersHeight = 20;
            this.gridParent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cParent});
            this.gridParent.Location = new System.Drawing.Point(218, 82);
            this.gridParent.Name = "gridParent";
            this.gridParent.RowHeadersVisible = false;
            this.gridParent.RowTemplate.Height = 23;
            this.gridParent.Size = new System.Drawing.Size(122, 88);
            this.gridParent.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "cParent";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 119;
            // 
            // modualCode
            // 
            this.modualCode.Enabled = false;
            this.modualCode.Label = "modualCode";
            this.modualCode.LabelWidth = 48;
            this.modualCode.Location = new System.Drawing.Point(346, 141);
            this.modualCode.Name = "modualCode";
            this.modualCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.modualCode.Size = new System.Drawing.Size(200, 29);
            this.modualCode.TabIndex = 9;
            this.modualCode.TextWidth = 100;
            this.modualCode.Value = "";
            // 
            // iOrder
            // 
            this.iOrder.Label = "次序";
            this.iOrder.LabelWidth = 48;
            this.iOrder.Location = new System.Drawing.Point(346, 82);
            this.iOrder.Name = "iOrder";
            this.iOrder.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.iOrder.Size = new System.Drawing.Size(200, 29);
            this.iOrder.TabIndex = 8;
            this.iOrder.TextWidth = 100;
            this.iOrder.Value = "";
            // 
            // cParent
            // 
            this.cParent.HeaderText = "cParent";
            this.cParent.Name = "cParent";
            this.cParent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cParent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cImgPath
            // 
            this.cImgPath.Label = "图片路径：";
            this.cImgPath.LabelWidth = 75;
            this.cImgPath.Location = new System.Drawing.Point(12, 176);
            this.cImgPath.Name = "cImgPath";
            this.cImgPath.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cImgPath.Size = new System.Drawing.Size(534, 27);
            this.cImgPath.TabIndex = 4;
            this.cImgPath.TextWidth = 100;
            this.cImgPath.Value = "";
            // 
            // cForm
            // 
            this.cForm.Label = "cForm";
            this.cForm.LabelWidth = 75;
            this.cForm.Location = new System.Drawing.Point(12, 47);
            this.cForm.Name = "cForm";
            this.cForm.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cForm.Size = new System.Drawing.Size(534, 29);
            this.cForm.TabIndex = 2;
            this.cForm.TextWidth = 100;
            this.cForm.Value = "";
            // 
            // cTitle
            // 
            this.cTitle.Label = "显示名称：";
            this.cTitle.LabelWidth = 75;
            this.cTitle.Location = new System.Drawing.Point(256, 12);
            this.cTitle.Name = "cTitle";
            this.cTitle.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTitle.Size = new System.Drawing.Size(290, 29);
            this.cTitle.TabIndex = 1;
            this.cTitle.TextWidth = 100;
            this.cTitle.Value = "";
            // 
            // cCode
            // 
            this.cCode.Label = "cCode";
            this.cCode.LabelWidth = 75;
            this.cCode.Location = new System.Drawing.Point(12, 12);
            this.cCode.Name = "cCode";
            this.cCode.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cCode.Size = new System.Drawing.Size(238, 29);
            this.cCode.TabIndex = 0;
            this.cCode.TextWidth = 100;
            this.cCode.Value = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "保存树";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(366, 389);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 633);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modualCode);
            this.Controls.Add(this.iOrder);
            this.Controls.Add(this.gridParent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cImgPath);
            this.Controls.Add(this.gridField);
            this.Controls.Add(this.cForm);
            this.Controls.Add(this.cTitle);
            this.Controls.Add(this.cCode);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.gridField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TS.Sys.Platform.Widgets.LabelEdit cCode;
        private TS.Sys.Platform.Widgets.LabelEdit cTitle;
        private TS.Sys.Platform.Widgets.LabelEdit cForm;
        private System.Windows.Forms.DataGridView gridField;
        private TS.Sys.Platform.Widgets.LabelEdit cImgPath;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSave;
        private TS.Sys.Platform.Widgets.LabelEdit iOrder;
        private System.Windows.Forms.DataGridViewComboBoxColumn cField;
        private System.Windows.Forms.DataGridView gridParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn cParent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TS.Sys.Platform.Widgets.LabelEdit modualCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}