using System.Data.SqlClient;
using TS.ERP.FA.Info;
using TS.Sys.Platform.Business.Dao;
using System.Data;
using TS.Sys.Platform.Business.Util;
using System;
using TS.Sys.DBLayer;

namespace TS.ERP.FA.Dao
{
    public partial class RevenDao : BusinessDao
    {
        private static string MAIN_TABLE = "FA_RevenList";
        private static string SUB_TABLE = "FA_RevenDetail";
        

        public RevenDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }

        public void addMain(RevenInfo mai)
        {
            AddMain(mai);
        }

        public void addSub(RevenInfo mai, RevenSubInfo msi)
        {
            AddSub(mai, msi);
        }

        public void AuditMemberAllow(RevenInfo mai)
        {
            Audit(mai);
            
        }

        public void UnAuditMemberAllow(RevenInfo mai)
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
       
        public SqlCommand GetAddMainCommandMemberAllow(RevenInfo mai)
        {
            return GetAddMainCommand(mai);
        }

        public SqlCommand GetAddSubCommandMemberAllow(RevenInfo mai, RevenSubInfo msi)
        {
            return GetAddSubCommand(mai, msi);
        }

        public SqlCommand GetDelMainCommandMemberAllow(RevenInfo mai)
        {
            return GetDelMainCommand(mai);
        }

        public SqlCommand GetDelSubCommandMemberAllow(RevenInfo mai)
        {
            return GetDelSubCommand(mai);
        }

        public SqlCommand GetModifyCommandMemberAllow(RevenInfo mai)
        {
            return GetModifyCommand(mai);
        }
        
        public int DelMain(object cGUID)
        {
            return DelMain(cGUID);
        }
    }
}
