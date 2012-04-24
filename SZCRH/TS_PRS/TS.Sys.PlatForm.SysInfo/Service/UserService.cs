using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Platform.SysInfo.Dao;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.Business.Info;
using System.Data;
using System.Collections;
using TS.Sys.Platform.Exceptions;

namespace TS.Sys.Platform.SysInfo.Service
{
    public class UserService:AbstractBaseService
    {
        private UserDao userDao;

        public UserService()
        {
            userDao = new UserDao();
            base.Daos = userDao;
        }

        public override void Add(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
            userDao.AddUser(userInfo);
            userDao.AddPwd(userInfo, "88888888");
        }

        public override void Modify(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
            userDao.ModifyUser(userInfo);
        }

        public override void Delete(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
            userDao.DeleteUser(userInfo);
        }

        public override void Forbidden(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
            userDao.ForbiddenUser(userInfo);
        }

        public override void Valueable(BaseInfo baseInfo)
        {
            UserInfo userInfo = (UserInfo)baseInfo;
            userDao.ValueableUser(userInfo);
        }

        public void ModifyPwd(UserInfo userInfo,String oldPwd,String newPwd)
        {
            ArrayList result = userDao.GetUserPwd(userInfo);
            if (result == null || result.Count == 0)
            {
                throw new BusinessException("用户不存在");
            }
            Hashtable userDetail = (Hashtable)result[0];
            if (userDetail["cPassword"].ToString() != oldPwd)
            {
                throw new BusinessException("用户密码错误！");
            }

            userDao.ModifyPwd(userInfo, newPwd);

            
        }

        public DataTable GetUserByRole(Object con)
        {
            return userDao.GetUserByRole(con);
        }

    }
}
