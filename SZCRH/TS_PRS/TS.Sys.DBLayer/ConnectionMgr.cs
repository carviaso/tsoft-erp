using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace TS.Sys.DBLayer
{
    public class ConnectionMgr
    {
        private static ConnectionMgr _conmgr;
        private SqlConnection _conn;
        private ConnectionMgr()
        {
            String connStr = String.Format(
                "Data Source={0}; Initial Catalog={1};User Id={2};Pwd={3};",
                DBConfig.getConfig("dataSource"),
                DBConfig.getConfig("initCataLog"),
                DBConfig.getConfig("username"),
                DBConfig.getConfig("password"));
            _conn = new SqlConnection(connStr);
           
        }

        public static ConnectionMgr getInstance()
        {
            if (_conmgr == null) _conmgr = new ConnectionMgr();
            return _conmgr;
        }

        public SqlConnection GetConnection()
        {
            return _conn;
        }
    }
}
