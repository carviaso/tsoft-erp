using System;
using System.Data;
using System.Data.SqlClient;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Platform.Business.Util;
using TS.ERP.ST.Info;

namespace TS.ERP.ST.Dao
{
    public partial class SaOutDao : BusinessDao
    {
        private static string MAIN_TABLE = "ST_SaOutList";
        private static string SUB_TABLE = "ST_SaOutDetail";
        

        public SaOutDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }

        public void addMain(SaOutInfo mai)
        {
            AddMain(mai);
        }

        public void addSub(SaOutInfo mai, SaOutSubInfo msi)
        {
            AddSub(mai, msi);
        }

        public void SaOutAudit(SaOutInfo mai)
        {
            Audit(mai);
            
        }

        public void SaOutUnAudit(SaOutInfo mai)
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
       
        public SqlCommand GetSaOutAddMainCommand(SaOutInfo mai)
        {
            return GetAddMainCommand(mai);
        }

        public SqlCommand GetSaOutAddSubCommand(SaOutInfo mai, SaOutSubInfo msi)
        {
            return GetAddSubCommand(mai, msi);
        }

        public SqlCommand GetSaOutDelMainCommand(SaOutInfo mai)
        {
            return GetDelMainCommand(mai);
        }

        public SqlCommand GetSaOutDelSubCommand(SaOutInfo mai)
        {
            return GetDelSubCommand(mai);
        }

        public SqlCommand GetSaOutModifyCommand(SaOutInfo mai)
        {
            return GetModifyCommand(mai);
        }
        
        public int DelMain(object cGUID)
        {
            return DelMain(cGUID);
        }
    }
}
