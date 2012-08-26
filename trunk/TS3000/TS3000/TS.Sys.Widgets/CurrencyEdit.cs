using System;
using System.Collections;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets
{
    public partial class CurrencyEdit : UserControl
    {
        private String _pre;
        private int _iPre;
        private Decimal _amt;
        public CurrencyEdit()
        {
            InitializeComponent();
        }

        
        //[Browsable(true)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Label
        {
            set { this.labelAMT.Text = value; }
            get { return this.labelAMT.Text; }
        }

        public bool require;
        private RequireSelect _require; 
        public enum RequireSelect
        {
            True,
            False,
        }


        public RequireSelect Require
        {
            set
            {
                _require = value;
                if (value == RequireSelect.True)
                {
                    require = true;
                }
                else
                {
                    require = false;
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
                this.textBoxAMT.Enabled = value;
            }
            get
            {
                return this.textBoxAMT.Enabled;
            }
        }


        public Label LabelCtrl
        {
            get { return this.labelAMT; }
        }


        public TextBox TextBox
        {
            get { return this.textBoxAMT; }
        }


        /// <summary>
        /// 设置标签宽度
        /// </summary>
        public int LabelWidth
        {
            set
            {
                this.labelAMT.Width = value;
                this.tableLayoutPanel1.ColumnStyles[0].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[0].Width; }
        }

        /// <summary>
        /// 设置输入框宽度
        /// </summary>
        public int TextWidth
        {
            set
            {
                this.textBoxAMT.Width = value;
                this.tableLayoutPanel1.ColumnStyles[1].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[1].Width; }
        }


        public  String iPrecision
        {
            get{ return this._pre;}
            set
            {
                if (value != null)
                {
                    String preSql = "select cUserValue from cm_csgl where cCode='" + value + "'";
                    ArrayList preList = TS.Sys.DBLayer.DbSvr.GetDbService().GetListResult(preSql);
                    if (preList.Count == 0)
                    {
                        MessageBox.Show("该参数不存在!", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this._pre = value;
                        Hashtable preInfo = (Hashtable)preList[0];
                        this._iPre = int.Parse(preInfo["cUserValue"].ToString());
                    }
                }
            }
        }

        public Decimal Value
        {
            set {FormatAMT(value);}
            get {return this._amt;}
        }

        private void textBoxAMT_Leave(object sender, EventArgs e)
        {
            if (this.textBoxAMT.Text != "")
            {
                FormatAMT(textBoxAMT.Text.Trim());
            }
        }

        /// <summary>
        /// 自定义事件，TextBoxKeyDown事件
        /// </summary>
        public event KeyEventHandler TextBoxKeyDown;     

        private void textBoxAMT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormatAMT(textBoxAMT.Text.Trim());
                if (TextBoxKeyDown != null)
                    TextBoxKeyDown(this, e); 
               
            }       
            
           
        }

        /// <summary>
        /// 
        /// 对数值进行校验，并格式化
        /// </summary>
        private void FormatAMT(Object amtIn)
        {
            try
            {

                Decimal amt = Decimal.Parse(amtIn.ToString().Trim());
                this._amt = Math.Round(amt, this._iPre);
                String pre1 = "";
                String pre2 = "";
                String precision = "￥";
                for (int i = 0; i < this._iPre; i++)
                {
                    pre1 += "#";
                    pre2 += "0";
                }
                precision += "#," + pre1 + "0." + pre2 + ";";
                string MyString = amt.ToString(precision + "-" + precision + "");
                textBoxAMT.Text = MyString;

            }
            catch (FormatException ex)
            {
                String test = ex.ToString(); 
                MessageBox.Show("请输入有效数字", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }        
        }


        /// <summary>
        /// 焦点获取时，获得该控件数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAMT_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxAMT.Text = this._amt.ToString();
        }

        /// <summary>
        /// 自定义事件，TextBoxKeyDown事件
        /// </summary>
        public event EventHandler TextBoxKeyPress;     
        private void textBoxAMT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxKeyPress != null)
                TextBoxKeyPress(this, e); 
        }        
    }
}
