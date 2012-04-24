using TS.PRS.MemberMan.Connection;
using TS.Sys.DBLayer;
using System.Data.SqlClient;
using TS.PRS.MemberMan.Info;
using System.Collections;
using System;
using System.Collections.Generic;

namespace TS.PRS.MemberMan.Adapter
{
    public class MemberAllowAdapter
    {
        private DbSupprot dbSvr;
        private Adapter adapter;
        private string _mainTable="MEM_MemberAllowList";
        private string _subTable = "MEM_MemberAllowDetail";
        public MemberAllowAdapter()
        {
            IDBConfig dbCon = new WebConn();
            dbSvr = new DbSupprot(dbCon);
            adapter = new Adapter(dbSvr);

        }

        /// <summary>
        /// 同步会员信息
        /// 1、同步会员信息（插入、更新）
        /// 2、同步会员推荐信息（插入、更新）
        /// 3、更新表中的更新状态字段
        /// </summary>
        public void  DoAuditAdapter(MembersAllowInfo memAllowInfo)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(InsertMainCommand(memAllowInfo));
            commands.AddRange(InsertDetailCommand(memAllowInfo));
            dbSvr.UpdateInTransaction(commands);
        }

        private SqlCommand InsertMainCommand(MembersAllowInfo memAllowInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", memAllowInfo.cGUID);
            ArrayList memAllow = DbSvr.GetDbService().GetListResult("select * from " + _mainTable + " where cGUID = @cGUID", con);
            Hashtable result = (Hashtable)memAllow[0];
            return dbSvr.GetInsertCommand(_mainTable, result);
        }
        private List<SqlCommand> InsertDetailCommand(MembersAllowInfo memAllowInfo)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            Hashtable con = new Hashtable();
            con.Add("cHeadGUID", memAllowInfo.cGUID);
            ArrayList memAllow = DbSvr.GetDbService().GetListResult("select * from " + _subTable + " where cHeadGUID = @cHeadGUID", con);
            foreach (Object o in memAllow)
            {
                Hashtable result = (Hashtable)o;
                commands.Add(dbSvr.GetInsertCommand(_subTable, result));
            }
            return commands;
        }

        public void  DoUnAuditAdapter(MembersAllowInfo memAllowInfo)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(DeleteMainCommand(memAllowInfo));
            commands.Add(DeleteSubCommand(memAllowInfo));
            dbSvr.UpdateInTransaction(commands);
        }

        private SqlCommand DeleteMainCommand(MembersAllowInfo memAllowInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID",memAllowInfo.cGUID);
            return dbSvr.GetDeleteCommand(_mainTable, con);
        }

        private SqlCommand DeleteSubCommand(MembersAllowInfo memAllowInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cHeadGUID",memAllowInfo.cGUID);
            return dbSvr.GetDeleteCommand(_subTable, con);
        }
    }
}
