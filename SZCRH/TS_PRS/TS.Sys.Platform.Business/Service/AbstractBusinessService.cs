using System.Collections;
using TS.Sys.Domain; 
using TS.Sys.Util;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Exceptions;
using System.Windows.Forms;

namespace TS.Sys.Platform.Business.Service
{
    abstract public class AbstractBusinessService:Services
    {  
        
        /// <summary>
        /// 时间戳校验
        /// </summary>
        /// <param name="bmi"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public void ValidataForTimeStamp(BusinessMainInfo bmi)
        {
            if (bmi.cTimeStamp == null)
            {
                throw new BusinessException(ExceptionConst.Error_TimeStamp);
            }
            Hashtable con = new Hashtable();
            con.Add("cTimeStamp",bmi.cTimeStamp);
            ArrayList list = BusinessDao.GetValidatation(con);
            if (list.Count <= 0)
            {
                throw new BusinessException(ExceptionConst.Error_TimeStamp);
            }
        }

        /// <summary>
        /// 子表不能为空的判断
        /// </summary>
        /// <param name="bmi"></param>
        public void ValidataForSubInfo(BusinessMainInfo bmi)
        {
            if (bmi.SubInfos == null||bmi.SubInfos.Count==0)
            {
                throw new BusinessException("子表不能为空！");
            }
        }

        /// <summary>
        /// 审核状态校验
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public void ValidataForAudit(BusinessMainInfo bmi)
        {

            ArrayList list = BusinessDao.GetAuditStatus(bmi.cGUID);
            if (list.Count <= 0)
            {
                throw new BusinessException(ExceptionConst.Error_Audit);
            }
        }

        /// <summary>
        /// 反审核状态校验
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public void ValidataForUnAudit(BusinessMainInfo bmi)
        {

            ArrayList list = BusinessDao.GetAuditStatus(bmi.cGUID);
            if (list.Count > 0)
            {
                throw new BusinessException(ExceptionConst.Error_UnAudit);
            }
        }

        public void ValidataForCodeExists()
        {
            
        }

        /// <summary>
        /// 删除操作
        /// 1、时间戳校验
        /// 2、审核校验
        /// </summary>
        /// <param name="bmi"></param>
        public void DoDel(BusinessMainInfo bmi)
        {

            ValidataForTimeStamp(bmi);
            ValidataForAudit(bmi);
            Del(bmi);

        }

        /// <summary>
        /// 新增保存操作
        /// </summary>
        /// <param name="bmi"></param>
        public void DoAdd(BusinessMainInfo bmi)
        {

            ValidataForCodeExists();
            Add(bmi);


        }

        /// <summary>
        /// 修改保存操作
        /// 1、时间戳校验
        /// </summary>
        /// <param name="bmi"></param>
        public void DoModify(BusinessMainInfo bmi)
        {

            ValidataForTimeStamp(bmi);
            ValidataForAudit(bmi);
            Modify(bmi);

        }

        /// <summary>
        /// 审核操作
        /// 1、时间戳校验
        /// 2、审核校验
        /// </summary>
        /// <param name="bmi"></param>
        public void DoAudit(BusinessMainInfo bmi)
        {
            ValidataForTimeStamp(bmi);
            ValidataForAudit(bmi);
            Audit(bmi);

        }

        /// <summary>
        /// 反审核操作
        /// 1、时间戳校验
        /// 2、审核校验
        /// </summary>
        /// <param name="bmi"></param>
        public void DoUnAudit(BusinessMainInfo bmi)
        {

            ValidataForTimeStamp(bmi);
            ValidataForUnAudit(bmi);
            UnAudit(bmi);

        }

        public virtual ArrayList GetSubResult(object cHeadGUID)
        {
            return BusinessDao.GetSubResult(cHeadGUID);
        }

        abstract public void Add(BusinessMainInfo bmi);

        abstract public void Del(BusinessMainInfo bmi);

        abstract public void Modify(BusinessMainInfo bmi);

        abstract public void Audit(BusinessMainInfo bmi);

        abstract public void UnAudit(BusinessMainInfo bmi);

        
      
    }
}
