using System;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class DepartmentReferImpl:BaseRefer
    {
        public override string getSql(string con)
        {
            if (con != "" && con != null)
            {
                con = " where dept.cCode like '" + con + "%'";
            }
            String sql = "select dept.cCode,dept.cName from CM_Department dept  " + con;
            return sql;
        }
    }
}
