using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TS.PRS.MemberMan.Connection;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Exceptions;

namespace TS.PRS.MemberMan.Adapter
{
    public class MemberAdapter
    {
        private DbSupprot dbSvr;
        private Adapter adapter;

        public MemberAdapter()
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
        public void  DoAdapter()
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.AddRange(SyncMember());
            commands.AddRange(SyncMemberRecommend());
            try
            {
                dbSvr.UpdateInTransaction(commands);
                DbSvr.GetDbService().Update("Update CM_Member set iState =3 where iState is null or iState = 1");
                DbSvr.GetDbService().Update("Update MEM_MemberRecommend set iState =3 where iState is null or iState = 1");
            }
            catch (Exception e)
            {
                throw new BusinessException("同步失败！");
            }
        }

        /// <summary>
        /// 同步会员
        /// </summary>
        private List<SqlCommand> SyncMember()
        {
            String table = "CM_Member";
            List<SqlCommand> commands = new List<SqlCommand>();
            List<SqlCommand> insertCommand = adapter.SyncInsertCommand(table);
            if(insertCommand!=null)
                commands.AddRange(insertCommand);
            List<SqlCommand> updateCommand = adapter.SyncUpdateCommand(table);
            if (updateCommand != null)
                commands.AddRange(updateCommand); 
            return commands;
        }

        /// <summary>
        /// 同步会员推荐关系
        /// </summary>
        private List<SqlCommand> SyncMemberRecommend()
        {
            String table = "MEM_MemberRecommend";
            List<SqlCommand> commands = new List<SqlCommand>();
            List<SqlCommand> insertCommand = adapter.SyncInsertCommand(table);
            if (insertCommand != null)
                commands.AddRange(insertCommand);
            List<SqlCommand> updateCommand = adapter.SyncUpdateCommand(table);
            if (updateCommand != null)
                commands.AddRange(updateCommand);  
            return commands;
        }
       

         
    }
}
