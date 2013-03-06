using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TS_PRS
{
    public class DataGridViewCalendarCell:DataGridViewCell
    {
        public DataGridViewCalendarCell()
            : base()
        {
            this.Style.Format = "d";
        }
         
        /// <summary>
        ///     附加并初始化寄宿的编辑控件。 
        /// </summary>
        /// <param name="rowIndex">
        ///     类型：System..::.Int32
        ///     该单元格父行的索引
        /// </param>
        /// <param name="initialFormattedValue">
        ///     类型：System..::.Object
        ///     要在控件中显示的初始值。
        /// </param>
        /// <param name="dataGridViewCellStyle">
        ///     类型：System.Windows.Forms..::.DataGridViewCellStyle
        ///     一个 DataGridViewCellStyle，确定寄宿控件的外观。
        /// </param>
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
        }

        /// <summary>
        /// 获取单元格中的数据类型
        /// </summary>
        public override Type ValueType
        {
            get
            {
                return typeof(DateTime);
            }
        }

        /// <summary>
        ///     获取单元格寄宿编辑控件的类型
        /// </summary>
        public override Type EditType
        {
            get
            {
                return typeof(DataGridViewCalendarEditingControl);
            }
        }

        
        /// <summary>
        ///     获取新记录所在行中单元格的默认值
        /// </summary>
        public override object DefaultNewRowValue
        {
            get
            {
                return DateTime.Now;
            }
        }



    }
}
