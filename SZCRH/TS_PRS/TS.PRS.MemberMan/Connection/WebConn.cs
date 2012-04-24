using System;
using System.Collections;
using System.Windows.Forms;
using System.Xml;
using TS.Sys.DBLayer;

namespace TS.PRS.MemberMan.Connection
{
    public class WebConn : IDBConfig
    {
        private static System.Collections.Hashtable ht = new System.Collections.Hashtable();

        private static ArrayList conns = new ArrayList();


        private static void init()
        {
            //loadFromRegistery();
            loadFromXML();
            //loadData();
        }
   

        private static void loadData()
        {
            ht.Add("dataSource", "(local)");
            ht.Add("initCataLog", "PRS_SZ_WEB");
            ht.Add("username", "sa");
            ht.Add("password", "sa123456");
        }

        private static void loadFromXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\DataSource\\webdb.xml");

            foreach (XmlNode n in doc.GetElementsByTagName("db")[0].ChildNodes)
            {
                ht.Add(n.Name, n.InnerText);
            }
        }

        public String getConfig(String key)
        {
            if (ht.Count == 0) init();
            return (string)ht[key];
        }
    }
}
