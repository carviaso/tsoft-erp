using System;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Refer.Control;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using System.Drawing;
using System.Data;
using System.Collections;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer;

namespace TS.Sys.Platform.Widgets.Refer.GridRefer
{
    public class DataGridViewDataControlEditingControl : TextBox, IDataGridViewEditingControl
    {
        protected int rowIndex;
        private DataGridView _dataGridView;
        ToolStripControlHost dataGridViewHost;
        ToolStripDropDown dropDown; 
        private DataFetcher _dataFetcher;
        private Hashtable _referValue;
        private Hashtable _referMapping;
        private bool _IsDropShow = false;
        private bool _IsAutoSize = false;
        private int _height;
        private int _width;
        private int _singleHeight = 20;
        private int DropHeight = 200;
        protected bool valueChanged = false;
        private bool _IsPress = false;
       

        public DataGridViewDataControlEditingControl()
        {
            initDropDown();
        }

        public Hashtable ReferMapping
        {
            get { return this._referMapping; }
            set { this._referMapping = value; }
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
                _IsPress = false;

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
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            {
                DropDataGridView.Focus();
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
            NotifyDataGridViewOfValueChange();
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
        //  当text值发生变化时，通知DataGridView
        private void NotifyDataGridViewOfValueChange()
        {
            valueChanged = true;
            EditingControlDataGridView.NotifyCurrentCellDirty(true);
        }

        /// <summary>
        ///     实现 the IDataGridViewEditingControl.EditingControlFormattedValue属性
        ///     获取或设置编辑器正在修改的单元格的格式化值
        /// </summary>
        public object EditingControlFormattedValue
        {
            set
            {
                base.Text = value.ToString();
                /*if (value != null)
                    this.DataControl.Value = value.ToString();*/
                NotifyDataGridViewOfValueChange();
            }
            get
            {
                 
                return this.Text;
            }

        } 


        /// <summary>
        /// 在Cell被编辑的时候光标显示
        /// </summary>
        public Cursor EditingPanelCursor
        {
            get
            {
                return Cursors.IBeam;
            }
        }
        /// <summary>
        ///     
        ///     
        /// </summary>
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return _dataGridView;
            }

            set
            {
                _dataGridView = value;
            }
        }
         

       
        /*
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (this.EditingControlFormattedValue != null)
            {
                this.Text = this.EditingControlFormattedValue.ToString();
                //this.DataControl.LeaveAction(e);
            }
           // Hashtable result = this.DataFetcher.GetReferResult(this.Value);
           // this.EditingControlFormattedValue = "aafd";// result["cName"].ToString();
        }*/
        /// <summary>
        /// 获取控件的Text值
        /// </summary>
        /// <param name="context">错误上下文</param>
        /// <returns></returns>
        public virtual object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            Object tset = this.Text;
            return this.Text;
        }

        /// <summary>
        /// 编辑键盘
        /// </summary>
        /// <param name="keyData"></param>
        /// <param name="dataGridViewWantsInputKey"></param>
        /// <returns></returns>
        public bool EditingControlWantsInputKey(
       Keys key, bool dataGridViewWantsInputKey)
        {
            // Let the DateTimePicker handle the keys listed.
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }
        public virtual bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }
        /// <summary>
        /// 控件所在行
        /// </summary>
        public int EditingControlRowIndex
        {
            get
            {
                return this.rowIndex;
            }

            set
            {
                this.rowIndex = value;
            }
        }
        /// <summary>
        /// 设置样式
        /// </summary>
        /// <param name="dataGridViewCellStyle"></param>
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.ForeColor = dataGridViewCellStyle.ForeColor;
            this.BackColor = dataGridViewCellStyle.BackColor;
        }
        /// <summary>
        /// 是否值发生了变化
        /// </summary>
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }

            set
            {
                this.valueChanged = value;
            }
        }



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

            Object cCode = DropDataGridView.SelectedRows[0].Cells["cCode"].Value;
            Object cName = DropDataGridView.SelectedRows[0].Cells["cName"].Value;
            Hashtable referValue = new Hashtable();
            if (_dataFetcher != null)
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
                    dataGridView_DoubleClick(null, null);
                }
                base.Focus();
            }
        }
        #endregion

        public DataView DataView
        {
            get
            {

                DataTable dataTable = (DataTable)DropDataGridView.DataSource;
                if (dataTable == null)
                {
                    return null;
                }
                return dataTable.DefaultView;

            }
        }

        
        public DataGridView DropDataGridView
        {
            get
            {
                return dataGridViewHost.Control as DataGridView;
            }
        }

        /// <summary>
        /// 设置下拉列表的数据源
        /// </summary>
        public Object DataSource
        {
            set
            {
                if (DropDataGridView != null)
                {
                    DropDataGridView.DataSource = value;
                }
            }
            get
            {
                return DropDataGridView.DataSource;
            }
        }


        /// <summary>
        ///     设置控件的取数器
        /// </summary>
        public DataFetcher DataFetcherImpl
        {
            set { this._dataFetcher = value; }
        }

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
                dropDown.Show(this, -5, this.Height);
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

        /// <summary>
        ///     设置关联参照值
        /// </summary>
        private void SetReferConValue()
        {
            if (_referMapping != null)
            {
                foreach (String key in _referMapping.Keys)
                {
                    Object o = EditingControlDataGridView.Columns[key];
                    if (EditingControlDataGridView.Columns[key] != null)
                    {
                        DataGridViewRow r = EditingControlDataGridView.Rows[rowIndex];
                        r.Cells[key].Value = _referValue[_referMapping[key]];
                    }
                }
            }
        }

        private void SetReferConNull()
        {
            if (_referMapping != null)
            {
                foreach (String key in _referMapping.Keys)
                {
                    if (EditingControlDataGridView.Columns[key] != null)
                    {
                        DataGridViewRow r = EditingControlDataGridView.Rows[rowIndex];
                        r.Cells[key].Value = null;
                    }
                }
            }
        }
        #endregion
    }
}

