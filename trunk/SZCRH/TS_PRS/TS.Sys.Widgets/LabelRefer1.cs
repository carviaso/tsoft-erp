using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Sys.Widgets.Refer.Fetcher.Refer;
using TS.Sys.Util;
using TS.Sys.Widgets.Refer.Fetcher.Refer.Impl;
using System.Collections;
using TS.Sys.Widgets.Refer.Control; 

namespace TS.Sys.Widgets
{
    public partial class LabelRefer1 : UserControl
    {
        /*
        public LabelRefer()
        {
            InitializeComponent(); 
        }        
         
        /// <summary>
        /// 初始化参照的值
        /// </summary>
        /// <param name="referType"></param>
        private void initReferData(ReferType referType)
        {
            Type t = referType.GetType();
            String tableName = "CM_"+System.Enum.GetName(t,referType);
            //DataControl.DataFetcher = new DataFetcher(tableName);
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

        private ReferType _referType;
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
         

        /// <summary>
        /// 自定义事件，TextBoxKeyDown事件
        /// </summary>
        public event EventHandler AfterSelect;
        private void dataControl_AfterSelector(object sender, EventArgs e)
        {
            if (AfterSelect != null)
                AfterSelect(this, e);
        }

        public event EventHandler SelectValueChanged;
        private void dataControl_SelectedValueChanged(object sender, EventArgs e)
        {
            if (SelectValueChanged != null)
                SelectValueChanged(this, e);
        }

        public event EventHandler KeyDown;
        private void dataControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (KeyDown != null)
                KeyDown(this, e);
        }*/
    }
}
