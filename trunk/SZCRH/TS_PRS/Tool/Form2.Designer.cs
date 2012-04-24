namespace Tool
{
    partial class Form2
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
            this.cName = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cTitle = new TS.Sys.Platform.Widgets.LabelEdit();
            this.cType = new TS.Sys.Platform.Widgets.LabelCombox();
            this.cImgPath = new TS.Sys.Platform.Widgets.LabelEdit();
            this.button1 = new System.Windows.Forms.Button();
            this.gridModual = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridModual)).BeginInit();
            this.SuspendLayout();
            // 
            // cName
            // 
            this.cName.Label = "cName";
            this.cName.LabelWidth = 48;
            this.cName.Location = new System.Drawing.Point(26, 20);
            this.cName.Name = "cName";
            this.cName.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cName.Size = new System.Drawing.Size(200, 29);
            this.cName.TabIndex = 0;
            this.cName.TextWidth = 100;
            this.cName.Value = "";
            // 
            // cTitle
            // 
            this.cTitle.Label = "cTitle";
            this.cTitle.LabelWidth = 48;
            this.cTitle.Location = new System.Drawing.Point(232, 20);
            this.cTitle.Name = "cTitle";
            this.cTitle.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cTitle.Size = new System.Drawing.Size(200, 29);
            this.cTitle.TabIndex = 1;
            this.cTitle.TextWidth = 100;
            this.cTitle.Value = "";
            // 
            // cType
            // 
            this.cType.CbxFont = null;
            this.cType.Editable = false;
            this.cType.ItemValues = "base:base;business:business";
            this.cType.Label = "cType";
            this.cType.LabelWidth = 48;
            this.cType.Location = new System.Drawing.Point(438, 20);
            this.cType.Name = "cType";
            this.cType.Require = TS.Sys.Platform.Widgets.LabelCombox.RequireSelect.True;
            this.cType.Size = new System.Drawing.Size(200, 29);
            this.cType.Sql = null;
            this.cType.TabIndex = 6;
            this.cType.Value = "base";
            // 
            // cImgPath
            // 
            this.cImgPath.Label = "cImgPath";
            this.cImgPath.LabelWidth = 75;
            this.cImgPath.Location = new System.Drawing.Point(0, 55);
            this.cImgPath.Name = "cImgPath";
            this.cImgPath.Require = TS.Sys.Platform.Widgets.LabelEdit.RequireSelect.False;
            this.cImgPath.Size = new System.Drawing.Size(226, 29);
            this.cImgPath.TabIndex = 7;
            this.cImgPath.TextWidth = 100;
            this.cImgPath.Value = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridModual
            // 
            this.gridModual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModual.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridModual.Location = new System.Drawing.Point(0, 124);
            this.gridModual.Name = "gridModual";
            this.gridModual.RowTemplate.Height = 23;
            this.gridModual.Size = new System.Drawing.Size(653, 247);
            this.gridModual.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 371);
            this.Controls.Add(this.gridModual);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cImgPath);
            this.Controls.Add(this.cType);
            this.Controls.Add(this.cTitle);
            this.Controls.Add(this.cName);
            this.Name = "Form2";
            this.Text = "模块";
            ((System.ComponentModel.ISupportInitialize)(this.gridModual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TS.Sys.Platform.Widgets.LabelEdit cName;
        private TS.Sys.Platform.Widgets.LabelEdit cTitle;
        private TS.Sys.Platform.Widgets.LabelCombox cType;
        private TS.Sys.Platform.Widgets.LabelEdit cImgPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gridModual;
    }
}