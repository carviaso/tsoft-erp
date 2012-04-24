using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using TS.Sys.DBLayer;

namespace TS.PRS.MemberMan.Adapter
{
    public class Adapter
    {
        private DbSupprot _dbs;

        public Adapter()
        {
            
        }

        public Adapter(DbSupprot dbs)
            : this()
        {
            _dbs = dbs;
        }
        /// <summary>
        /// 同步插入会员记录
        /// </summary>
        /// <returns></returns>
        public  List<SqlCommand> SyncInsertCommand(String table)
        {
            String sql = "select * from " + table + " where iState is null";
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            if (result.Count > 0)
            {
                List<SqlCommand> commands = new List<SqlCommand>();
                foreach (Object o in result)
                {
                    Hashtable con = (Hashtable)o;
                    commands.Add(_dbs.GetInsertCommand(table, con));
                }
                 
                return commands;
            }
            else
            {
                return null;        
            }
        }

        /// <summary>
        /// 同步更新会员记录
        /// </summary>
        /// <returns></returns>
        public List<SqlCommand> SyncUpdateCommand(String table)
        {
            String sql = "select * from " + table + " where iState = 1";
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            if (result.Count > 0)
            {
                List<SqlCommand> commands = new List<SqlCommand>();
                foreach (Object o in result)
                {
                    Hashtable con = new Hashtable();
                    con.Add("cGUID", ((Hashtable)o)["cGUID"]);
                    Hashtable values = (Hashtable)o;
                    values.Remove("cGUID");
                    commands.Add(_dbs.GetUpdateCommand(table, values, con));
                }
                
                return commands;
            }
            else
            {
                return null;
            }
        }
    }
}
