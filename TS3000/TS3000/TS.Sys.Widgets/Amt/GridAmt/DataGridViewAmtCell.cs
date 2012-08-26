using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace TS.Sys.Widgets.Amt.GridAmt
{
    public class DataGridViewAmtCell : DataGridViewTextBoxCell
    {
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            DataGridViewAmtEditingControl dataWindowControl = DataGridView.EditingControl as DataGridViewAmtEditingControl;
            DataGridViewAmtColumn dataWindowColumn =
                (DataGridViewAmtColumn)OwningColumn;

            dataWindowControl.Text = (String)this.Value;

        }

        /// <summary>
        /// 
        /// 对数值进行校验，并格式化
        /// </summary>
        private string FormatAMT(Object amtIn)
        {
            Decimal amt = Decimal.Parse(amtIn.ToString().Trim());
            amt = Math.Round(amt, 2);
            String pre1 = "";
            String pre2 = "";
            String precision = "￥";
            for (int i = 0; i < 2; i++)
            {
                pre1 += "#";
                pre2 += "0";
            }
            String _amtFormatter = "0." + pre2 + ";";
            precision += "#," + pre1 + _amtFormatter;
            return amt.ToString(precision + "-" + precision + "");



        }


        [Browsable(false)]
        public override Type EditType
        {
            get
            {
                return typeof(DataGridViewAmtEditingControl);
            }
        }

    

        public override Type ValueType
        {
            get
            {
                return typeof(string);
            }
        }
        public DataGridViewAmtEditingControl EditingDataWindow
        {
            get
            {
                DataGridViewAmtEditingControl dataWindowControl =
                    DataGridView.EditingControl as DataGridViewAmtEditingControl;

                return dataWindowControl;
            }
        }

       
    }
}
