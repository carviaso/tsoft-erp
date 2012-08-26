using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TS.Sys.Domain;
using TS.Sys.Util; 

namespace TS.Sys.DBLayer
{
    public class DbSvr
    {
        private static DbSvr svr;

        private DbSvr() { 
            
        }

        public SqlConnection GetConnection(){

            String connStr = String.Format(
                "Data Source={0}; Initial Catalog={1};User Id={2};Pwd={3};",
                DBConfig.getConfig("dataSource"), 
                DBConfig.getConfig("initCataLog"), 
                DBConfig.getConfig("username"),
                DBConfig.getConfig("password"));

            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public static DbSvr GetDbService()
        {
            if (svr == null) svr = new DbSvr();
            return svr;
        }

        //*****************************************************************************
        //查询接口
        //*****************************************************************************        
        public ArrayList GetListResult(String sql)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandText = String.Format(sql);

                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("[SQL]" + command.CommandText);
                return SqlUtil.MakeList(reader);
            }
        }


        public ArrayList GetListResult(String sql, params Object[] paraAry)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandText = String.Format(sql, paraAry);

                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("[SQL]" + command.CommandText);
                return SqlUtil.MakeList(reader);
            }
        }

        public ArrayList GetListResult(String sql, Hashtable paras)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandText = sql;

                foreach (String key in paras.Keys)
                    command.Parameters.Add(new SqlParameter(key, paras[key]));

                SqlDataReader reader = command.ExecuteReader();
                Console.WriteLine("[SQL]" + command.CommandText);
                return SqlUtil.MakeList(reader);
            }
        }


        public ArrayList GetExitsResult(String tableName, Hashtable paras)
        {
            StringBuilder sb = new StringBuilder("select * from ").Append(tableName);
            if (paras != null)
            {
                sb = sb.Append(" where ");
                int i = 0;
                foreach (Object key in paras.Keys)
                {
                    sb.Append(key.ToString()).Append("=@").Append(key.ToString());
                    i++;
                    if (i != paras.Count) sb.Append(" AND ");
                }
                return GetListResult(sb.ToString(), paras);
            }
            return GetListResult(sb.ToString());
        }

        public ArrayList Query(String tableName, Hashtable paras)
        {
            StringBuilder sb = new StringBuilder("select * from ").Append(tableName).Append(" where ");
            int i = 0;
            foreach (Object key in paras.Keys)
            {
                sb.Append(key.ToString()).Append("=@").Append(key.ToString());
                if (i != paras.Count) sb.Append(" AND ");
                i++;
            }
            return GetListResult(sb.ToString(), paras);
        }

        public Object GetObjectResult(string sql, params Object[] paraAry)
        {
            ArrayList tmp = GetListResult(sql, paraAry);
            if (tmp == null || tmp.Count == 0) return null;
            else
            {
                Hashtable ht = (Hashtable)tmp[0];
                foreach (Object key in ht.Keys)
                    return ht[key];
                return null;
            }
        }

        public Object GetObjectResult(String sql, Hashtable paras)
        {
            ArrayList tmp = GetListResult(sql, paras);
            if (tmp == null || tmp.Count == 0) return null;
            else
            {
                Hashtable ht = (Hashtable)tmp[0];
                foreach (Object key in ht.Keys)
                    return ht[key];
                return null;
            }
        }

        public DataTable GetDataTable(String sql, params Object[] paraAry)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandText = String.Format(sql, paraAry);
                Console.WriteLine("[SQL]" + command.CommandText);
                return SqlUtil.GetDataTable(command);
            }
        }

        public DataTable GetDataTable(String sql, Hashtable paras)
        {
            using (SqlConnection conn = GetConnection())
            {
                SqlCommand command = conn.CreateCommand();
                command.CommandText = sql;
                foreach (String key in paras.Keys)
                {
                    String paramName = "@" + key;
                    Object value = paras[key];
                    command.Parameters.Add(new SqlParameter(paramName, value));
                }
                Console.WriteLine("[SQL]" + command.CommandText);
                return SqlUtil.GetDataTable(command);
            }
        }
        
        //*****************************************************************************
        //获取sqlCommand
        //*****************************************************************************
        
        public SqlCommand GetSqlCommand(String sql, params Object[] paraAry)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = String.Format(sql, paraAry);
            Console.WriteLine("[SQL]" + command.CommandText);
            return command;
        }

        public SqlCommand GetSqlCommand(String sql, Hashtable paras)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;

            foreach (String key in SqlUtil.GetParamStrings(sql))
                command.Parameters.Add(new SqlParameter(key, paras[key]));
            Console.WriteLine("[SQL]" + command.CommandText);
            return command;
        }

        //*****************************************************************************
        //删除
        //*****************************************************************************
        public SqlCommand GetDeleteCommand(String tableName, Hashtable values)
        {
            SqlCommand command = new SqlCommand();
            StringBuilder sqlBodySB = new StringBuilder("delete from ").Append(tableName).Append(" ");

            String sqlCondition = "";
            if(values!=null&&values.Count!=0)
            {
                StringBuilder sqlConditionSB = new StringBuilder("where ");
                foreach (String key in values.Keys)
                {
                    sqlConditionSB.Append(key).Append("=@").Append(key).Append(" AND ");
                    command.Parameters.Add(new SqlParameter(key, values[key]));
                }
                sqlCondition = sqlConditionSB.ToString();
                sqlCondition = sqlCondition.Substring(0, sqlCondition.Length - 4);
            }
            command.CommandText = sqlBodySB.Append(sqlCondition).ToString();
            Console.WriteLine("[SQL]" + command.CommandText);
            return command;
        }

        public int Delete(SqlConnection conn, String tableName, Hashtable values)
        {
            SqlCommand command = GetDeleteCommand(tableName, values);
            command.Connection = conn;
            Console.WriteLine("[SQL]" + command.CommandText);
            return command.ExecuteNonQuery();
        }

        public int Delete(String tableName, Hashtable values)
        {
            using (SqlConnection conn = GetConnection())
            {
                return Delete(conn, tableName, values);
            }
        }


        //*****************************************************************************
        //插入
        //*****************************************************************************
        public SqlCommand GetInsertCommand(String tableName, Hashtable values)
        {
            SqlCommand command = new SqlCommand();
            
            StringBuilder sqlBodySB = new StringBuilder("insert into ").Append(tableName).Append("(");
            foreach (String key in values.Keys)
            {
                if (values[key] != null)
                {
                    sqlBodySB.Append(key).Append(", ");
                }
            }
            String sqlBody = sqlBodySB.ToString();
            sqlBody = sqlBody.Substring(0, sqlBody.Length - 2) + ")";

            StringBuilder sqlConditionSB = new StringBuilder("values(");
            foreach (String key in values.Keys)
            {
                if (values[key] != null)
                {
                    sqlConditionSB.Append("@").Append(key).Append(", ");
                    command.Parameters.Add(new SqlParameter(key, values[key]));
                }
            }
            String sqlCondition = sqlConditionSB.ToString();
            sqlCondition = sqlCondition.Substring(0, sqlCondition.Length - 2) + ")";

            command.CommandText = sqlBody + sqlCondition;
            Console.WriteLine("SQL:"+command.CommandText);
            return command;
        }

        public SqlCommand GetInsertCommand(String tableName, object info)
        {
            return GetInsertCommand(tableName, SqlUtil.GetInsertParamByInfo(info));
        }


        public int Insert(SqlConnection conn, String tableName, Hashtable values)
        {
            SqlCommand command = GetInsertCommand(tableName, values);
            Console.WriteLine("[SQL]" + command.CommandText);
            return ExecuteCommand(command);
        }

        public int Insert(String tableName, Hashtable values)
        {
            using (SqlConnection conn = GetConnection())
            {
                return Insert(conn, tableName, values);
            }
        }


        public int Insert(String tableName, object info)
        {
            return Insert(tableName, SqlUtil.GetInsertParamByInfo(info));
        }

        
        /*
        public int InsertOrUpdate(String tableName, Hashtable values)
        {
            using (SqlConnection conn = GetConnection())
            {
                String cGUID = Convert.ToString(values["cGUID"]);
                values.Remove(cGUID);
                if(Query(tableName, values).Count!=0){
                    Hashtable conditions = new Hashtable();
                    conditions.Add("cGUID", values["cGUID"]);
                    return Update(tableName, values, conditions);
                }
                else return Insert(conn, tableName, values);
            }
        }
        */

        //*****************************************************************************
        //更新
        //*****************************************************************************
        public SqlCommand GetUpdateCommand(String tableName, Object info, Hashtable conditions)
        {
            return GetUpdateCommand(tableName,SqlUtil.GetEditParamByInfo(info, conditions), conditions);
        }

        public SqlCommand GetUpdateCommand(String tableName, Hashtable values, Hashtable conditions)
        {
            if (values == null || values.Count == 0) throw new System.ArgumentException("更新参数为空");
            SqlCommand command = new SqlCommand();
            StringBuilder sqlBodySB = new StringBuilder("update ").Append(tableName).Append(" set ");
            foreach (String key in values.Keys)
            {
                if (conditions[key] != null)
                    continue;
                if (values[key] != null)
                {
                    sqlBodySB.Append(key).Append("=@").Append(key).Append(" , ");
                    command.Parameters.Add(new SqlParameter(key, values[key]));
                }
                else
                {
                    sqlBodySB.Append(key).Append("=NULL, ");
                }
            }
            String sqlBody = sqlBodySB.ToString();
            sqlBody = sqlBody.Substring(0, sqlBody.Length - 2);

            String sqlCondition = "";
            if (conditions != null && conditions.Count != 0)
            {
                StringBuilder sqlConditionSB = new StringBuilder(" where ");
                foreach (String key in conditions.Keys)
                {
                    
                        sqlConditionSB.Append(key).Append("=@").Append(key).Append(" AND ");
                        command.Parameters.Add(new SqlParameter(key, conditions[key]));
                 
                }

                sqlCondition = sqlConditionSB.ToString();
                sqlCondition = sqlCondition.Substring(0, sqlCondition.Length - 4);
            }
            command.CommandText = sqlBody + sqlCondition;
            Console.WriteLine("[SQL]" + command.CommandText);
            return command;
        }
 

        public int Update(String sql, Hashtable paras)
        {
            using (SqlConnection conn = GetConnection())
            {
                return Update(conn, sql, paras);
            }
        }

        public int Update(String sql, params Object[] paraAry)
        {
            using (SqlConnection conn = GetConnection())
            {
                return Update(conn, sql, paraAry);
            }
        }

        public int Update(String tableName, Hashtable values, Hashtable conditions)
        {
            using (SqlConnection conn = GetConnection())
            {
                return Update(conn, tableName, values, conditions);
            }
        }

        public int Update(String tableName, object info, Hashtable condition)
        {
            return Update(tableName, SqlUtil.GetEditParamByInfo(info, condition), condition);
        }        

        public int Update(SqlConnection conn, String sql, params Object[] paraAry)
        {
            SqlCommand command = GetSqlCommand(sql, paraAry);
            command.Connection = conn;
            return command.ExecuteNonQuery();
        }

        public int Update(SqlConnection conn, String sql, Hashtable paras)
        {
            SqlCommand command = GetSqlCommand(sql, paras);
            command.Connection = conn;

            return command.ExecuteNonQuery();
        }

        public int Update(SqlConnection conn, String tableName, Hashtable values, Hashtable conditions)
        {
            SqlCommand command = GetUpdateCommand(tableName, values, conditions);
            command.Connection = conn;

            return command.ExecuteNonQuery();
        }


        /// <summary>
        /// 执行命令行
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public int ExecuteCommand(SqlCommand command)
        {
            using (SqlConnection conn = GetConnection())
            {
                command.Connection = conn;
                return command.ExecuteNonQuery();
            }
        }


        //*****************************************************************************
        //带事务增强的更新
        //*****************************************************************************

        public void UpdateInTransaction(IList<SqlCommand> commands)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlTransaction trans = conn.BeginTransaction())
                {

                    foreach (SqlCommand command in commands)
                    {

                        command.Transaction = trans;
                        command.Connection = conn;
                        Console.WriteLine("SQL:" + command.CommandText);
                        command.ExecuteNonQuery();
                    }
                    trans.Commit();

                }
            }
        }

    }
}
