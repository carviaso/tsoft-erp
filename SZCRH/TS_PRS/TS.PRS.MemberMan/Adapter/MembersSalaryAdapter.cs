using System;
using System.Collections.Generic;
using TS.Sys.DBLayer;
using TS.PRS.MemberMan.Connection;
using TS.PRS.MemberMan.Info;
using System.Data.SqlClient;
using System.Collections;

namespace TS.PRS.MemberMan.Adapter
{
    public class MembersSalaryAdapter
    {
        private DbSupprot dbSvr;
        private Adapter adapter;
        private string _mainTable="MEM_MemberSalaryList";
        private string _subTable = "MEM_MemberSalaryDetail";
        public MembersSalaryAdapter()
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
        public void  DoAuditAdapter(MembersSalaryInfo memSalaryInfo)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(InsertMainCommand(memSalaryInfo));
            commands.AddRange(InsertDetailCommand(memSalaryInfo));
            dbSvr.UpdateInTransaction(commands);
        }

        private SqlCommand InsertMainCommand(MembersSalaryInfo memSalaryInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", memSalaryInfo.cGUID);
            ArrayList memAllow = DbSvr.GetDbService().GetListResult("select * from " + _mainTable + " where cGUID = @cGUID", con);
            Hashtable result = (Hashtable)memAllow[0];
            return dbSvr.GetInsertCommand(_mainTable, result);
        }
        private List<SqlCommand> InsertDetailCommand(MembersSalaryInfo memSalaryInfo)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            Hashtable con = new Hashtable();
            con.Add("cHeadGUID", memSalaryInfo.cGUID);
            ArrayList memAllow = DbSvr.GetDbService().GetListResult("select * from " + _subTable + " where cHeadGUID = @cHeadGUID", con);
            foreach (Object o in memAllow)
            {
                Hashtable result = (Hashtable)o;
                commands.Add(dbSvr.GetInsertCommand(_subTable, result));
            }
            return commands;
        }

        public void  DoUnAuditAdapter(MembersSalaryInfo memSalaryInfo)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(DeleteMainCommand(memSalaryInfo));
            commands.Add(DeleteSubCommand(memSalaryInfo));
            dbSvr.UpdateInTransaction(commands);
        }

        private SqlCommand DeleteMainCommand(MembersSalaryInfo memSalaryInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID",memSalaryInfo.cGUID);
            return dbSvr.GetDeleteCommand(_mainTable, con);
        }

        private SqlCommand DeleteSubCommand(MembersSalaryInfo memSalaryInfo)
        {
            Hashtable con = new Hashtable();
            con.Add("cHeadGUID",memSalaryInfo.cGUID);
            return dbSvr.GetDeleteCommand(_subTable, con);
        }
    }
}
