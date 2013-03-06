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
    public class SaOutService : AbstractBusinessService
    {
        private SaOutDao maDao;

        private static string SQL_LIST = "";

        public SaOutService()
        {
            maDao = new SaOutDao();
            base.Daos = maDao; 
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override void Add(BusinessMainInfo bmi)
        {

            SaOutInfo saOutInfo = (SaOutInfo)bmi;
            ValidataForSubInfo(saOutInfo); 
            DbSvr.GetDbService().UpdateInTransaction(GetSaOutAddCommandList(saOutInfo));
        }

        /// <summary>
        /// 新增销售出库单
        /// </summary>
        /// <param name="soi"></param>
        /// <returns></returns>
        public List<SqlCommand> GetSaOutAddCommandList(SaOutInfo soi)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetSaOutAddMainCommand(soi));
            GetAddSubCommand(soi, commands);
            return commands;
        }

        /// <summary>
        /// 删除销售出库单
        /// </summary>
        /// <param name="soi"></param>
        /// <returns></returns>
        public List<SqlCommand> GetSaOutDelCommandList(SaOutInfo soi)
        {
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetSaOutDelMainCommand(soi));
            commands.Add(maDao.GetSaOutDelSubCommand(soi));
            return commands;
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
            SaOutInfo maInfo = (SaOutInfo)bmi;
            DbSvr.GetDbService().UpdateInTransaction(GetSaOutDelCommandList(maInfo));            
        }

        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void Audit(BusinessMainInfo bmi)
        {
            SaOutInfo maInfo = (SaOutInfo)bmi;
           　
            maDao.SaOutAudit(maInfo);
         }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void UnAudit(BusinessMainInfo bmi)
        {
            SaOutInfo maInfo = (SaOutInfo)bmi;
          　
            maDao.SaOutUnAudit(maInfo);
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
            SaOutInfo maInfo = (SaOutInfo)fi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetSaOutModifyCommand(maInfo));
            commands.Add(maDao.GetSaOutDelSubCommand(maInfo));
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="SaOutCon"></param>
        /// <returns></returns>
        public DataTable GetDataByCondition(Condition SaOutCon)
        {
            return maDao.GetDataByCondition(SaOutCon);
        }

      

        private void GetAddSubCommand(SaOutInfo maInfo, List<SqlCommand> commands)
        {
            foreach (object o in maInfo.SubInfos)
            {
                Hashtable fdHash = (Hashtable)o;
                SaOutSubInfo fdi = new SaOutSubInfo();
                BusinessControl.SetInfoByResult(fdi, fdHash);
                commands.Add(maDao.GetSaOutAddSubCommand(maInfo, fdi));
            }
        }



    }
}
