
namespace TS.ERP.ST.Dao
{
    public partial class StockDao
    {
        private static string SQL_LIST= "select Stock.cGUID,Stock.cCode,CONVERT(varchar(100), Stock.dDate, 23) dDate,CASE WHEN Stock.dAuditDate IS NULL THEN '未审核' ELSE '已审核' END cAuditStatus,aud.cName cAuditor,CONVERT(varchar(100), Stock.dAuditDate, 23) dAuditDate,dept.cName cDepartment,usr.cName cCreator,Stock.cTimeStamp from ST_StockList Stock left join Sys_User aud on Stock.cAuditor = aud.cGUID left join Sys_User usr on Stock.cCreator = usr.cGUID left join CM_Department dept on Stock.cDepartment = dept.cGUID";
    }
}
