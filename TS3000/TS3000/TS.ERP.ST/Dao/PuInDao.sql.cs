
namespace TS.ERP.ST.Dao
{
    public partial class PuInDao
    {
        private static string SQL_LIST= "select PuIn.cGUID,PuIn.cCode,CONVERT(varchar(100), PuIn.dDate, 23) dDate,CASE WHEN PuIn.dAuditDate IS NULL THEN '未审核' ELSE '已审核' END cAuditStatus,aud.cName cAuditor,CONVERT(varchar(100), PuIn.dAuditDate, 23) dAuditDate,dept.cName cDepartment,usr.cName cCreator,PuIn.cTimeStamp from ST_PuInList PuIn left join Sys_User aud on PuIn.cAuditor = aud.cGUID left join Sys_User usr on PuIn.cCreator = usr.cGUID left join CM_Department dept on PuIn.cDepartment = dept.cGUID";
    }
}
