using System;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets.Refer.GridRefer
{
    public class DataGridViewDataControlColumn : DataGridViewColumn
    {
        private object m_dataSoruce = null; 

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
