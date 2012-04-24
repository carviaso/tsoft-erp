using System;
using System.Collections;
using System.Data; 
using TS.Sys.Platform.Business.Dao;
using TS.Sys.DBLayer;
using TS.PRS.MemberMan.Info;
using System.Data.SqlClient;

namespace TS.PRS.MemberMan.Dao
{
    internal class MembersDao:BaseDao
    {
        private static string SQL_ALL = "select * from CM_Member mem  ";
        private static string SQL_LIST = "select mem.cCode,mem.cName,mem.cId,CONVERT(varchar(100), mem.dRecommendDate, 23) dRecommendDate,cust.cName cCompany,CASE WHEN recom.cName IS NULL THEN '无' ELSE recom.cName END cRecomm,mem.cGUID,mem.cTimeStamp,CASE WHEN mem.iForbidden = 1 THEN '离职' ELSE '在职' END as Status from CM_Member mem left join CM_Member recom on mem.cRecomMember = recom.cCode left join CM_Customer cust on mem.cCompany = cust.cCode";
        private static string SQL_MAXNUM = "select top 1 cCode from CM_Member order by cCode desc ";
        private static string TABLE = "CM_Member";
        private static string TABLE_RECOMMEND = "MEM_MemberRecommend";

        internal MembersDao()
        {
            base.TableName = TABLE;
        }

        internal SqlCommand GetAddMemberCommand(MembersInfo meminfo)
        {
            return GetAddCommand(meminfo);
        }

        internal SqlCommand GetModifyMemberCommand(MembersInfo meminfo)
        {
            return GetModifyCommand(meminfo);
        }

        internal void AddMember(MembersInfo meminfo)
        {
             Add(meminfo);
        }

        /// <summary>
        /// 修改更新状态
        /// 当该记录被同步过，则更新状态：1
        /// 
        /// </summary>
        /// <param name="meminfo"></param>
        /// <returns></returns>
        internal SqlCommand GetModifyStateCommand(MembersInfo meminfo)
        {
            Hashtable values = new Hashtable();
            values.Add("iState", 1);
            Hashtable con = new Hashtable();
            con.Add("cGUID", meminfo.cGUID);
            ArrayList result = DbSvr.GetDbService().GetListResult("select 1 from " + TABLE + " where cGUID = @cGUID and iState is not null", con);
            if (result.Count > 0)
            {
                return DbSvr.GetDbService().GetUpdateCommand(TABLE, values, con);
            }
            else
            {
                return null;
            }
        }

        internal void ModifyMember(MembersInfo meminfo)
        {
            Modify(meminfo);
            
        }
         
        internal SqlCommand GetDelMemberCommand(MembersInfo meminfo)
        {
            return GetDelCommand(meminfo);
        }

        internal SqlCommand GetDelRecommCommand(MembersInfo meminfo)
        {
          
            Hashtable con = new Hashtable();
            con.Add("cMemberCode", meminfo.cCode);
            return  DbSvr.GetDbService().GetDeleteCommand(TABLE_RECOMMEND,con);
            
        }

        internal void ForbiddenMember(MembersInfo meminfo)
        {
             Forbidden(meminfo);
        }

        internal void ValueableMember(MembersInfo meminfo)
        {
             Valueable(meminfo);
        }

        internal SqlCommand AddRecommend(MembersInfo meminfo)
        {
            Hashtable con = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            con.Add("cGUID", cGUID);
            con.Add("cMemberCode",meminfo.cCode);
            con.Add("cRecommendCode",meminfo.cRecomMember);
            DateTime date = (DateTime)meminfo.dRecommendDate;
            con.Add("iYear",date.Year);
            con.Add("iMonth",date.Month);
            return DbSvr.GetDbService().GetInsertCommand(TABLE_RECOMMEND, con);
        }

        /// <summary>
        /// 修改推荐人
        /// </summary>
        /// <param name="meminfo"></param>
        /// <returns></returns>
        internal SqlCommand ModifyRecommend(MembersInfo meminfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cMemberCode", meminfo.cCode);
            Hashtable values = new Hashtable();
            values.Add("cRecommendCode", meminfo.cRecomMember);
            return DbSvr.GetDbService().GetUpdateCommand(TABLE_RECOMMEND, values,con);
        }

        /// <summary>
        /// 更新推荐更新字段
        /// </summary>
        /// <param name="meminfo"></param>
        /// <returns></returns>
        internal SqlCommand ModifyRecommendState(MembersInfo meminfo)
        {
            Hashtable values = new Hashtable();
            values.Add("iState", 1);
            Hashtable con = new Hashtable();
            con.Add("cMemberCode", meminfo.cCode);
            ArrayList result = DbSvr.GetDbService().GetListResult("select 1 from " + TABLE_RECOMMEND + " where cMemberCode = @cMemberCode and iState is not null", con);
            if (result.Count > 0)
            {
                return DbSvr.GetDbService().GetUpdateCommand(TABLE_RECOMMEND, values, con);
            }
            else
            {
                return null;
            }
        }
    

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        internal ArrayList GetResultList(object con)
        {
            String sql = SQL_ALL + con;
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            return result;
        }

        internal ArrayList GetResultById(MembersInfo memInfo)
        {
            Object con = " where mem.cId ='" + memInfo.cId + "'";

            if (memInfo.cGUID != null)
            {
                con += " and mem.cGUID!='" + memInfo.cGUID + "'";
            }
            return GetResultList(con);
        }
     
        /// <summary>
        /// 查询所有记录
        /// </summary>
        /// <returns></returns>
        internal DataTable GetDataTable(object custCode)
        {
            Object con = "";
            if (custCode != null)
            {
                con = " where mem.cCompany = '" + custCode + "'";
            }
            String sql = SQL_LIST + con;
            DataTable result = DbSvr.GetDbService().GetDataTable(sql);
            return result;
        }

        internal ArrayList GetMaxCode()
        {
            String sql = SQL_MAXNUM;
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            return result;
        }
    }
}
