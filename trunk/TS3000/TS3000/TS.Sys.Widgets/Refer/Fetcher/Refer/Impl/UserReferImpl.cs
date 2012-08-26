using System;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class UserReferImpl:BaseRefer
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
                con = " where user.cCode like '" + con + "%'";
            }
            String sql = "select user.cCode,user.cName from CM_User user  " + con;
            return sql;
        }
    }
}
