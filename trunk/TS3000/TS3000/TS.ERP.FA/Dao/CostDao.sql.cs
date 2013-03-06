using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TS.ERP.FA.Dao
{
    public partial class CostDao
    {
        private static string SQL_LIST= "select cost.cGUID,cost.cCode,CONVERT(varchar(100), cost.dDate, 23) dDate,CASE WHEN cost.dAuditDate IS NULL THEN '未审核' ELSE '已审核' END cAuditStatus,aud.cName cAuditor,CONVERT(varchar(100), cost.dAuditDate, 23) dAuditDate,dept.cName cDepartment,usr.cName cCreator,cost.cTimeStamp from FA_CostList cost left join Sys_User aud on cost.cAuditor = aud.cGUID left join Sys_User usr on cost.cCreator = usr.cGUID left join CM_Department dept on cost.cDepartment = dept.cGUID";
    }
}
