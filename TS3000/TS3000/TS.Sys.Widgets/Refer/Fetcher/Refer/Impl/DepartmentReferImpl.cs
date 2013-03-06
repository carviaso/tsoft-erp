using System;
using TS.Sys.Platform.Widgets.Refer.Control;

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

        public override String getForm()
        {
            return "TS.Sys.Platform.BaseData.Forms.DepartmentForm";
        }

        public override DataFetcher GetDataFetcher()
        {
            return new DataFetcher("CM_Department");
        }
    }
}
