using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.ERP.ST.Dao;
using TS.ERP.ST.Info;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;

namespace TS.ERP.ST.Service
{
    public class PuInService : AbstractBusinessService
    {
        private PuInDao maDao;

        private static string SQL_LIST = "";

        public PuInService()
        {
            maDao = new PuInDao();
            base.Daos = maDao; 
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override void Add(BusinessMainInfo bmi)
        {

            PuInInfo puInInfo = (PuInInfo)bmi;
            ValidataForSubInfo(puInInfo); 
            List<SqlCommand> commands = new List<SqlCommand>();
            commands = GetPuInAddCommandList(puInInfo);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        /// <summary>
        /// 采购入库流程
        /// </summary>
        /// <param name="pii"></param>
        /// <returns></returns>
        public List<SqlCommand> GetPuInAddCommandList(PuInInfo pii)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetPuInAddMainCommand(pii));
            GetAddSubCommand(pii, commands);
            return commands;
        }

        /// <summary>
        /// 删除采购入库单
        /// 删除主表信息
        /// 删除子表信息
        /// </summary>
        /// <param name="pii"></param>
        /// <returns></returns>
        public List<SqlCommand> GetPuInDelCommandList(PuInInfo pii)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetPuInDelMainCommand(pii));
            commands.Add(maDao.GetPuInDelSubCommand(pii));
            return commands;
        }
       　
        

        /// <summary>
        /// 删除单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void Del(BusinessMainInfo bmi)
        {
            PuInInfo maInfo = (PuInInfo)bmi;
            DbSvr.GetDbService().UpdateInTransaction(GetPuInDelCommandList(maInfo));            
        }

        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void Audit(BusinessMainInfo bmi)
        {
            PuInInfo maInfo = (PuInInfo)bmi;           　
            maDao.PuInAudit(maInfo);
         }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void UnAudit(BusinessMainInfo bmi)
        {
            PuInInfo maInfo = (PuInInfo)bmi;
          　
            maDao.PuInUnAudit(maInfo);
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
            PuInInfo maInfo = (PuInInfo)fi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetPuInModifyCommand(maInfo));
            commands.Add(maDao.GetPuInDelSubCommand(maInfo));
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="PuInCon"></param>
        /// <returns></returns>
        public DataTable GetDataByCondition(Condition PuInCon)
        {
            return maDao.GetDataByCondition(PuInCon);
        }

      
        /// <summary>
        /// 
        /// 增加子集的添加命令
        /// </summary>
        /// <param name="maInfo"></param>
        /// <param name="commands"></param>
        private void GetAddSubCommand(PuInInfo maInfo, List<SqlCommand> commands)
        {
            foreach (object o in maInfo.SubInfos)
            {
                Hashtable fdHash = (Hashtable)o;
                PuInSubInfo fdi = new PuInSubInfo();
                BusinessControl.SetInfoByResult(fdi, fdHash);
                commands.Add(maDao.GetPuInAddSubCommand(maInfo, fdi));
            }
        }



    }
}
