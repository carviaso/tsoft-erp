using System;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets.Refer.GridRefer
{
    public class GridFaCostTypeReferColumn : DataGridViewColumn
    {
        private object m_dataSoruce = null;

        public GridFaCostTypeReferColumn()
            : base(new GridFaCostTypeReferCell())
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
                if (value != null && !value.GetType().IsAssignableFrom(typeof(GridFaCostTypeReferCell)))
                {
                    throw new InvalidCastException("不是DataGridViewDataWindowCell");
                }
                base.CellTemplate = value;
            }
        }


        public GridFaCostTypeReferCell ReferCellTemplate
        {
            get
            {
                return (GridFaCostTypeReferCell)this.CellTemplate;
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
