﻿using System;
using TS.Sys.Platform.Widgets.Refer.Control;

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

        public override String getForm()
        {
            return "TS.Sys.Platform.BaseData.Forms.FaTypeForm";
        }

        public override DataFetcher GetDataFetcher()
        {
            return new DataFetcher("CM_FaType");
        }
    }
}
