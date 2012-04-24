using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms; 

namespace TS.Sys.Platform.Widgets.Refer.Control
{
    public class DataControl:TextBox
    {
        #region 成员变量
        private const int WM_LBUTTONDOWN = 0x201, WM_LBUTTONDBLCLK = 0x203, WM_KILLFOCUS = 0x8, WM_GETTEXT = 0xd;
        ToolStripControlHost dataGridViewHost; 
        ToolStripDropDown dropDown;         
        private Hashtable _referValue;
        private object _tableName;
        private bool _IsDropShow = false;
        private bool _IsAutoSize = false;
        private int _height;
        private int _width;
        private int _singleHeight = 20;
        private int DropHeight = 200;
        private DataFetcher _dataFetcher;
        private string _referForm;
        private bool _IsPress = false;
        private Hashtable _referMapping;
        private TableLayoutPanel _tpControl;
        
        #endregion
        #region 构造函数
        public DataControl()
        {

            initDropDown();
            _referValue = new Hashtable();
        }

        public TableLayoutPanel TpControl
        {
            set { this._tpControl = value; }
        }

        public Hashtable ReferMapping
        {
            set { this._referMapping = value; }
        }

        public String ReferForm
        {
            set{this._referForm = value;}
        }

        #endregion 
        #region 绘制DataGridView以及下拉DataGridView
        private void initDropDown()
        {

            DataGridView dataGridView = new DataGridView();
            dataGridView.BackgroundColor = SystemColors.Highlight;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DoubleClick += new EventHandler(dataGridView_DoubleClick);
            dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.MultiSelect = false;
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersVisible = false;


            //设置DataGridView的数据源
            Form frmDataSource = new Form();
            frmDataSource.Controls.Add(dataGridView);
            frmDataSource.SuspendLayout();
            dataGridViewHost = new ToolStripControlHost(dataGridView);
            dataGridViewHost.AutoSize = _IsAutoSize;

            dropDown = new ToolStripDropDown();
            dropDown.Width = this.Width;
            dropDown.Items.Add(dataGridViewHost);
            dropDown.AutoClose = false;
        }
          
        public void dataGridView_DoubleClick(object sender, EventArgs e)
        {

            Object cCode = DataGridView.SelectedRows[0].Cells["cCode"].Value;
            Object cName = DataGridView.SelectedRows[0].Cells["cName"].Value;
            Hashtable referValue = new Hashtable();
            if (_dataFetcher!= null)
                this._referValue = _dataFetcher.GetReferResult(cCode);
            Text = cCode.ToString();
            SetReferConValue();
            dropDown.Close();            
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    dataGridView_DoubleClick(null,null);
                }
                base.Focus();
            }
        }

        public DataFetcher DataFetcher
        {
            set
            {
                this._dataFetcher = value;
                if(value!=null)
                DataSource = _dataFetcher.QueryVarResult(null);
            }
            get
            {
                return this._dataFetcher;
            }
        }
         
         
        public DataView DataView
        {
            get
            {

                DataTable dataTable = (DataTable)DataGridView.DataSource;
                if (dataTable == null)
                {
                    return null;
                }
                return dataTable.DefaultView;

            }
        }
        [Description("设置DataGridView属性"), Browsable(true), Category("N8")]
        public DataGridView DataGridView
        {
            get
            {
                return dataGridViewHost.Control as DataGridView;
            }
        } 
        [Description("数据源"), Browsable(true), Category("N8")]
        public Object DataSource
        {
            set
            {
                if (DataGridView != null)
                {
                    DataGridView.DataSource = value;
                }
            }
            get
            {
                return DataGridView.DataSource;
            }
        }

      
         
        public Object Value
        {
            set
            {
                if (value != null&&!String.IsNullOrEmpty(value.ToString()))
                {
                    this._referValue = _dataFetcher.GetReferResult(value);
                    if (this._referValue == null)
                    {
                        _referValue = null;
                        Text = null;
                        SetReferConNull();
                    }
                    else
                    {
                        Text = this._referValue["cName"].ToString();
                        SetReferConValue();
                    }
                }
                else
                {
                    _referValue = null;
                    Text = null;
                    SetReferConNull();
                }
            }
            get
            {
                if (_referValue != null)
                {
                    return this._referValue["cCode"];                     
                }
                else
                {
                    return null;
                }
            }
            
        }

        private void SetReferConValue()
        {
            if (_referMapping != null && _tpControl != null)
            {
                foreach (String key in _referMapping.Keys)
                {
                    if (_tpControl.Controls[key] != null)
                        ((LabelEdit)_tpControl.Controls[key]).Value = _referValue[_referMapping[key]];
                }
            }
        }

        private void SetReferConNull()
        {
            if (_referMapping != null && _tpControl != null)
            {
                foreach (String key in _referMapping.Keys)
                {
                    if (_tpControl.Controls[key] != null)
                        ((LabelEdit)_tpControl.Controls[key]).Value = null;
                }
            }
        }



       
        #endregion

        #region 方法


        public void ShowDropDown()
        {
            if (dropDown != null && DataView != null)
            {
                dataGridViewHost.AutoSize = _IsAutoSize;
                _height = GetHeight(DataView);
                if (_height == 0)
                    return;
                if (_height > DropHeight)
                    _height = DropHeight;
                dataGridViewHost.Size = new Size(300, _height);//需要重新设置 
                dropDown.Show(this, 0, this.Height);
                _IsDropShow = true;
            }
        }

        private int GetHeight(DataView dv)
        {
            return dv.Count * _singleHeight;
        }

        

        public void LocationChange()
        {
            if (_IsDropShow)
            {
                dropDown.Show(this, 0, this.Height);
            }
        }


        private string GetRowFilterString(string sText)
        {

            String sFilter = "cCode like '%" + sText + "%'";

            return sFilter;
        }

        #region 重写方法
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (Text != null && !String.IsNullOrEmpty(Text))
            {
                if (_referValue != null && _referValue["cCode"] != null)
                {
                    Text = _referValue["cCode"].ToString();
                }
            }
            else
            {
                _referValue = null;
            }

        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            String str = Text;
            if (_IsDropShow)
            {
                dropDown.Close();
                _IsDropShow = false;
            }

            if (!String.IsNullOrEmpty(str))
            {
                //获取参照的值
                if (_dataFetcher != null)
                {
                    this._referValue = _dataFetcher.GetReferResult(str);
                }

                //如果参照无值，则Text为空
                if (this._referValue == null)
                {
                    Text = null;
                }
                else
                {

                    Text = this._referValue["cName"].ToString();
                }

            }
            else
            {
                Text = null;
                SetReferConNull();
            }
            _IsPress = false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            Type t = e.KeyCode.GetType();
            Object  test = System.Enum.GetName(t, e.KeyCode);
            String Ts = Text;
            if (e.KeyCode == Keys.Down||e.KeyCode==Keys.Up)
            {
                DataGridView.Focus();
            }
            else
            {
                base.Focus();
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            _IsPress = true;
        }
         
        
        protected override void OnTextChanged(EventArgs e)
        {

            base.OnTextChanged(e);
            if (!_IsPress)
                return;
            if (DataView != null)
            {
                DataView.RowFilter = GetRowFilterString(Text);
                if (DataView.Count == 0)
                {
                    if (_IsDropShow)
                    {
                        dropDown.Close();
                        _IsDropShow = false;
                    }
                }
                else
                {
                    if (!_IsDropShow)
                    {
                        ShowDropDown();
                        _IsDropShow = true;
                    }

                }
                _height = GetHeight(DataView);
                if (_height == 0)
                    return;
                if (_height > DropHeight)
                    _height = DropHeight;
                dataGridViewHost.Size = new Size(300, _height);

            }

        }

        protected override void WndProc(ref Message m)
        {

            base.WndProc(ref m);
            if (m.Msg.Equals(WM_GETTEXT) || m.Msg.Equals(WM_KILLFOCUS))
            {
                if (_IsDropShow)
                {
                    dropDown.Close();
                    _IsDropShow = false;
                }
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dropDown != null)
                {
                    dropDown.Dispose();
                    dropDown = null;
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #endregion
       
    }
}
