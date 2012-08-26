using System;
using System.Collections;
using System.Data.SqlClient;
using TS.Sys.DBLayer;
using TS.Sys.Domain; 
using TS.Sys.Session;
using TS.Sys.Util;
using TS.Sys.Platform.Business.Info;

namespace TS.Sys.Platform.Business.Dao
{
    public class BusinessDao : Daos
    {
        private string _subTableName;

        public String SubTableName
        {
            get { return this._subTableName; }
            set { this._subTableName = value; }
        }

        protected void AddMain(BusinessMainInfo bi)
        {
            SqlCommand command = GetAddMainCommand(bi);
            DbSvr.GetDbService().ExecuteCommand(command);
        }

        protected void AddSub(BusinessMainInfo fi, BusinessSubInfo fdi)
        {
            SqlCommand command = GetAddSubCommand(fi, fdi);
            DbSvr.GetDbService().ExecuteCommand(command);
        }

        protected void Audit(BusinessMainInfo bmi)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", bmi.cGUID);
            Hashtable values = new Hashtable();
            values.Add("cAuditor", UserSession.UserID);
            values.Add("dAuditDate", UserSession.LoginDate);
            String cTimeStamp = KeyUtil.genSimpleKey();
            values.Add("cTimeStamp", cTimeStamp);

            Result result = new Result();
            DbSvr.GetDbService().Update(TableName, values, con);
            bmi.cTimeStamp = cTimeStamp;
            bmi.cAuditor = UserSession.UserID;
            bmi.dAuditDate = UserSession.LoginDate; 
        }

        protected void UnAudit(BusinessMainInfo bmi)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", bmi.cGUID);
            Hashtable values = new Hashtable();
            values.Add("cAuditor", null);
            values.Add("dAuditDate", null);
            String cTimeStamp = KeyUtil.genSimpleKey();
            values.Add("cTimeStamp", cTimeStamp);
            bmi.cTimeStamp = cTimeStamp;
            Result result = new Result();
            DbSvr.GetDbService().Update(TableName, values, con);
            bmi.cAuditor = null;
            bmi.dAuditDate = null;
        }

        protected SqlCommand GetAddMainCommand(BusinessMainInfo bi)
        {
            Hashtable field = new Hashtable();
            String cGUID = KeyUtil.genSimpleKey();
            bi.cGUID = cGUID;
            String cTimeStamp = KeyUtil.genSimpleKey();
            bi.cTimeStamp = cTimeStamp;
            SqlCommand result = DbSvr.GetDbService().GetInsertCommand(TableName, bi);
            return result;
        }

        protected SqlCommand GetAddSubCommand(BusinessMainInfo bi,BusinessSubInfo bsi)
        {
            Hashtable field = new Hashtable();
            String cGUID = KeyUtil.genSimpleKey();
            bsi.cGUID = cGUID;
            bsi.cHeadGUID = bi.cGUID;
            SqlCommand command = DbSvr.GetDbService().GetInsertCommand(SubTableName, bsi);
            return command;
        }

        protected SqlCommand GetDelMainCommand(BusinessMainInfo bmi)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", bmi.cGUID);
            SqlCommand command = DbSvr.GetDbService().GetDeleteCommand(TableName, con);
            return command;
        }

        protected SqlCommand GetDelSubCommand(BusinessMainInfo bmi)
        {
            Hashtable con = new Hashtable();
            con.Add("cHeadGUID", bmi.cGUID);
            return DbSvr.GetDbService().GetDeleteCommand(SubTableName, con);
        }

        protected SqlCommand GetModifyCommand(BusinessMainInfo bmi)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", bmi.cGUID);
            String cTimeStamp = KeyUtil.genSimpleKey();
            bmi.cTimeStamp = cTimeStamp;
            return DbSvr.GetDbService().GetUpdateCommand(TableName, SqlUtil.GetInsertParamByInfo(bmi), con);
        }

        protected int DelMain(BusinessMainInfo bmi)
        {
            SqlCommand command = GetDelMainCommand(bmi);
            return DbSvr.GetDbService().ExecuteCommand(command);
        }

        /// <summary>
        /// 根据条件查询结果集 
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public ArrayList GetValidatation(Hashtable con)
        {
            ArrayList result = DbSvr.GetDbService().GetExitsResult(TableName, con);
            return result;
        }

        public ArrayList GetAuditStatus(object cGUID)
        {
            ArrayList result = DbSvr.GetDbService().GetListResult("select 1 from " + TableName + " where cAuditor is null and cGUID='" + cGUID + "'");
            return result;
        }

        /// <summary>
        /// 查询子表信息
        /// </summary>
        /// <param name="cHeadGUID"></param>
        /// <returns></returns>
        public ArrayList GetSubResult(object cHeadGUID)
        {
            Hashtable con = new Hashtable();
            con.Add("cHeadGUID", cHeadGUID);
            return DbSvr.GetDbService().GetExitsResult(SubTableName, con);
        }
    }
}
