using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.DBLayer;
using TS.PRS.MemberMan.Info;
using System.Collections;

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberTest : Form
    {
        public MemberTest()
        {
            InitializeComponent();
        }

        private void MemberTest_Load(object sender, EventArgs e)
        {
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num.Value == null || String.IsNullOrEmpty(num.Value.ToString()))
            {
                Msg.Show("请输入人数！");
                return ;
            }
            if (cCompany.Value == null || String.IsNullOrEmpty(cCompany.Value.ToString()))
            {
                Msg.Show("请输入公司！");
                return;
            }
            int iNum = 0;
            try
            {
                iNum = int.Parse(num.Value.ToString());
                for (int i = 0; i < iNum; i++)
                {
                    MembersInfo mInfo = new MembersInfo();
                    mInfo.cGUID =  TS.Sys.Util.KeyUtil.genSimpleKey();
                    mInfo.cTimeStamp = mInfo.cGUID;
                    string sql = "select top 1 cCode from CM_Member order by cCode desc ";
                     ArrayList result = DbSvr.GetDbService().GetListResult(sql);
                     int codeNumber = 1;
                     if (result.Count != 0)
                     {
                         Hashtable code = (Hashtable)result[0];
                         codeNumber = int.Parse(code["cCode"].ToString()) + 1;
                     }
                      
                     mInfo.cId = string.Format("{0:D5}", codeNumber);
                     mInfo.dRecommendDate = DateTime.Today;
                     mInfo.cCode = string.Format("{0:D3}", codeNumber);


                     mInfo.cCompany = cCompany.Value ;
                     if (rec.Value == null || String.IsNullOrEmpty(rec.Value.ToString()))
                     {
                         mInfo.cRecomMember = "000000";
                         mInfo.cName = string.Format("{0:D3}", codeNumber);
                     }
                     else
                     {
                         mInfo.cName = rec.Value + "." + string.Format("{0:D3}", codeNumber);
                         mInfo.cRecomMember = rec.Value;
                     }
                     DbSvr.GetDbService().Insert("CM_Member", mInfo);

                     Hashtable con = new Hashtable();
                     con.Add("cGUID", mInfo.cGUID);
                     con.Add("cMemberCode", mInfo.cCode);
                     con.Add("cRecommendCode", mInfo.cRecomMember); 
                     con.Add("iYear", DateTime.Today.Year);
                     con.Add("iMonth", DateTime.Today.Month);
                     DbSvr.GetDbService().Insert("MEM_MemberRecommend", con);
                }
                Msg.Show("已添加"+iNum+"人！");
                this.Close();
            }
            catch (Exception ex)
            {
                Msg.Show("请输入有效整数");
            }
            
        }
    }
}
