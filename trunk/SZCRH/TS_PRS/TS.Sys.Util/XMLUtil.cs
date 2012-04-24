using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Xml;

namespace TS.Sys.Util
{
    public class XMLUtil
    {


        public static IDictionary<String, String> loadSqlXML(String path)
        {
            IDictionary<String, String> sqls = new Dictionary<String, String>();

            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList sqlNodes = doc.SelectNodes("//sqls/sql");
            foreach (XmlNode sqlNode in sqlNodes)
                sqls.Add(sqlNode.Attributes["id"].InnerText, sqlNode.InnerText.Trim());

            return sqls;
            
        }
    }
}
