using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.SysInfo.Dao;
using TS.Sys.Platform.SysInfo.Info;

namespace TS.Sys.Platform.SysInfo.Service
{
    public class RoleService : AbstractBaseService
    {
        private RoleDao roleDao;

        public RoleService()
        {
            roleDao = new RoleDao();
            base.Daos = roleDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            RoleInfo roleInfo = (RoleInfo)baseInfo;
            roleDao.AddRole(roleInfo);
        }

        public override void Modify(BaseInfo baseInfo)
        {
            RoleInfo roleInfo = (RoleInfo)baseInfo;
            roleDao.ModifyRole(roleInfo);
        }

        /// <summary>
        /// 删除角色
        /// 1、删除角色基本信息
        /// 2、删除角色模块权限
        /// 3、删除角色按钮权限
        /// </summary>
        /// <param name="baseInfo"></param>
        public override void Delete(BaseInfo baseInfo)
        {
            RoleInfo roleInfo = (RoleInfo)baseInfo;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(roleDao.DeleteRole(roleInfo));
            commands.Add(roleDao.DelSecu(roleInfo));
            commands.Add(roleDao.DelBtnSecu(roleInfo));
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            RoleInfo roleInfo = (RoleInfo)baseInfo;
            roleDao.ForbiddenRole(roleInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            RoleInfo roleInfo = (RoleInfo)baseInfo;
            roleDao.ValueableRole(roleInfo);
        }

        public DataTable GetDataTable(Object con)
        {
            return roleDao.GetDataTable(con);
        }

        /// <summary>
        /// 添加模块权限
        /// 1、删除该角色的所有模块权限
        /// 2、添加该角色的模块权限
        /// </summary>
        /// <param name="roleInfo"></param>
        public void AddSecu(RoleInfo roleInfo)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(roleDao.DelSecu(roleInfo));
            foreach (object o in roleInfo.Secu)
            {
                Hashtable con = (Hashtable)o;
                commands.Add(roleDao.AddSecu(con));
            }
            DbSvr.GetDbService().UpdateInTransaction(commands);
            
        }

        /// <summary>
        /// 添加按钮权限
        /// 1、删除该角色的所有按钮权限
        /// 2、添加该角色的所有按钮权限
        /// </summary>
        /// <param name="roleInfo"></param>
        public void AddBtnSecu(RoleInfo roleInfo)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(roleDao.DelBtnSecu(roleInfo));
            foreach (object o in roleInfo.BtnSecu)
            {
                Hashtable con = (Hashtable)o;
                commands.Add(roleDao.AddBtnSecu(con));
            }
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        public void  GetSeucList(RoleInfo roleInfo)
        {
            ArrayList result = roleDao.GetSecuList(roleInfo);
            roleInfo.Secu = result;
        }

        public void GetBtnSecu(RoleInfo roleInfo)
        {
            ArrayList result = roleDao.GetBtnSecu(roleInfo);
            roleInfo.BtnSecu = result;
        }

        
    }
}
