using System.Data;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets
{
    class LabelEditDataFetcher
    {
        public LabelEditDataFetcher(FlowLayoutPanel panel, DataTable db)
       {
           SetDataSource(panel,db);
       }
        
       private void SetDataSource(FlowLayoutPanel panel,DataTable db)
       {
           foreach (Control control in panel.Controls)
           {
               control.DataBindings.Add("text", db, control.Name);
           }
       }
    
    }
}
