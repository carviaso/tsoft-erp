using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;

namespace TS_PRS
{
    class DataGridViewCalendarEditingControl:GridReferControl, IDataGridViewEditingControl
    {
        int rowindex;//定义行索引
        DataGridView dataGridView;//定义DataGridView对象
        private bool valueChanged = false;//定义单元格的值是否变化

        public DataGridViewCalendarEditingControl()
        {
            //当前类继承DateTimePicker,具有DateTimePicker的功能，在构造函数中设置初始化日期格式
           // this.Format = DateTimePickerFormat.Short;
        }

        //实现 the IDataGridViewEditingControl.EditingControlFormattedValue属性

        //获取或设置编辑器正在修改的单元格的格式化值。 

        //格式化值以值在控件的用户界面上的显示形式表示该值。格式化值的绝对值甚至数据类型都可能与控件中包含的实际值不同。
        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value;//.ToShortDateString();
            }
            set
            {
                string newValue = value as string;
                if (newValue != null)
                {
                    this.Value = DateTime.Parse(newValue);
                }
            }
        }
         
        /// <summary>
        ///     实现 the IDataGridViewEditingControl.ApplyCellStyleToEditingControl method
        ///     用于设置单元格样式
        /// </summary>
        /// <param name="dataGridViewCellStyle"></param>
        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
           // this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            //this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

         
        /// <summary>
        ///     实现the IDataGridViewEditingControl.EditingControlDataGridView property
        ///     用于设置当前的datagridview
        /// </summary>
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

 
        /// <summary>
        ///      实现 the IDataGridViewEditingControl.EditingControlRowIndex property.
        ///      设置处于编辑状态的datatridview控件的行索引
        /// </summary>
        public int EditingControlRowIndex
        {
            get
            {
                return rowindex;
            }
            set
            {
                rowindex = value;
            }
        }
         
        /// <summary>
        ///     实现 the IDataGridViewEditingControl.EditingControlValueChanged property.
        ///     获取或设置控件值是否发生变化 
        /// </summary>
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        } 

        /// <summary>
        /// 实现 the IDataGridViewEditingControl.EditingControlWantsInputKey method
        /// 确定指定的键是应由编辑控件处理的常规输入键，还是应由 DataGridView 处理的特殊键
        /// DataGridView 控件调用此方法确定是要处理某个输入键还是让编辑控件处理它。
        /// 如果 keyData 包括 Up 或 Down 值，或者如果显示了下拉列表并且 keyData 包括 Escape 或 Enter 值，则此方法返回 true。
        /// 如果 dataGridViewWantsInputKey 为 false，此方法也会返回 true。否则，此方法返回 false。
        /// </summary>
        /// <param name="keyData"></param>
        /// <param name="dataGridViewWantsInputKey"></param>
        /// <returns></returns>
        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            switch (keyData & Keys.KeyCode)
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
         
        /// <summary>
        ///     实现 the IDataGridViewEditingControl.EditingPanelCursor property
        ///     编辑面板是在 DataGridView 控件处于编辑模式时用来承载编辑控件的 Panel。实际的编辑控件可能不会覆盖编辑面板的整个区域。
        ///     在这种情况下，EditingPanelCursor 实现应返回当鼠标指针位于面板上方但不位于控件上方时使用的光标。
        ///     通常，您会希望返回与控件使用的光标相同的光标。如果希望更改当指针位于控件上方时显示的光标，必须设置 Cursor 属性。
        ///     可以在IDataGridViewEditingControl 实现的构造函数中设置此属性，也可以在 PrepareEditingControlForEdit 实现中设置。 
        /// </summary>
        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }
         
        /// <summary>
        ///     实现 the IDataGridViewEditingControl.GetEditingControlFormattedValue method.
        ///     检索单元格的格式化值。
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }
 
        /// <summary>
        ///     准备当前选中的单元格以进行编辑。
        ///     此方法的用途是准备控件及其内容以进行编辑。例如，您可能想要将插入点放在内容的末尾，或者更改内容的对齐方式。
        /// </summary>
        /// <param name="selectAll">
        ///     类型：System..::.Boolean
        ///     为 true，则选择单元格的全部内容；否则为 false。
        /// </param>
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            //throw new NotImplementedException();
        }
         
        /// <summary>
        ///     实现 the IDataGridViewEditingControl.RepositionEditingControlOnValueChange  property.
        ///     取得值，指出每當值变更时，是否需要重新定位储存格内容。
        /// </summary>
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }
         




    }
}
