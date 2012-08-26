using System;
using System.Drawing;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets
{
    public partial class LabelEdit : UserControl
    {
        private bool _requireFlag;
        private RequireSelect _require;
        public enum RequireSelect
        {
            True,
            False,
        }

        public LabelEdit()
        {
            InitializeComponent();
           
        }

       
        
        //[Browsable(true)]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Label
        {
            set { this.label.Text = value; }
            get { return this.label.Text; }
        }

        public Boolean IsRequire
        {
            get { return this._requireFlag; }
        }

        
 
        /// <summary>
        /// 是否必填项
        /// </summary>
        public  RequireSelect Require
        {
            set
            {
                if (value == RequireSelect.True)
                {
                    _requireFlag = true;
                    //如果控件可用则用必填项的颜色，否则用不可用的颜色
                    if (textBox.Enabled == true)
                    {
                        this.textBox.BackColor = SystemColors.Info;
                    }
                }
                else
                {
                    _requireFlag = false;
                    if(!_requireFlag&&!Enabled)
                    this.textBox.BackColor = SystemColors.HighlightText;
                }

            }
            get
            {
                if (_requireFlag)
                {
                    return RequireSelect.True;
                }
                else
                {
                    return RequireSelect.False;
                }
            }
            
        }

        /// <summary>
        /// 控件是否可用
        /// </summary>
        public Boolean Enabled
        {
            set
            {
                this.textBox.Enabled = value;
                if (!value)
                {
                    this.textBox.BackColor = Color.MistyRose;
                }
                else
                {
                    this.textBox.BackColor = SystemColors.HighlightText;
                }
            }
            get
            {
                return this.textBox.Enabled;
            }
        }
        
        public Label LabelCtrl
        {
            get { return this.label; }
        }

        public Object Value
        {
            set {
                if (value != null)
                {
                    this.textBox.Text = value.ToString();
                }
                else
                {
                    this.textBox.Text = "";
                }
            }
            get { return this.textBox.Text; }
        }
       
        public TextBox TextBox
        {
            get { return this.textBox; }
        }


        /// <summary>
        /// 设置标签宽度
        /// </summary>
        public int LabelWidth
        {
            set
            {
                this.label.Width = value;
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
                this.textBox.Width = value;
                this.tableLayoutPanel1.ColumnStyles[1].Width = value;
            }
            get { return (int)this.tableLayoutPanel1.ColumnStyles[1].Width; }
        }

        /// <summary>
        /// 自定义事件，TextBoxKeyDown事件
        /// </summary>
        public event EventHandler TextBoxKeyPress;

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TextBoxKeyPress != null)
                TextBoxKeyPress(this, e); 
        }


    }
}
