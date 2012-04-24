using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Sys.DBLayer;
using System.Collections;

namespace Tool
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            RefreshGrid();
        }

        public Form3(Object name)
            :this()
        {
            this.modualCode.Value = name;
        }

        private void RefreshGrid()
        {
            this.dataGridView2.DataSource = DbSvr.GetDbService().GetDataTable("select * from Sys_Menu order by iOrder asc");
            dataGridView1.DataSource = DbSvr.GetDbService().GetDataTable("select * from Sys_SysMenu");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Hashtable con = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey(); 
            con.Add("cGUID",cGUID);
            con.Add("cCode",cCode.Value);
            con.Add("cForm",cForm.Value);
            con.Add("cName", cCode.Value);
            if(cImgPath.Value!=null&&!String .IsNullOrEmpty(cImgPath.Value.ToString()))
            con.Add("cImgPath",cImgPath.Value);
            con.Add("cTitle", cTitle.Value);
            StringBuilder parents = new StringBuilder();
            foreach (DataGridViewRow row in gridParent.Rows)
            {
                if (row.Cells["cParent"].Value==null||String.IsNullOrEmpty(row.Cells["cParent"].Value.ToString()))
                    continue;
                parents.Append(row.Cells["cParent"].Value).Append(";");
            }
            con.Add("cParent",parents.ToString());
            StringBuilder fields = new StringBuilder();
            foreach (DataGridViewRow row in gridField.Rows)
            {
                if (row.Cells["cField"].Value == null || String.IsNullOrEmpty(row.Cells["cField"].Value.ToString()))
                    continue;
                fields.Append(row.Cells["cField"].Value).Append(";");
            }
            con.Add("cField", fields.ToString());
            DbSvr.GetDbService().Insert("Sys_Menu",con);
           
            RefreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hashtable conM = new Hashtable();
            String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey(); 
            conM.Add("cGUID", cGUID);
            conM.Add("cCode", cCode.Value);
            conM.Add("cName", cTitle.Value);
            conM.Add("cParent", modualCode.Value);
            DbSvr.GetDbService().Insert("Sys_SysMenu", conM);
            RefreshGrid();
        }
    }
}
