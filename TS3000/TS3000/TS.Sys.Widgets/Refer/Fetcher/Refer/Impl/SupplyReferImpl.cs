using System;
using TS.Sys.Platform.Widgets.Refer.Control;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class SupplyReferImpl:BaseRefer
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
                con = " where sup.cCode like '" + con + "%'";
            }
            String sql = "select sup.cCode,sup.cName from CM_Supply sup  " + con;
            return sql;
        }

        public override string getForm()
        {
            return "TS.Sys.Platform.BaseData.Forms.SupplyForm";
        }

        public override DataFetcher GetDataFetcher()
        {
            return new DataFetcher("CM_Supply");
        }
    }
}
