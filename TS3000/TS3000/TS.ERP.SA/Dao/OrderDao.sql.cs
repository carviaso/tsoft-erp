
namespace TS.ERP.SA.Dao
{
    public partial class OrderDao
    {
        private static string SQL_LIST= "select Order.cGUID,Order.cCode,CONVERT(varchar(100), Order.dDate, 23) dDate,CASE WHEN Order.dAuditDate IS NULL THEN '未审核' ELSE '已审核' END cAuditStatus,aud.cName cAuditor,CONVERT(varchar(100), Order.dAuditDate, 23) dAuditDate,dept.cName cDepartment,usr.cName cCreator,Order.cTimeStamp from SA_OrderList Order left join Sys_User aud on Order.cAuditor = aud.cGUID left join Sys_User usr on Order.cCreator = usr.cGUID left join CM_Department dept on Order.cDepartment = dept.cGUID";
    }
}
