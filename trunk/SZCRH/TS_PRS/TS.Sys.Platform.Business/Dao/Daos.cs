using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using TS.Sys.DBLayer;

namespace TS.Sys.Platform.Business.Dao
{
    public class Daos
    {
        private string _tableName;

        public String TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        /// <summary>
        /// 根据cGUID查询
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public ArrayList GetMainResult(object cGUID)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", cGUID);
            return DbSvr.GetDbService().GetExitsResult(TableName, con);
        }
    }
}
