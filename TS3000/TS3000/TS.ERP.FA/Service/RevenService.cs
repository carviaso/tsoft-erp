using System.Collections.Generic;
using TS.Sys.Platform.Business.Service;
using TS.ERP.FA.Dao;
using TS.Sys.Platform.Business.Info;
using System.Data.SqlClient;
using TS.Sys.DBLayer;
using TS.ERP.FA.Info;
using TS.Sys.Platform.Business.Util;
using System.Collections;
using System.Data;

namespace TS.ERP.FA.Service
{
    public class RevenService : AbstractBusinessService
    {
        private RevenDao maDao;

        private static string SQL_LIST = "";

        public RevenService()
        {
            maDao = new RevenDao();
            base.Daos = maDao; 
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override void Add(BusinessMainInfo bmi)
        {

            RevenInfo RevenInfo = (RevenInfo)bmi;
            ValidataForSubInfo(RevenInfo); 
            List<SqlCommand> commands = new List<SqlCommand>();
　　


            DbSvr.GetDbService().UpdateInTransaction(commands);
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
            RevenInfo maInfo = (RevenInfo)bmi;
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
            RevenInfo maInfo = (RevenInfo)bmi;
           　
            maDao.AuditMemberAllow(maInfo);
         }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void UnAudit(BusinessMainInfo bmi)
        {
            RevenInfo maInfo = (RevenInfo)bmi;
          　
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
            RevenInfo maInfo = (RevenInfo)fi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetModifyCommandMemberAllow(maInfo));
            commands.Add(maDao.GetDelSubCommandMemberAllow(maInfo));
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="RevenCon"></param>
        /// <returns></returns>
        public DataTable GetDataByCondition(Condition RevenCon)
        {
            return maDao.GetDataByCondition(RevenCon);
        }

      

        private void GetAddSubCommand(RevenInfo maInfo, List<SqlCommand> commands)
        {
            foreach (object o in maInfo.SubInfos)
            {
                Hashtable fdHash = (Hashtable)o;
                RevenSubInfo fdi = new RevenSubInfo();
                BusinessControl.SetInfoByResult(fdi, fdHash);
                commands.Add(maDao.GetAddSubCommandMemberAllow(maInfo, fdi));
            }
        }



    }
}
