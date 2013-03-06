using System;
using System.Collections;
using System.Data;
using TS.Sys.DBLayer;

namespace TS.Sys.Platform.Widgets.Refer.Control
{
    public class DataFetcher
    {
        private Object _tableName;
        private String _sql;

        public DataFetcher()
        {
        }

        public String Sql
        {
            get { return this._sql; }
            set { this._sql = value; }
        }
        
        public DataFetcher(Object tableName)
            : this()
        {
            this._tableName = tableName;
        }

        public DataFetcher(Object tableName, String sql)
            : this()
        {
            this._tableName = tableName;
            this._sql = sql;
        }

        public Object TableName
        {
            set { this._tableName = value; }
            get { return this._tableName; }
        }

        public Hashtable GetReferResult(Object cCode)
        {
            String sql = null;
            if (Sql == null)
            {
                sql = "select * from " + _tableName + " where cCode = '{0}' or cName = '{0}'";
            }
            else
            {
                sql = Sql;
            }

            ArrayList result = DbSvr.GetDbService().GetListResult(sql,new Object[]{cCode});
            if (result.Count <= 0)
                return null;
            return (Hashtable)result[0];

        }

        public DataTable QueryDataSource()
        {
            String sql = "select cCode,cName from "+_tableName;
            return DbSvr.GetDbService().GetDataTable(sql);
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
