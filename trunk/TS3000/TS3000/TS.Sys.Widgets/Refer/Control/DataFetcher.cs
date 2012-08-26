using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;

namespace TS.Sys.Platform.Widgets.Refer.Control
{
    public class DataFetcher
    {
        private Object _tableName;
        public DataFetcher()
        {
        }
        public DataFetcher(Object tableName)
            : this()
        {
            this._tableName = tableName;
        }

        public Object TableName
        {
            set { this._tableName = value; }
            get { return this._tableName; }
        }

        public Hashtable GetReferResult(Object cCode)
        {
            String sql = "select * from " + _tableName+" where cCode = '"+cCode+"' or cName = '"+cCode+"'";
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            if (result.Count <= 0)
                return null;
            return (Hashtable)result[0];

        }

        public DataTable QueryVarResult(Object con)
        {
            if (con != null)
            {
                con = " where cCode like '%"+con+"%'";
            }
            String sql = "select cCode,cName from " + _tableName;

            return DbSvr.GetDbService().GetDataTable(sql + con);
        }
    }
}
