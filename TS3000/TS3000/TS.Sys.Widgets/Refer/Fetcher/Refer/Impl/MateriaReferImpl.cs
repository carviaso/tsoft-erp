using System;
using TS.Sys.Platform.Widgets.Refer.Control;

namespace TS.Sys.Platform.Widgets.Refer.Fetcher.Refer.Impl
{
    public class MateriaReferImpl:BaseRefer
    {
        private String _sql ="select ma.cCode,ma.cName,u.cName as cUnit,ma.iOutPrice,ma.iInPrice,100 iDiscount from CM_Materia ma  inner join CM_Unit u on ma.cUnit = u.cCode ";
                
        /// <summary>
        /// 获取取数SQL
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public override String getSql(String con)
        {
             
            if (con != "" && con != null)
            {
                con = " where ma.cCode like '" + con + "%'";
            }
            String sql = _sql + con;
            return sql;
        }

        public override string getForm()
        {
            return "TS.Sys.Platform.BaseData.Forms.MateriaForm";
        }

        public override DataFetcher GetDataFetcher()
        {
            String sql = _sql + " where ma.cCode = '{0}' or ma.cName = '{0}'";
            return new DataFetcher("CM_Materia", sql);
        }
    }
}
