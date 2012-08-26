using System;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class EmployeeReferImpl:BaseRefer
    {
        /// <summary>
        /// 获取取数SQL
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public override String getSql(String con)
        {
            if (con != "" && con != null)
            {
                con = " where emp.cCode like '" + con + "%'";
            }
            String sql = "select emp.cCode,emp.cName from CM_Employee emp  " + con;
            return sql;
        }
    }
}
