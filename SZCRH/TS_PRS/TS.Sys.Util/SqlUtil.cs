using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using TS.Sys.Domain; 

namespace TS.Sys.Util
{
    public class SqlUtil
    {
        private static String[] TERMINATE_KEYS = { ",", " ", ")" };

        

        public static ArrayList MakeList(SqlDataReader reader)
        {
            ArrayList list = new ArrayList();
            while (reader.Read())
            {
                Hashtable ht = new Hashtable();
                for (int i = 0; i < reader.FieldCount; i++)
                    ht.Add(reader.GetName(i), reader.GetValue(i));
                list.Add(ht);
            }
            return list;
        }

        public static ArrayList GetParamStrings(String sql)
        {
            ArrayList retList = new ArrayList();
            int startIndex = 0;
            while ((startIndex = sql.IndexOf("@", startIndex)) != -1)
            {
                int endIndex = GetEndIndex(sql, startIndex);
                retList.Add(sql.Substring(startIndex + 1, endIndex - startIndex - 1).Trim());
                startIndex = endIndex;
            }
            return retList;
        }

        public static Hashtable GetInsertParamByInfo(object info)
        {
            Type objType = info.GetType();
            Hashtable param = new Hashtable();
            foreach (PropertyInfo pi in objType.GetProperties())
            {
                Object[] ats = pi.GetCustomAttributes(typeof(InfosAttributes), false);
                if (ats != null && ats.Length > 0)
                {
                    InfosAttributes infoAttr = (InfosAttributes)ats[0];
                    if (!infoAttr.isDataElement)
                        continue;
                }
                Object proValue = pi.GetValue(info, null);
                if(!(proValue is IList))
                {
                    param.Add(pi.Name, proValue);
                }
            }
            return param;
        }


        public static Hashtable GetModifyParamByInfo(object info)
        {
            Type objType = info.GetType();
            Hashtable param = new Hashtable();
            foreach (PropertyInfo pi in objType.GetProperties())
            {
                //修改的时候cGUID为主键
                if (pi.Name.Equals("cGUID"))
                {
                    continue;
                }
                Object proValue = pi.GetValue(info, null);
                if (!(proValue is IList))
                {
                    param.Add(pi.Name, proValue);
                }
            }
            return param;
        }



        public static Hashtable GetEditParamByInfo(object info,Hashtable con)
        {
            Type objType = info.GetType();
            Hashtable param = new Hashtable();
            foreach (PropertyInfo pi in objType.GetProperties())
            {
                if (con[pi.Name] == null)
                {
                    param.Add(pi.Name, pi.GetValue(info, null));
                }
            }
            return param;
        }

        public static DataTable GetDataTable(SqlCommand command) 
        {
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        private static int GetEndIndex(String str, int startIndex)
        {
            int endIndex = -1;
            foreach (String terminateKey in TERMINATE_KEYS)
            {
                endIndex = str.IndexOf(terminateKey, startIndex);
                if (endIndex != -1) break;
                else continue;
            }
            if (endIndex == -1) endIndex = str.Length;
            return endIndex;
        }


    }
}
