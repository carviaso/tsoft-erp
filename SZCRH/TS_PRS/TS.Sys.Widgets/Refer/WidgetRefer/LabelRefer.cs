using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Refer.Control;

namespace TS.Sys.Platform.Widgets.Refer.WidgetRefer
{
    public partial class LabelRefer : UserControl
    {
        private Form _form;
        private Form _superForm;
        private ToolStripButton _btn;
        private String _url;
        private Object _tableName;
        private ReferType _referType;
        private bool require;
        private RequireSelect _require;
        private TableLayoutPanel _tpControl;
        private String _referStr;
        public enum RequireSelect
        {
            True,
            False,
        }

        public LabelRefer()
        {
            InitializeComponent();
        }

        public LabelRefer(Form form, ToolStripButton btn):this()
        {
            _form = form;
            _btn = btn;
        }


        /// <summary>
        /// 初始化参照的值
        /// </summary>
        /// <param name="referType"></param>
        private void initReferData(ReferType referType)
        {
            Type t = referType.GetType();
            String type = System.Enum.GetName(t, referType);
            if (_tableName == null)
            {
                _tableName = "CM_" + type;
            }
            String referForm = "TS.Sys.Platform.Forms.BaseDataForms." + type + "Form";
            if (String.IsNullOrEmpty(_url))
            {
                _url = referForm;
            }            
            DataControl.DataFetcher = new DataFetcher(_tableName);
            DataControl.ReferForm = referForm;

        }


        public String ReferForm
        {
            set { this._url = value; }
            get { return this._url; }
        }
        
        [Browsable(true)]
        public String DataTableName
        {
            set { this._tableName =value; }
            get {
                if (this._tableName != null)
                    return this._tableName.ToString();
                else
                    return "";
                }
        }

        public Boolean IsRequire
        {
            get { return this.require; }
        }
        /// <summary>
        /// 是否未必输项
        /// </summary>
        public RequireSelect Require
        {
            set
            {
                _require = value; 
                if (value == RequireSelect.True)
                {
                    require = true; 
                    //如果控件可用则用必填项的颜色，否则用不可用的颜色
                    if (dataControl.Enabled == true)
                    {
                        this.dataControl.BackColor = SystemColors.Info;
                    }
                }
                else
                {
                    require = false;
                    this.dataControl.BackColor = SystemColors.HighlightText;
                }

            }
            get { return this._require; }

        }

        /// <summary>
        /// 设置参照值所映射的控件
        /// 【格式】控件名1:列名1;控件名2:列名2;
        /// </summary>
        public String ReferMapping
        {
            set {
                _referStr = value; 
                Hashtable referMapping = new Hashtable();
                String[] values = value.Split(';');
                foreach (String v in values)
                {
                    if (String.IsNullOrEmpty(v))
                        continue;
                    String[] vDetail = v.Split(':');
                    referMapping.Add(vDetail[0], vDetail[1]);
                }
                dataControl.ReferMapping = referMapping;

            }
            get
            {
                if (String.IsNullOrEmpty(_referStr))
                    return "";
                return _referStr;
            }
        }

        /// <summary>
        /// 参照类型
        /// </summary>
        public ReferType DataType
        {
            set
            {
                this._referType = value;
                if (this._referType != 0)
                {
                    initReferData(this._referType);
                    
                }
            }
            get
            {
                return this._referType;
            }
        }



        /// <summary>
        /// 是否可用
        /// </summary>
        public new Boolean Enabled
        {
            set
            {
                this.dataControl.Enabled = value;
                this.pictureBox1.Enabled = value;
                if (!value)
                {
                    this.dataControl.BackColor = Color.MistyRose;
                }
                else
                {
                    this.dataControl.BackColor = SystemColors.HighlightText;
                }
            }
            get
            {
                return this.dataControl.Enabled;
            }
        }
        
        public String Label
        {
            set { this.label.Text = value; }
            get { return this.label.Text; }
        }

        [Browsable(false), Bindable(true)]
        public Object Value
        {
            set { this.dataControl.Value = value; }
            get { return this.dataControl.Value; }
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

        public DataControl DataControl
        {
            get { return this.dataControl; }
        }

        public void SetInfoStatus(Form form, ToolStripButton btn)
        {
            _form = form;
            _btn = btn;
        }

        public void SetInfoStatus(Form form,Form superForm,ToolStripButton btn,TableLayoutPanel tpControl)
        {
            _form = form;
            _superForm = superForm;
            _btn = btn;
            dataControl.TpControl = tpControl;
        }


        public void LocationChange()
        {
            DataControl.LocationChange();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.dataControl.ShowDropDown();
        }

        private void dataControl_Enter(object sender, EventArgs e)
        {
            this.pictureBox1.Enabled = true;
        }

        private void dataControl_Leave(object sender, EventArgs e)
        {
            this.pictureBox1.Enabled = false;
        }

      
          
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (_form != null && _btn != null)
            {
                SetReferType();
                if (_superForm != null)
                    SetSuperReferType();
                
            }
        }

        private void SetReferType()
        {
            Type t = _form.GetType();
            t.GetProperty("ReferType").SetValue(_form, _url, null);
            t.GetProperty("Args").SetValue(_form, new Object[] { this }, null);
            _btn.Enabled = true;
        }

        private void SetSuperReferType()
        {
            Type t = _superForm.GetType();
            t.GetProperty("ReferType").SetValue(_form, _url, null);
            t.GetProperty("Args").SetValue(_form, new Object[] { this }, null);
            _btn.Enabled = true;
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (_form != null && _btn != null)
            {
                _btn.Enabled = false;
            }
        }

        private void dataControl_DoubleClick(object sender, EventArgs e)
        {  
            try
            {
                Assembly tempAssembly = Assembly.GetExecutingAssembly();
                Type t = _form.GetType();
                MethodInfo m = t.GetMethod("btnInfo_Click",BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
                //Object[] args = new Object[] { null,null};
                m.Invoke(_form, null);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("该窗口不存在");
            } 
        }

        private void tableLayoutPanel1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Assembly tempAssembly = Assembly.GetExecutingAssembly();
                Type t = System.Type.GetType(_url);
                Object[] args = new Object[] { this };
                object o = System.Activator.CreateInstance(t, args);
                ((Form)o).ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("该窗口不存在");
            } 
        }
    }
}
