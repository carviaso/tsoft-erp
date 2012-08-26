using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TS.Sys.Widgets.Amt.GridAmt
{
    public class DataGridViewAmtColumn : DataGridViewColumn
    {
        private string _preName;

        public DataGridViewAmtColumn(): base(new DataGridViewAmtCell())
        {
        }

        public DataGridViewAmtCell AmtCellTemplate
        {
            get
            {
                return (DataGridViewAmtCell)this.CellTemplate;
            }
        }

        public object AmtValue
        {
            get
            {
                DataGridViewAmtEditingControl dataWindowControl = (DataGridViewAmtEditingControl)base.DataGridView.EditingControl;
                return dataWindowControl.Amt;
            }
        }

        public String iPrecision
        {
            get { return this._preName; }
            set
            {
                this._preName = value;
            }
        } 

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewAmtCell)))
                {
                    throw new InvalidCastException("不是DataGridViewDataWindowCell");
                }
                base.CellTemplate = value;
            }
        }
    }
}
