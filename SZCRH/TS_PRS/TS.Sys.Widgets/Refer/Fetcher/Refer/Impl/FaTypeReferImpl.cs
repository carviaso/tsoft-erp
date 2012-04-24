using System;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class FaTypeReferImpl:BaseRefer
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
                con = " where acc.cCode like '" + con + "%'";
            }
            String sql = "select se.cCode,se.cName from CM_FaType se  " + con;
            return sql;
        }
    }
}
