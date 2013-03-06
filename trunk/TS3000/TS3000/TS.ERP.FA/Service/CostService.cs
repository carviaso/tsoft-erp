using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class CostService : AbstractBusinessService
    {
        private CostDao maDao;

        private static string SQL_LIST = "";

        public CostService()
        {
            maDao = new CostDao();
            base.Daos = maDao; 
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override void Add(BusinessMainInfo bmi)
        {

            CostInfo costInfo = (CostInfo)bmi;
            ValidataForSubInfo(costInfo); 
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
            CostInfo maInfo = (CostInfo)bmi;
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
            CostInfo maInfo = (CostInfo)bmi;
           　
            maDao.AuditMemberAllow(maInfo);
         }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void UnAudit(BusinessMainInfo bmi)
        {
            CostInfo maInfo = (CostInfo)bmi;
          　
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
            CostInfo maInfo = (CostInfo)fi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetModifyCommandMemberAllow(maInfo));
            commands.Add(maDao.GetDelSubCommandMemberAllow(maInfo));
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="costCon"></param>
        /// <returns></returns>
        public DataTable GetDataByCondition(Condition costCon)
        {
            return maDao.GetDataByCondition(costCon);
        }

      

        private void GetAddSubCommand(CostInfo maInfo, List<SqlCommand> commands)
        {
            foreach (object o in maInfo.SubInfos)
            {
                Hashtable fdHash = (Hashtable)o;
                CostSubInfo fdi = new CostSubInfo();
                BusinessControl.SetInfoByResult(fdi, fdHash);
                commands.Add(maDao.GetAddSubCommandMemberAllow(maInfo, fdi));
            }
        }



    }
}
