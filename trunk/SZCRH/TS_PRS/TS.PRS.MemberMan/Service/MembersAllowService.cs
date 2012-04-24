using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.PRS.MemberMan.Dao;
using TS.PRS.MemberMan.Info;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using System;
using TS.PRS.MemberMan.Adapter;

namespace TS.PRS.MemberMan.Service
{
    public class MembersAllowService:AbstractBusinessService
    {
        private MembersAllowDao maDao;
        private MembersAllowAdapter memAllowAdapter;

        public MembersAllowService()
        {
            maDao = new MembersAllowDao();
            base.Daos = maDao;
            memAllowAdapter = new MembersAllowAdapter();
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override void Add(BusinessMainInfo bmi)
        {
           ;
            MembersAllowInfo maInfo = (MembersAllowInfo)bmi;
            ValidataForSubInfo(maInfo);
            ValidataForPeriod(maInfo);
            List<SqlCommand> commands = new List<SqlCommand>();
            SqlCommand command = maDao.GetAddMainCommandMemberAllow(maInfo);
            commands.Add(command);
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        private void ValidataForPeriod(MembersAllowInfo maInfo)
        {
            DateTime date = (DateTime)maInfo.dDate;
           
            String cYear = date.Year.ToString();
            String cMonth = string.Format("{0:D2}",  date.Month);
            String dateCon =cYear+"-"+cMonth;
            ArrayList result = DbSvr.GetDbService().GetListResult("select 1 from MEM_MemberAllowList where CONVERT(varchar(100), dDate, 23) like '" + dateCon + "%'");
            if (result.Count > 0)
            {
                throw new BusinessException("当前期间"+dateCon+"已经生成过津贴单，不能再次生成！");
            }
        }

        

        /// <summary>
        /// 删除单据
        /// 删除主表
        /// 删除子表
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void Del(BusinessMainInfo bmi)
        {
            MembersAllowInfo maInfo = (MembersAllowInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetDelMainCommandMemberAllow(maInfo));
            commands.Add(maDao.GetDelSubCommandMemberAllow(maInfo));
            DbSvr.GetDbService().UpdateInTransaction(commands);            
        }

        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void Audit(BusinessMainInfo bmi)
        {
            MembersAllowInfo maInfo = (MembersAllowInfo)bmi;
            try
            {
                memAllowAdapter.DoAuditAdapter(maInfo);
            }
            catch (Exception ex)
            {
                throw new BusinessException("数据同步错误，审核失败！");
            }
            maDao.AuditMemberAllow(maInfo);
         }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void UnAudit(BusinessMainInfo bmi)
        {
            MembersAllowInfo maInfo = (MembersAllowInfo)bmi;
            try
            {
                memAllowAdapter.DoUnAuditAdapter(maInfo);
            }
            catch (Exception ex)
            {
                throw new BusinessException("数据同步错误，审核失败！");
            }
            maDao.UnAuditMemberAllow(maInfo);
        }

        /// <summary>
        /// 修改会员津贴单
        /// 1、修改会员津贴单主表
        /// 2、删除原会员津贴子表数据
        /// 3、添加新会员津贴子表数据
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        public override void Modify(BusinessMainInfo fi)
        {
            MembersAllowInfo maInfo = (MembersAllowInfo)fi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetModifyCommandMemberAllow(maInfo));
            commands.Add(maDao.GetDelSubCommandMemberAllow(maInfo));
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        private void GetAddSubCommand(MembersAllowInfo maInfo, List<SqlCommand> commands)
        {
            foreach (object o in maInfo.SubInfos)
            {
                Hashtable fdHash = (Hashtable)o;
                MembersAllowSubInfo fdi = new MembersAllowSubInfo();
                BusinessControl.SetInfoByResult(fdi, fdHash);
                commands.Add(maDao.GetAddSubCommandMemberAllow(maInfo, fdi));
            }
        }
         

        /// <summary>
        /// 获取所有可发放津贴用户
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList ImportAllowMembers(Hashtable con)
        {
             
            return maDao.GetAllowMembers(con);
        }

        public ArrayList GetForAllGUID()
        {
            return maDao.GetForAllGUID();
        }

        public ArrayList GetForAll()
        {
            return maDao.GetForAll();
        }
         
        public DataTable QueryForAll()
        {
            return maDao.QueryForAll();
         }

        public DataTable QuerySubByGUID(object cGUID)
        {
            return maDao.QuerySubByGUID(cGUID);
        }

        
    }
}
