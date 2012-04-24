using System;
using System.Collections.Generic;
using System.Text;

namespace TS.Sys.Session
{
    public class UserSession
    {
        private static string _userid;
        private static string _username;
        private static string _roleid;
        private static string _rolename;
        private static DateTime _loginDate;

        public static string UserID
        {
            get { return _userid; }//_userid;}
            set { _userid = value;}
        }

        public static string RoleID
        {
            get { return _roleid; }
            set { _roleid = value; }
        }

        public static string UserName
        {
            get { return _username; }
            set { _username = value; }
        }

        public static string RoleName
        {
            get { return _rolename; }
            set { _rolename = value; }
        }

        public static DateTime LoginDate
        {
            get { return _loginDate; }// _loginDate; }
            set { _loginDate = value; }
        }

        public static void ClearSession()
        {
            _userid = null;
           // _loginDate = null;
        }
    }
}
