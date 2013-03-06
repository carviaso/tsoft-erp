using System;
using System.Data;
using System.Data.SqlClient;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Platform.Business.Util;
using TS.ERP.ST.Info;

namespace TS.ERP.ST.Dao
{
    public partial class PuInDao : BusinessDao
    {
        private static string MAIN_TABLE = "ST_PuInList";
        private static string SUB_TABLE = "ST_PuInDetail";
        

        public PuInDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }

        public void addMain(PuInInfo mai)
        {
            AddMain(mai);
        }

        public void addSub(PuInInfo mai, PuInSubInfo msi)
        {
            AddSub(mai, msi);
        }

        public void PuInAudit(PuInInfo mai)
        {
            Audit(mai);
            
        }

        public void PuInUnAudit(PuInInfo mai)
        {
            UnAudit(mai);
        }

        public DataTable GetDataByCondition(Condition con)
        {
            String conStr = "";// BusinessControl.SetParamByCondition(con);
            String sql = SQL_LIST + conStr;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }
       
        public SqlCommand GetPuInAddMainCommand(PuInInfo mai)
        {
            return GetAddMainCommand(mai);
        }

        public SqlCommand GetPuInAddSubCommand(PuInInfo mai, PuInSubInfo msi)
        {
            return GetAddSubCommand(mai, msi);
        }

        public SqlCommand GetPuInDelMainCommand(PuInInfo mai)
        {
            return GetDelMainCommand(mai);
        }

        public SqlCommand GetPuInDelSubCommand(PuInInfo mai)
        {
            return GetDelSubCommand(mai);
        }

        public SqlCommand GetPuInModifyCommand(PuInInfo mai)
        {
            return GetModifyCommand(mai);
        }
        
        public int DelMain(object cGUID)
        {
            return DelMain(cGUID);
        }
    }
}
