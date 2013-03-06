using System;
using System.Data;
using System.Data.SqlClient;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Platform.Business.Util;
using TS.ERP.ST.Info;

namespace TS.ERP.ST.Dao
{
    public partial class StockDao : BusinessDao
    {
        private static string MAIN_TABLE = "ST_StockList";
        private static string SUB_TABLE = "ST_StockDetail";
        

        public StockDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }
         

        public DataTable GetDataByCondition(Condition con)
        {
            String conStr = "";// BusinessControl.SetParamByCondition(con);
            String sql = SQL_LIST + conStr;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }
        
    }
}
