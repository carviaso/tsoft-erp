using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using TS.Sys.DBLayer;

namespace Tool
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.gridModual.DataSource = DbSvr.GetDbService().GetDataTable("select cCode,cName,cTitle,cType,cImgPath from Sys_Modual");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select top 1 cCode from Sys_Modual order by cCode desc ";
            ArrayList result = DbSvr.GetDbService().GetListResult(sql);
            int codeNumber = 1;
            if (result.Count != 0)
            {
                Hashtable code = (Hashtable)result[0];
                codeNumber = int.Parse(code["cCode"].ToString()) + 1;
            }
            String mCode = string.Format("{0:D3}", codeNumber);
            Hashtable con = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            con.Add("cGUID", cGUID);
            con.Add("cName", cName.Value);
            String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();
            con.Add("cTimeStamp", cTimeStamp);
            con.Add("iForbidden", 0);
            con.Add("cTitle", cTitle.Value);
            con.Add("cCode", mCode);
            con.Add("cType", cType.Value);
            con.Add("cImgPath", cImgPath.Value);
            DbSvr.GetDbService().Insert("Sys_Modual", con);
            Hashtable con1 = new Hashtable();
            cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
            con1.Add("cGUID",cGUID);
            con1.Add("cCode", cName.Value);
            con1.Add("cName",cTitle.Value);
            con1.Add("cParent", "000000");
            DbSvr.GetDbService().Insert("Sys_SysMenu", con1); 
        }
    }
}
