using System.Data.SqlClient;
using TS.ERP.FA.Info;
using TS.Sys.Platform.Business.Dao;
using System.Data;
using TS.Sys.Platform.Business.Util;
using System;
using TS.Sys.DBLayer;

namespace TS.ERP.FA.Dao
{
    public partial class CostDao : BusinessDao
    {
        private static string MAIN_TABLE = "FA_CostList";
        private static string SUB_TABLE = "FA_CostDetail";
        

        public CostDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }

        public void addMain(CostInfo mai)
        {
            AddMain(mai);
        }

        public void addSub(CostInfo mai, CostSubInfo msi)
        {
            AddSub(mai, msi);
        }

        public void AuditMemberAllow(CostInfo mai)
        {
            Audit(mai);
            
        }

        public void UnAuditMemberAllow(CostInfo mai)
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
       
        public SqlCommand GetAddMainCommandMemberAllow(CostInfo mai)
        {
            return GetAddMainCommand(mai);
        }

        public SqlCommand GetAddSubCommandMemberAllow(CostInfo mai, CostSubInfo msi)
        {
            return GetAddSubCommand(mai, msi);
        }

        public SqlCommand GetDelMainCommandMemberAllow(CostInfo mai)
        {
            return GetDelMainCommand(mai);
        }

        public SqlCommand GetDelSubCommandMemberAllow(CostInfo mai)
        {
            return GetDelSubCommand(mai);
        }

        public SqlCommand GetModifyCommandMemberAllow(CostInfo mai)
        {
            return GetModifyCommand(mai);
        }
        
        public int DelMain(object cGUID)
        {
            return DelMain(cGUID);
        }
    }
}
