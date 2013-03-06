using System;
using System.Collections;
using TS.Sys.DBLayer;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Info;
using System.Data.SqlClient;
using System.Data;

namespace TS.Sys.Platform.Business.Dao
{
    public class BaseDao : Daos
    {
        public  SqlCommand GetAddCommand(BaseInfo info)
        {
            Hashtable field = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            info.cGUID = cGUID;
            info.cTimeStamp = cTimeStamp;
            return DbSvr.GetDbService().GetInsertCommand(TableName, info);
        }

        public void Add(BaseInfo info)
        {
            if (info.cParent == null || String.IsNullOrEmpty(info.cParent.ToString()))
            {
                info.cParent = "000000";
            }
            DbSvr.GetDbService().ExecuteCommand(GetAddCommand(info));            
        }

        public SqlCommand GetModifyCommand(BaseInfo info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            info.cTimeStamp = cTimeStamp;
            return DbSvr.GetDbService().GetUpdateCommand(TableName, info, con);
        }

        public void Modify(BaseInfo info)
        {
            DbSvr.GetDbService().ExecuteCommand(GetModifyCommand(info));            
        }

        public SqlCommand GetDelCommand(BaseInfo info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            return DbSvr.GetDbService().GetDeleteCommand(TableName, con);
        }

        public void Delete(BaseInfo info)
        {
            DbSvr.GetDbService().ExecuteCommand(GetDelCommand(info));       
        }


        public void Forbidden(BaseInfo info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            Hashtable values = new Hashtable();
            values.Add("iForbidden", 1); 
            DbSvr.GetDbService().Update(TableName, values, con);
        }

        public void Valueable(BaseInfo info)
        {
            Hashtable con = new Hashtable();
            con.Add("cGUID", info.cGUID);
            Hashtable values = new Hashtable();
            values.Add("iForbidden", 0); 
            DbSvr.GetDbService().Update(TableName, values, con);
        }

        public ArrayList GetMaxCode()
        {
            string sql = "select top 1 cCode from " + this.TableName + " order by cCode desc ";
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            return result;
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

      
         
    }
}
