using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.PRS.MemberMan.Business;

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberRecommendForm : Form
    {
        private MemberReommendModual _mrModual;

        public MemberRecommendForm()
        {
            InitializeComponent();
            _mrModual = MemberReommendModual.GetInstance();
            treeMemberRecommend.SqlFetcher = _mrModual.Sql_MemberRecommend;
            treeMemberRecommend.loadTreeDataBySql("会员推荐关系");
        }
    }
}
