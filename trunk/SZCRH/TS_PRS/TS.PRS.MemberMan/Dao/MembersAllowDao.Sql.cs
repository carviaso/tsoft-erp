
namespace TS.PRS.MemberMan.Dao
{
    partial class MembersAllowDao
    {
        private static string MAIN_ALL =
            "select ma.cGUID,ma.cCode,ma.dDate,ma.iMemberNum,ma.iAllowSum,CASE WHEN ma.cAuditor is NULL THEN '未审核' ELSE '已审核' END cAuditStatus,u1.cName cAuditor,dAuditDate,dept.cName cDepartment,u2.cName cCreator,ma.cTimeStamp,ma.cRemark from MEM_MemberAllowList ma " +
            " left join Sys_User u1 on ma.cAuditor = u1.cCode left join CM_Department dept on ma.cDepartment = dept.cCode left join Sys_User u2 on ma.cCreator = u2.cCode";

        private static string SUB_ALL = 
            "select m.cCode,m.cName,m.cCompany,CASE WHEN mem.iSex = 1 THEN '男' ELSE '女' END iSex,md.iAllow,m1.cName cRecommendName  from MEM_MemberAllowDetail md inner join CM_Member m on md.cMemberCode  = m.cCode inner join CM_Member m1 on m.cRecommendCode = m1.cCode";
        
        private static string LIST_ALL = 
            "select * from MEM_MemberAllowList ma ";
        
        private static string GUID_ALL = 
            "select cGUID from MEM_MemberAllowList ";

        private static string MEMBER_ALLOW =
            "select m.cCode cMemberCode,m.cName cMemberName, ISNULL(mrc.recNum,0) iRecNum  From MEM_MemberRecommend mr INNER JOIN CM_Member m ON mr.cREcommendCode = m.cCOde LEFT JOIN" +
            "(select count(cRecommendCode) recNum,cRecommendCode from MEM_MemberRecommend where iYear<=@iYear and iMonth <= @iMonth group by cRecommendCode) mrc ON mr.cRecommendCode = mrc.cRecommendCode Group By mr.cRecommendCode,mrc.recNum,m.cCode,m.cName";

    }
}
