using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using TS.PRS.MemberMan.Info;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Dao;

namespace TS.PRS.MemberMan.Dao
{
    public partial class MembersAllowDao:BusinessDao
    {
        private static string MAIN_TABLE = "MEM_MemberAllowList";
        private static string SUB_TABLE = "MEM_MemberAllowDetail";

        public MembersAllowDao()
        {
            base.TableName = MAIN_TABLE;
            base.SubTableName = SUB_TABLE;
        }

        public void addMain(MembersAllowInfo mai)
        {
            AddMain(mai);
        }

        public void addSub(MembersAllowInfo mai, MembersAllowSubInfo msi)
        {
            AddSub(mai, msi);
        }

        public void AuditMemberAllow(MembersAllowInfo mai)
        {
            Audit(mai);
            
        }

        public void UnAuditMemberAllow(MembersAllowInfo mai)
        {
            UnAudit(mai);
        }
       
        public SqlCommand GetAddMainCommandMemberAllow(MembersAllowInfo mai)
        {
            return GetAddMainCommand(mai);
        }

        public SqlCommand GetAddSubCommandMemberAllow(MembersAllowInfo mai, MembersAllowSubInfo msi)
        {
            return GetAddSubCommand(mai, msi);
        }

        public SqlCommand GetDelMainCommandMemberAllow(MembersAllowInfo mai)
        {
            return GetDelMainCommand(mai);
        }

        public SqlCommand GetDelSubCommandMemberAllow(MembersAllowInfo mai)
        {
            return GetDelSubCommand(mai);
        }

        public SqlCommand GetModifyCommandMemberAllow(MembersAllowInfo mai)
        {
            return GetModifyCommand(mai);
        }
        
        public int DelMain(object cGUID)
        {
            return DelMain(cGUID);
        }

        /// <summary>
        /// 获取所有可发放津贴用户
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetAllowMembers(Hashtable con)
        {

            return DbSvr.GetDbService().GetListResult(MEMBER_ALLOW,con);
        }
         

        /// <summary>
        /// 根据cGUID查询
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public ArrayList GetResultByGUID(object cGUID)
        {
            if (cGUID != null)
            {
                cGUID = " where ma.cGUID = '" + cGUID+"'";
            }
            return GetResultList(cGUID);
        }

        public ArrayList GetForAllGUID()
        {
            ArrayList result = DbSvr.GetDbService().GetListResult(GUID_ALL);
            return result;
        }

        /// <summary>
        /// 根据条件查询结果集 
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetValidatation(Hashtable con)
        {
            ArrayList result = DbSvr.GetDbService().GetExitsResult(MAIN_TABLE, con);
            return result;
        }

        public ArrayList GetForAll()
        {
            return GetResultList(null);
        }

        public ArrayList GetSubResult(object cGUID)
        {
            if (cGUID != null)
            {
                cGUID = " where md.cHeadGUID = '" + cGUID + "'";
            }
            return GetSubResultList(cGUID);
        }
        public ArrayList GetSubResultList(object con)
        {
            String sql = SUB_ALL + con;
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            return result;
        }
        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetResultList(object con)
        {
            String sql = LIST_ALL + con;
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            return result;
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable QueryForAll()
        {
            return GetDataTable(null);
        }

        public DataTable QuerySubByGUID(object cGUID)
        {
            if (cGUID != null)
            {
                cGUID = " where md.cHeadGUID = '" + cGUID + "'";
            }
            return GetSubDataTable(cGUID);
        }

        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        public DataTable GetSubDataTable(object con)
        {
            String sql = SUB_ALL + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
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
        

    }
}
