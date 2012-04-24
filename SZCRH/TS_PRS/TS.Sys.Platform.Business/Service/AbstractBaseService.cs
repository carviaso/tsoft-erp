using System.Collections;
using TS.Sys.Domain; 
using TS.Sys.Util;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Dao;
using TS.Sys.Platform.Exceptions;
using System.Windows.Forms;

namespace TS.Sys.Platform.Business.Service
{
    public abstract class AbstractBaseService : Services
    {
        /// <summary>
        /// 时间戳校验
        /// </summary>
        /// <param name="bi"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public void ValidataForTimeStamp(BaseInfo bi)
        {
            if (bi.cTimeStamp == null)
            {
                throw new BusinessException(ExceptionConst.Error_TimeStamp);
            }
            Hashtable con = new Hashtable();
            con.Add("cTimeStamp", bi.cTimeStamp);
            ArrayList list = ((BaseDao)Daos).GetValidatation(con);
            if (list.Count <= 0)
            {
                throw new BusinessException(ExceptionConst.Error_TimeStamp);
            }
        }

        /// <summary>
        /// 校验禁用状态
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public void ValidataForForbidden(BaseInfo bi)
        {
            Hashtable con = new Hashtable();
            con.Add("iForbidden",1);
            con.Add("cGUID", bi.cGUID);
            ArrayList list = ((BaseDao)Daos).GetValidatation(con);
            if (list.Count > 0)
            {
                throw new BusinessException(ExceptionConst.Error_Forbidden);
            }
        }

        /// <summary>
        /// 校验启用状态
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public void ValidataForValueable(BaseInfo bi)
        {
            Hashtable con = new Hashtable();
            con.Add("iForbidden", 0);
            con.Add("cGUID", bi.cGUID);
            ArrayList list = ((BaseDao)Daos).GetValidatation(con);
            if (list.Count > 0)
            {
                throw new BusinessException(ExceptionConst.Error_Valueable);
            }
        }

        /// <summary>
        /// 校验单据编号存在
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public void ValidataForCodeExists()
        {
             
        }

        public void DoDel(BaseInfo bi)
        {
            ValidataForTimeStamp(bi);
            ValidataForForbidden(bi);
            Delete(bi);
        }

        public void DoAdd(BaseInfo bi)
        {
            ValidataForCodeExists();

            Add(bi);
        }

        public void DoModify(BaseInfo bi)
        {

            ValidataForTimeStamp(bi);
            ValidataForForbidden(bi);
            Modify(bi);

        }

        public void DoForbidden(BaseInfo bi)
        {
            ValidataForTimeStamp(bi);
            ValidataForForbidden(bi);
            Forbidden(bi);
        }

        public void DoValueable(BaseInfo bi)
        {
            ValidataForTimeStamp(bi);
            ValidataForValueable(bi);
            Valueable(bi);
        }

        public ArrayList GetMaxCode()
        {
            return ((BaseDao)Daos).GetMaxCode();
        }


        public abstract void Add(BaseInfo bi);

        public abstract void Delete(BaseInfo bi);

        public abstract void Modify(BaseInfo bi);

        public abstract void Forbidden(BaseInfo bi);

        public abstract void Valueable(BaseInfo bi);
    }
}
