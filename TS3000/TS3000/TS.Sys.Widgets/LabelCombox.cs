using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets
{
    public partial class LabelCombox : UserControl
    {
        
        public LabelCombox()
        {
            InitializeComponent();
        }

        private bool require;
        private RequireSelect _require; 
        public enum RequireSelect
        {
            True,
            False,
        }

        public Boolean IsRequire
        {
            get { return this.require; }
        }

        public RequireSelect Require
        {
            set
            {
                _require = value;
                if (value == RequireSelect.True)
                {
                    require = true;
                    //如果控件可用则用必填项的颜色，否则用不可用的颜色
                    if (this.comboBox.Enabled == true)
                    {
                        this.comboBox.BackColor = SystemColors.Info;
                    }
                }
                else
                {
                    require = false;
                    if (!require && !Enabled)
                        this.comboBox.BackColor = SystemColors.HighlightText;
                }

            }
            get { return this._require; }

        }

        /// <summary>
        /// 是否可用
        /// </summary>
        public new Boolean Enabled
        {
            set
            {
                this.comboBox.Enabled = value;
                if (!value)
                {
                    this.comboBox.BackColor = Color.MistyRose;
                }
                else
                {
                    this.comboBox.BackColor = SystemColors.HighlightText;
                }
            }
            get
            {
                return this.comboBox.Enabled;
            }
        }

        public String Label
        {
            set { this.label.Text = value; }
            get { return this.label.Text; }
        }

        private String sql;
        /// <summary>
        /// select value name from table
        /// name:显示名称
        /// value:控件值
        /// </summary>
        public String Sql
        {
            set { this.sql = value; }
            get { return this.sql; }
        }

        private Font cbxFont;
        public Font CbxFont
        {
            set { this.cbxFont = value; }
            get { return this.cbxFont; }
        }

       

        public Object Value
        {
            set
            {
                if (value == null)
                {
                    this.comboBox.SelectedValue = "";
                }
                else
                {
                    this.comboBox.SelectedValue = value;
                }
            }
            get { return this.comboBox.SelectedValue; }
        }

        private string _items;
        public String ItemValues
        {
            set { this._items = value; }
            get { return this._items; }
        }

        public bool Editable
        {
            set { if(!value) this.comboBox.DropDownStyle = ComboBoxStyle.DropDownList; }
            get { return this.comboBox.DropDownStyle == ComboBoxStyle.DropDownList; }
        }

        public int LabelWidth
        {
            set
            {
                this.label.Width = value;
                this.tableLayoutPanel1.ColumnStyles[0].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[0].Width; }
        }

        public ComboBox Combox
        {
            get { return this.comboBox; }
            set { this.comboBox = value; }
        }
        private void LabelCombox_Resize(object sender, EventArgs e)
        {
            this.comboBox.Width = this.Width - this.label.Width;
        }

        

        private void LabelCombox_Load(object sender, System.EventArgs e)
        {
            this.comboBox.ValueMember = "value";
            this.comboBox.DisplayMember = "name";
            if (this.sql != null)
            {                
                this.comboBox.DataSource = TS.Sys.DBLayer.DbSvr.GetDbService().GetDataTable(this.sql);
            }
            else if (this._items != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("value");
                dt.Columns.Add("name");
                String[] cols = _items.ToString().Split(';');
                foreach(String str in cols)
                {
                    String[] items = str.Split(':');
                    dt.LoadDataRow(items, true);
                }
                this.comboBox.DataSource = dt;
            }
        }

        /// <summary>
        /// 自定义事件，TextBoxKeyDown事件
        /// </summary>
        public event EventHandler ComboxSelectedValueChanged;
        private void comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (ComboxSelectedValueChanged != null)
                ComboxSelectedValueChanged(this, e);
        }
    }
}
