using System;
using System.ComponentModel;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Refer.Control;

namespace TS.Sys.Platform.Widgets.Refer.GridRefer
{
    public class DataGridViewDataControlCell:DataGridViewTextBoxCell
    {

        private DataGridViewDataControlEditingControl _dataWindowControl;
        private DataGridViewDataControlColumn _dataWindowColumn;

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            _dataWindowControl = DataGridView.EditingControl as DataGridViewDataControlEditingControl;
            _dataWindowColumn = (DataGridViewDataControlColumn)OwningColumn;
            _dataWindowControl.DataFetcherImpl = _dataWindowColumn.DataFetcherImpl;
            _dataWindowControl.DataSource = _dataWindowColumn.DataSource;
            _dataWindowControl.ReferMapping = _dataWindowColumn.ReferMapping;
            _dataWindowControl.EditingControlDataGridView = base.DataGridView; 
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

        public Object ReferDataSource
        {
            set { _dataWindowControl.DataSource = value; }
        }

        public DataFetcher ReferDataFetcher
        {
            set { _dataWindowControl.DataFetcherImpl = value; }
        }
          
    }
}
