using System;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Refer.Fetcher.Refer;
using TS.Sys.Platform.Widgets.Refer.Control;
using System.ComponentModel;
using System.Collections;

namespace TS.Sys.Platform.Widgets.Refer.GridRefer
{
    public class DataGridViewDataControlColumn : DataGridViewColumn
    {
        private object m_dataSoruce = null;
        private DataFetcher _dataFetcher = null;
        private Hashtable _referMapping = null;
       

        public DataGridViewDataControlColumn() : base(new DataGridViewDataControlCell())
        {
 

        }
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewDataControlCell)))
                {
                    throw new InvalidCastException("不是DataGridViewDataWindowCell");
                }
                base.CellTemplate = value;
            }
        }
         
        
        public DataGridViewDataControlCell ReferCellTemplate
        {
            get
            {
                return (DataGridViewDataControlCell)this.CellTemplate;
            }
        }

        /// <summary>
        /// 联合参照对应关系
        /// </summary>
        public Hashtable ReferMapping
        {
            set { this._referMapping = value; }
            get { return this._referMapping; }
        }

        public DataFetcher DataFetcherImpl
        {
            set { this._dataFetcher = value; }
            get { return this._dataFetcher; }
        }

        public Object DataSource
        {
            get
            {
                return m_dataSoruce;

            }
            set
            {
                if (ReferCellTemplate != value)
                {
             
                    m_dataSoruce = value;
                   
                }
            }
        }
    }
}
