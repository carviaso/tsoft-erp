using System;
using System.Data;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Refer.GridRefer;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer; 

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer
{
    public abstract class BaseRefer
    {
        protected bool PopupGridAutoSize;
        protected int DropDownHeight;
        protected int DropDownWidth;
        protected bool RowFilterVisible;
        protected DataGridView grid;
        private DataGridViewDataControlColumn _col;
        protected DataGridViewDataControlColumn Col
        {
            get { return this._col; }
            set { this._col = value; }
        }

        public  DataGridView Grid
        {
            get { return this.grid; }
            set { this.grid = value; }
        }

        public BaseRefer()
        {
            PopupGridAutoSize = true;
            DropDownHeight = 800;
            DropDownWidth = 240;
            RowFilterVisible = true;
        }

        /// <summary>
        /// 设置数据源
        /// </summary>
        /// <param name="refer">参照控件对象</param>
        /// <param name="condition">索引条件</param>
        public void setDataSource(LabelRefer refer, String condition)
        {
            String sql = getSql(condition);
            DataTable referInfo = new DataTable();

            referInfo = TS.Sys.DBLayer.DbSvr.GetDbService().GetDataTable(sql); 


        }

        public void setGridDataSource(DataGridViewDataControlColumn col, String con)
        {
            _col = col;
            
            DataTable referInfo = new DataTable();
            String sql = getSql(con);
            referInfo = TS.Sys.DBLayer.DbSvr.GetDbService().GetDataTable(sql);
            _col.DataSource = referInfo; 

        }

        public abstract String getSql(String con);

        
    }
}
