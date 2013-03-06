using System;
using TS.Sys.Platform.Widgets.Refer.Control;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class AccountReferImpl : BaseRefer
    {        
        /// <summary>
        /// 获取取数SQL
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public override String getSql(String con)
        {
            if (Col != null)
               // Col.GetDataControl.DataFetcher = new DataFetcher("CM_AccountDetail");
           
            if (con != "" && con !=null)
            {
                con = " where acc.cCode like '" + con + "%'";
            }
            String sql = "select acc.cCode,acc.cName from CM_AccountDetail acc  " + con;
            return sql;
        }

        public override string getForm()
        {
            return "TS.Sys.Platform.BaseData.Forms.AccountForm";
        }

        public override DataFetcher GetDataFetcher()
        {
            return new DataFetcher("CM_AccountDetail");
        }
    }
}
