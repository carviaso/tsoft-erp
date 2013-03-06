using System;
using TS.Sys.Platform.Widgets.Refer.Control;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class BankReferImpl:BaseRefer 
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
                con = " where rg.cCode like '" + con + "%'";
            }
            String sql = "select rg.cCode,rg.cName from CM_Bank rg  " + con;
            return sql;
        }

        public override String getForm()
        {
            return "TS.Sys.Platform.BaseData.Forms.BankForm";
        }

        public override DataFetcher GetDataFetcher()
        {
            return new DataFetcher("CM_Bank");
        }
    }
}
