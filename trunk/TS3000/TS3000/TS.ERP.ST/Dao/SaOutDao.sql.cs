
namespace TS.ERP.ST.Dao
{
    public partial class SaOutDao
    {
        private static string SQL_LIST= "select SaOut.cGUID,SaOut.cCode,CONVERT(varchar(100), SaOut.dDate, 23) dDate,CASE WHEN SaOut.dAuditDate IS NULL THEN '未审核' ELSE '已审核' END cAuditStatus,aud.cName cAuditor,CONVERT(varchar(100), SaOut.dAuditDate, 23) dAuditDate,dept.cName cDepartment,usr.cName cCreator,SaOut.cTimeStamp from ST_SaOutList SaOut left join Sys_User aud on SaOut.cAuditor = aud.cGUID left join Sys_User usr on SaOut.cCreator = usr.cGUID left join CM_Department dept on SaOut.cDepartment = dept.cGUID";
    }
}
