using System;
using System.ComponentModel;
using System.Windows.Forms; 

namespace TS.Sys.Platform.Widgets.Refer.GridRefer
{
    public class GridFaCostTypeReferCell:DataGridViewTextBoxCell
    {
         

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            GridFaCostTypeReferEditingControl dataWindowControl = DataGridView.EditingControl as GridFaCostTypeReferEditingControl;
            DataGridViewDataControlColumn dataWindowColumn = (DataGridViewDataControlColumn)OwningColumn;
            //dataWindowControl.
             dataWindowControl.DataSource = dataWindowColumn.DataSource;
            dataWindowControl.Text = (string)this.Value ;
            
        }
 
        [Browsable(false)]
        public override Type EditType
        {
            get
            {
                return typeof(DataGridViewDataControlEditingControl);
            }
        } 

        public override Type ValueType
        {
            get
            {
                return typeof(object);
            }
        }
          
    }
}
