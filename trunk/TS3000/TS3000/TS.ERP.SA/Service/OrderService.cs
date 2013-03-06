using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.ERP.SA.Dao;
using TS.ERP.SA.Info;
using TS.ERP.ST.Service;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;
using TS.ERP.ST.Info;

namespace TS.ERP.SA.Service
{
    public class OrderService : AbstractBusinessService
    {
        private OrderDao maDao;
        private SaOutService saOutService;

        private static string SQL_LIST = "";

        public OrderService()
        {
            maDao = new OrderDao();
            base.Daos = maDao; 
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override void Add(BusinessMainInfo bmi)
        {

            OrderInfo OrderInfo = (OrderInfo)bmi;
            ValidataForSubInfo(OrderInfo); 
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
            OrderInfo maInfo = (OrderInfo)bmi;
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
            OrderInfo maInfo = (OrderInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetOrderAuditCommand(maInfo));
            SaOutInfo saOutInfo = (SaOutInfo)bmi;
            //新增采购入库单
            commands.AddRange(saOutService.GetSaOutAddCommandList(saOutInfo));
            DbSvr.GetDbService().UpdateInTransaction(commands);
         }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void UnAudit(BusinessMainInfo bmi)
        {
            OrderInfo maInfo = (OrderInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetOrderUnAuditCommand(maInfo));
            SaOutInfo saOutInfo = (SaOutInfo)bmi;
            //新增采购入库单
            commands.AddRange(saOutService.GetSaOutDelCommandList(saOutInfo));
            DbSvr.GetDbService().UpdateInTransaction(commands);
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
            OrderInfo maInfo = (OrderInfo)fi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetModifyCommandMemberAllow(maInfo));
            commands.Add(maDao.GetDelSubCommandMemberAllow(maInfo));
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        /// <summary>
        /// 根据条件查询记录
        /// </summary>
        /// <param name="OrderCon"></param>
        /// <returns></returns>
        public DataTable GetDataByCondition(Condition OrderCon)
        {
            return maDao.GetDataByCondition(OrderCon);
        }

      

        private void GetAddSubCommand(OrderInfo maInfo, List<SqlCommand> commands)
        {
            foreach (object o in maInfo.SubInfos)
            {
                Hashtable fdHash = (Hashtable)o;
                OrderSubInfo fdi = new OrderSubInfo();
                BusinessControl.SetInfoByResult(fdi, fdHash);
                commands.Add(maDao.GetAddSubCommandMemberAllow(maInfo, fdi));
            }
        }



    }
}
