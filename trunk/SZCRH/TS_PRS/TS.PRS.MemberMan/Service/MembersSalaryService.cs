using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TS.PRS.MemberMan.Adapter;
using TS.PRS.MemberMan.Dao;
using TS.PRS.MemberMan.Info;
using TS.Sys.DBLayer;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;

namespace TS.PRS.MemberMan.Service
{
    public class MembersSalaryService : AbstractBusinessService
    {
        private MembersSalaryDao maDao;
        private MembersSalaryAdapter memSalaryAdapter;

        public MembersSalaryService()
        {
            maDao = new MembersSalaryDao();
            base.Daos = maDao;
            memSalaryAdapter = new MembersSalaryAdapter();
        }
        /// <summary>
        /// 添加主表信息
        /// 添加明细表信息
        /// 
        /// </summary>
        public override void Add(BusinessMainInfo bmi)
        {
           ;
            MembersSalaryInfo maInfo = (MembersSalaryInfo)bmi;
            ValidataForSubInfo(maInfo);
            ValidataForPeriod(maInfo);
            List<SqlCommand> commands = new List<SqlCommand>();
            SqlCommand command = maDao.GetAddMainCommandMemberSalary(maInfo);
            commands.Add(command);
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        private void ValidataForPeriod(MembersSalaryInfo maInfo)
        {
            DateTime date = (DateTime)maInfo.dDate;
           
            String cYear = date.Year.ToString();
            String cMonth = string.Format("{0:D2}",  date.Month);
            String dateCon =cYear+"-"+cMonth;
            ArrayList result = DbSvr.GetDbService().GetListResult("select 1 from MEM_MemberSalaryList where CONVERT(varchar(100), dDate, 23) like '" + dateCon + "%'");
            if (result.Count > 0)
            {
                throw new BusinessException("当前期间"+dateCon+"已经生成过工资单，不能再次生成！");
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
            MembersSalaryInfo maInfo = (MembersSalaryInfo)bmi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetDelMainCommandMemberSalary(maInfo));
            commands.Add(maDao.GetDelSubCommandMemberSalary(maInfo));
            DbSvr.GetDbService().UpdateInTransaction(commands);            
        }

        /// <summary>
        /// 审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void Audit(BusinessMainInfo bmi)
        {
            MembersSalaryInfo maInfo = (MembersSalaryInfo)bmi;
            try
            {
                memSalaryAdapter.DoAuditAdapter(maInfo);
            }
            catch (Exception ex)
            {
                throw new BusinessException("数据同步错误，审核失败！");
            }
            maDao.AuditMemberSalary(maInfo);
         }

        /// <summary>
        /// 反审核单据
        /// </summary>
        /// <param name="cGUID"></param>
        /// <returns></returns>
        public override void UnAudit(BusinessMainInfo bmi)
        {
            MembersSalaryInfo maInfo = (MembersSalaryInfo)bmi;
            try
            {
                memSalaryAdapter.DoUnAuditAdapter(maInfo);
            }
            catch (Exception ex)
            {
                throw new BusinessException("数据同步错误，审核失败！");
            }
            maDao.UnAuditMemberSalary(maInfo);
        }

        /// <summary>
        /// 修改会员津贴单
        /// 1、修改会员工资单主表
        /// 2、删除原会员工资子表数据
        /// 3、添加新会员工资子表数据
        /// </summary>
        /// <param name="fi"></param>
        /// <returns></returns>
        public override void Modify(BusinessMainInfo fi)
        {
            MembersSalaryInfo maInfo = (MembersSalaryInfo)fi;
            List<SqlCommand> commands = new List<SqlCommand>();
            commands.Add(maDao.GetModifyCommandMemberSalary(maInfo));
            commands.Add(maDao.GetDelSubCommandMemberSalary(maInfo));
            GetAddSubCommand(maInfo, commands);
            DbSvr.GetDbService().UpdateInTransaction(commands);
        }

        public DataTable QueryForAll()
        {
            return maDao.QueryForAll();
        }

        private void GetAddSubCommand(MembersSalaryInfo maInfo, List<SqlCommand> commands)
        {
            foreach (object o in maInfo.SubInfos)
            {
                Hashtable fdHash = (Hashtable)o;
                MembersSalarySubInfo fdi = new MembersSalarySubInfo();
                BusinessControl.SetInfoByResult(fdi, fdHash);
                commands.Add(maDao.GetAddSubCommandMemberSalary(maInfo, fdi));
            }
        }

        /// <summary>
        /// 获取所有可发放工资用户
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList ImportSalaryMembers(Hashtable con)
        {

            return maDao.GetSalaryMembers(con);
        }


    }
}
