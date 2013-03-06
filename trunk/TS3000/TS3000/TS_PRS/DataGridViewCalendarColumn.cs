using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TS_PRS
{
    public class DataGridViewCalendarColumn : DataGridViewColumn
    {
        public DataGridViewCalendarColumn():base(new DataGridViewCalendarCell())
        {

        }

        //获取或设置用于创建新单元格的模板。

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                //确保单元格式一个DataGridViewCalendarCell]

                //一个 DataGridViewCell，列中的所有其他单元格都以它为模型。默认值为新的 DataGridViewLinkCell 实例。
                if (value!=null&&!value.GetType().IsAssignableFrom(typeof(DataGridViewCalendarCell)))
                {
                    throw new InvalidCastException("必须是一个日历单元格");
                }
                base.CellTemplate = value;
            }
        }


    }
}
