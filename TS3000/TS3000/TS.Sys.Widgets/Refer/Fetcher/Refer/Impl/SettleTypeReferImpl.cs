﻿using System;
using TS.Sys.Platform.Widgets.Refer.Control;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class SettleTypeReferImpl:BaseRefer
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
            String sql = "select st.cCode,st.cName from CM_SettleType st  " + con;
            return sql;
        }

        public override string getForm()
        {
            return "TS.Sys.Platform.BaseData.Forms.SettleTypeForm";
        }

        public override DataFetcher GetDataFetcher()
        {
            return new DataFetcher("CM_SettleType");
        }
    }
}
