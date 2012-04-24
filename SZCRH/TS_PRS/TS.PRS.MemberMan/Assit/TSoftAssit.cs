using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.DBLayer;
using System.Data.SqlClient;
using System.Collections;

namespace TS.PRS.MemberMan.Assit
{
    public class TSoftAssit
    {
        private static string t_member="CM_Member";
        private static string t_memberAllowDetail = "MEM_MemberAllowDetail";
        private static string t_memberAllowList = "MEM_MemberAllowList";
        private static string t_memberRecommend = "MEM_MemberRecommend";
        public static void ClearAllData()
        {
            DbSvr.GetDbService().Delete(t_member,null);
            DbSvr.GetDbService().Delete(t_memberAllowDetail, null);
            DbSvr.GetDbService().Delete(t_memberAllowList, null);
            DbSvr.GetDbService().Delete(t_memberRecommend, null);
        }

        public static void ClearRabbishData()
        {
            SqlCommand command = new SqlCommand("delete from MEM_MemberRecommend where cMemberCode in (select mr.cMemberCode from MEM_MemberRecommend mr left join CM_Member m on mr.cMemberCode = m.cCode where m.cCode is NULL)");

            DbSvr.GetDbService().ExecuteCommand(command);

            ArrayList result = DbSvr.GetDbService().GetListResult("select m.cCode,m.cRecomMember from CM_Member m inner join MEM_MemberRecommend mr on m.cCode = mr.cMemberCode where m.cRecomMember <> mr.cRecommendCode");
            foreach (Object o in result)
            {
                Hashtable detail = (Hashtable)o;
                Hashtable con = new Hashtable();
                con.Add("cMemberCode", detail["cCode"].ToString());
                Hashtable value = new Hashtable();
                value.Add("cRecommendCode",detail["cRecomMember"].ToString());
                DbSvr.GetDbService().Update(t_memberRecommend, value, con);
            }
        }
    }
}
