
namespace TS.PRS.MemberMan.Dao
{
    partial class MembersSalaryDao
    {
        private static string MAIN_ALL =
            "select ma.cGUID,ma.cCode,ma.dDate,ma.iMemberNum,ma.iMemberSalarySum,CASE WHEN ma.cAuditor is NULL THEN '未审核' ELSE '已审核' END cAuditStatus,u1.cName cAuditor,dAuditDate,dept.cName cDepartment,u2.cName cCreator,ma.cTimeStamp,ma.cRemark from MEM_MemberSalaryList ma " +
            " left join Sys_User u1 on ma.cAuditor = u1.cCode left join CM_Department dept on ma.cDepartment = dept.cCode left join Sys_User u2 on ma.cCreator = u2.cCode";

        private static string SUB_ALL =
            "select m.cCode,m.cName,m.cCompany,CASE WHEN mem.iSex = 1 THEN '男' ELSE '女' END iSex,md.iAllow,m1.cName cRecommendName  from MEM_MemberSalaryDetail md inner join CM_Member m on md.cMemberCode  = m.cCode inner join CM_Member m1 on m.cRecommendCode = m1.cCode";

        private static string LIST_ALL =
            "select * from MEM_MemberSalaryList ma ";

        private static string GUID_ALL =
            "select cGUID from MEM_MemberSalaryList ";

        private static string MEMBER_SALARY = "select  m.cCode cMemberCode,m.cName cMemberName,0 iMemberSalary from CM_Member m";

       
    }
}
