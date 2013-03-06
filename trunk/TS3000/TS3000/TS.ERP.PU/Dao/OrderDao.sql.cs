
namespace TS.ERP.PU.Dao
{
    public partial class OrderDao
    {
        private static string SQL_LIST = "select ord.cGUID,ord.cCode,CONVERT(varchar(100), ord.dDate, 23) dDate,CASE WHEN ord.dAuditDate IS NULL THEN '未审核' ELSE '已审核' END cAuditStatus,aud.cName cAuditor,CONVERT(varchar(100), ord.dAuditDate, 23) dAuditDate,dept.cName cDepartment,usr.cName cCreator,ord.cTimeStamp from PU_OrderList ord left join Sys_User aud on ord.cAuditor = aud.cGUID left join Sys_User usr on ord.cCreator = usr.cGUID left join CM_Department dept on ord.cDepartment = dept.cGUID";
    }
}
