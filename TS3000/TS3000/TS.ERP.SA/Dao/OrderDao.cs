using System;
using System.Data;
using System.Data.SqlClient;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Platform.Business.Util;
using TS.ERP.SA.Info;

namespace TS.ERP.SA.Dao
{
    public partial class OrderDao : BusinessDao
    {
        private static string MAIN_TABLE = "SA_OrderList";
        private static string SUB_TABLE = "SA_OrderDetail";
        

        public OrderDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }

        public void addMain(OrderInfo mai)
        {
            AddMain(mai);
        }

        public void addSub(OrderInfo mai, OrderSubInfo msi)
        {
            AddSub(mai, msi);
        }

        public void AuditMemberAllow(OrderInfo mai)
        {
            Audit(mai);
            
        }

        public void UnAuditMemberAllow(OrderInfo mai)
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

        /// <summary>
        /// 采购订单反审核命令
        /// </summary>
        /// <param name="mai"></param>
        /// <returns></returns>
        public SqlCommand GetOrderUnAuditCommand(OrderInfo mai)
        {
            return GetUnAuditCommand(mai);
        }

        /// <summary>
        /// 采购订单审核命令
        /// </summary>
        /// <param name="mai"></param>
        /// <returns></returns>
        public SqlCommand GetOrderAuditCommand(OrderInfo mai)
        {
            return GetAuditCommand(mai);
        }

        public SqlCommand GetAddMainCommandMemberAllow(OrderInfo mai)
        {
            return GetAddMainCommand(mai);
        }

        public SqlCommand GetAddSubCommandMemberAllow(OrderInfo mai, OrderSubInfo msi)
        {
            return GetAddSubCommand(mai, msi);
        }

        public SqlCommand GetDelMainCommandMemberAllow(OrderInfo mai)
        {
            return GetDelMainCommand(mai);
        }

        public SqlCommand GetDelSubCommandMemberAllow(OrderInfo mai)
        {
            return GetDelSubCommand(mai);
        }

        public SqlCommand GetModifyCommandMemberAllow(OrderInfo mai)
        {
            return GetModifyCommand(mai);
        }
        
        public int DelMain(object cGUID)
        {
            return DelMain(cGUID);
        }
    }
}
