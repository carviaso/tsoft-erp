using System;
using System.Data;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets.Refer.GridRefer;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using TS.Sys.Platform.Widgets.Refer.Control;
using System.Collections; 

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
        private String _url;

        public String Url
        {
            get{return this._url;}
            set{this._url = value;}
        }

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

        /// <summary>
        /// 设置下拉框数据源（适用于Grid中的参照）
        /// </summary>
        /// <param name="col"></param>
        /// <param name="con"></param>
        /// <param name="args">
        /// 联合参照对应关系{控件名称，数据表列名}
        /// </param>
        public void setGridDataSource(DataGridViewDataControlColumn col, String con,Hashtable args)
        {
            _col = col;
            
            DataTable referInfo = new DataTable();
            String sql = getSql(con);
            referInfo = TS.Sys.DBLayer.DbSvr.GetDbService().GetDataTable(sql);
            DataFetcher dataFetcher = GetDataFetcher(); 
            _col.DataSource = dataFetcher.QueryDataSource();
            _col.DataFetcherImpl = dataFetcher;
            _col.ReferMapping = args;
        }

        public abstract String getForm();

        public abstract String getSql(String con);

        public abstract DataFetcher GetDataFetcher();

        
    }
}
