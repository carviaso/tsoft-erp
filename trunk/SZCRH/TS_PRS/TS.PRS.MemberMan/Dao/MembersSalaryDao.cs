using System;
using System.Data;
using System.Data.SqlClient;
using TS.PRS.MemberMan.Info;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;
using System.Collections;

namespace TS.PRS.MemberMan.Dao
{
    public partial class MembersSalaryDao:BusinessDao
    {
        private static string MAIN_TABLE = "MEM_MemberSalaryList";
        private static string SUB_TABLE = "MEM_MemberSalaryDetail";

        public MembersSalaryDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }

        public void addMain(MembersSalaryInfo mai)
        {
            AddMain(mai);
        }

        public void addSub(MembersSalaryInfo mai, MembersSalarySubInfo msi)
        {
            AddSub(mai, msi);
        }

        public void AuditMemberSalary(MembersSalaryInfo mai)
        {
            Audit(mai);

        }

        public void UnAuditMemberSalary(MembersSalaryInfo mai)
        {
            UnAudit(mai);
        }

        public SqlCommand GetAddMainCommandMemberSalary(MembersSalaryInfo mai)
        {
            return GetAddMainCommand(mai);
        }

        public SqlCommand GetAddSubCommandMemberSalary(MembersSalaryInfo mai, MembersSalarySubInfo msi)
        {
            return GetAddSubCommand(mai, msi);
        }

        public SqlCommand GetDelMainCommandMemberSalary(MembersSalaryInfo mai)
        {
            return GetDelMainCommand(mai);
        }

        public SqlCommand GetDelSubCommandMemberSalary(MembersSalaryInfo mai)
        {
            return GetDelSubCommand(mai);
        }

        public SqlCommand GetModifyCommandMemberSalary(MembersSalaryInfo mai)
        {
            return GetModifyCommand(mai);
        }

        public int DelMain(object cGUID)
        {
            return DelMain(cGUID);
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable QueryForAll()
        {
            return GetDataTable(null);
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(object con)
        {
            String sql = MAIN_ALL + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }

        /// <summary>
        /// 获取所有可发放津贴用户
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetSalaryMembers(Hashtable con)
        {

            return DbSvr.GetDbService().GetListResult(MEMBER_SALARY, con);
        }
    }
}
