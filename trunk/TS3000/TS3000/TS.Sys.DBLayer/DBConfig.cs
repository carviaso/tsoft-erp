using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml;
using TS.Sys.Util;

namespace TS.Sys.DBLayer
{
    public class DBConfig
    {
        private static System.Collections.Hashtable ht = new System.Collections.Hashtable();

        private static ArrayList conns = new ArrayList();


        private static void init()
        {
            //loadFromRegistery();
            //loadFromXML();
            loadData();
        }

        private static void loadFromRegistery()
        {
            ht.Add("dataSource", RegisteryUtil.GetRegistData("DataSource"));
            ht.Add("initCataLog", RegisteryUtil.GetRegistData("InitCataLog"));
            ht.Add("username", RegisteryUtil.GetRegistData("Username"));
            ht.Add("password", RegisteryUtil.GetRegistData("Password"));
        }

        private static void loadData()
        {
            ht.Add("dataSource","(local)");
            ht.Add("initCataLog", "TS3000");
            ht.Add("username", "sa");
            ht.Add("password", "sa123456");
        }

        private static void loadFromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath+"\\DataSource\\db.xml");
           
            foreach(XmlNode n in doc.GetElementsByTagName("db")[0].ChildNodes)
            {
                ht.Add(n.Name, n.InnerText);
            }
        }

        public static String getConfig(String key)
        {
            if (ht.Count == 0) init();
            return (string)ht[key];
        }
    }
}
