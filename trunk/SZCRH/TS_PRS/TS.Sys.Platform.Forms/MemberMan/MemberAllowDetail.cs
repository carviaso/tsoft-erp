using System;
using System.Collections;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using TS.PRS.MemberMan.Business;
using TS.PRS.MemberMan.Info;
using TS.PRS.MemberMan.Service;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Exceptions;

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberAllowDetailForm : BillTypeForm
    {
        private MembersAllowService maService;
        private MemberAllowListForm maListForm;
        private MembersAllowInfo maInfo;
        private MembersAllowSubInfo masInfo;
        private string _referType;
        private Object[] _args;
        private String cPeriod;
        private String cTitle = "会员津贴";
        private MemberReommendModual _mr;
        //人员增长幅度
        private int memberNumAdd = 20;
        //会员津贴增长额度
        private int allowPercent = 5;
        //津贴起始额度
        private int allowInit = 10;
        //人员最大值
        private int memberNumMax = 50;

        public int MemberNewAdd
        {
            get { return this.memberNumAdd; }
            set { this.memberNumAdd = value; }
        }

        public int AllowPercent
        {
            get { return this.allowPercent; }
            set { this.allowPercent = value; }
        }

        public int AllowInit
        {
            get { return this.allowInit; }
            set { this.allowInit = value; }
        }

        public int MemberNumMax
        {
            get { return this.memberNumMax; }
            set { this.memberNumMax = value; }
        }

        internal MemberAllowListForm MAListForm
        {
            set { this.maListForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public MemberAllowDetailForm()
        {  
            InitializeComponent();
            ToolStripButton btnImportMember = new ToolStripButton();
            InitDefinedButton(btnImportMember);
            ToolStripItem[] items = new ToolStripItem[] { btnImportMember };
            Items = items;
            maService = new MembersAllowService();
            maInfo = new MembersAllowInfo();
            masInfo = new MembersAllowSubInfo(); 
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolItem);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", maInfo);
            con.Add("SubInfo", masInfo);
            con.Add("Service", maService);
            con.Add("SubGrid", this.gridMember);
            con.Add("BillType", "ME");
            con.Add("SumGrid", this.gridMember);
            InitForm(con);
            _mr = MemberReommendModual.GetInstance();
            InitBillData();
            
             
        }

        /// <summary>
        /// 初始化单据中的数据
        /// </summary>
        private void InitBillData()
        {
            //初始化单据时间
            this.dDate.Value = DateTime.Today;
            //初始化标题
            GetTitle();
        }

        private void GetTitle()
        {
            cPeriod = "(" + this.dDate.DateTime.Value.Year + "-" + this.dDate.DateTime.Value.Month + ")";
            txtTitle.Text = cTitle + cPeriod;
        }

        /// <summary>
        /// 初始化按钮
        /// </summary>
        /// <param name="btnMemberImport"></param>
        private void InitDefinedButton(ToolStripButton btnMemberImport)
        {
            // 
            // btnImportMember
            // 
            btnMemberImport.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Import;
            btnMemberImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnMemberImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMemberImport.Name = "btnImportMember";
            btnMemberImport.Size = new System.Drawing.Size(60, 42);
            btnMemberImport.Text = "导入会员";
            btnMemberImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnMemberImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnMemberImport.Click += new System.EventHandler(btnImportMember_Click);
        }

        public MemberAllowDetailForm(String action)
            :this()
        {
            InitForm();
        }

        public MemberAllowDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex,ds);
        }

        private void btnInfo_Click()
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();

            Type t = tempAssembly.GetType(this._referType);
            object[] args = this._args;
            object o = System.Activator.CreateInstance(t, args);

            ((Form)o).WindowState = FormWindowState.Normal;
            ((Form)o).ShowDialog();
        }

        private void ListRefresh()
        {
            if (maListForm != null)
            {
                maListForm.listRefresh();
            }
        }

        public override void New()
        {
            base.New();
            this.maInfo = new MembersAllowInfo(); 
        }

        private void btnImportMember_Click(object sender, EventArgs e)
        {
            try
            {
                Hashtable con = new Hashtable();
                int iYear = this.dDate.DateTime.Value.Year;
                int iMonth = this.dDate.DateTime.Value.Month;
                con.Add("iYear", iYear);
                con.Add("iMonth", iMonth);
                //非新增的时候，点击导入需要校验
                if (maInfo.cGUID != null)
                {
                    maService.ValidataForAudit(maInfo);
                }
                ArrayList dt = maService.ImportAllowMembers(con);

                if (dt.Count == 0)
                {
                    Msg.Show("没有符合条件的会员");
                }
                else
                {
                    SetGridData(dt, gridMember);
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private  void SetGridData(ArrayList result, DataGridView grid)
        {
            grid.Rows.Clear();
            
            Decimal allowSum = new Decimal(0);
            for (int i = 0; i < result.Count; i++)
            {
                Hashtable detail = (Hashtable)result[i];
                int recNum = (int)detail["iRecNum"];
                object MemberCode = detail["cMemberCode"];
                Hashtable allowDetail = CaculateAllow(recNum, MemberCode);
                Decimal allow = (Decimal)allowDetail["Allow"];//津贴金额
                int num = (int)allowDetail["TeamNum"];//团队人数
                allowSum += allow;
                Object[] cellValues = new Object[detail.Count+2];
                int index = 0;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (col.Name.Equals("iTeamNum"))
                    {                       
                        cellValues[index] = num;
                        index++;
                    }
                    else if (col.Name.Equals("iMemberAllow"))
                    {
                        if (allowDetail != null)
                        {
                            cellValues[index] = allow;
                            index++;
                        }
                        else
                        {
                            cellValues[index] = 0;
                            index++;
                        }
                        
                    }
                    else if (detail[col.Name] != null)
                    {
                        Object value = detail[col.Name];
                        cellValues[index] = value;
                        index++;
                    }
                } 
                grid.Rows.Add(cellValues);

            }
            this.iAllowSum.Value = allowSum;
            this.iMemberNum.Value = result.Count;
        }


        /// <summary>
        /// 计算团队奖金
        /// 10-19:10%
        /// 20-29:15%
        /// 30-39:20%
        /// 40-49:25%
        /// </summary>
        /// <returns></returns>
        private Decimal CaculateTearmAllow(int AllowSum, int teamNum)
        {
            Decimal sum = new Decimal(0);
            if (teamNum < 10)
            {
                sum = AllowSum;
            }
            else if (teamNum >= 10 && teamNum <= 29)
            {
                sum = Decimal.Parse((AllowSum*(1+0.1)).ToString());
            }
            else if (teamNum >= 30 && teamNum <= 49)
            {
                sum = Decimal.Parse((AllowSum * (1 + 0.15)).ToString());
            }
            else if (teamNum >= 50)
            {
                sum = Decimal.Parse((AllowSum * (1 + 0.2)).ToString());
            }
            return sum;          

        }

        /// <summary>
        /// 计算会员津贴
        /// 公式：基本津贴*推荐人数+团队奖金
        /// 说明：团队人数只算在职人员的数目，一个人离职了，那么他得团队中需要有一个人顶替他原来的位置。
        /// </summary>
        /// <param name="baseAllow"></param>
        /// <param name="MemberCode"></param>
        /// <returns></returns>
        private Hashtable CaculateAllow(int recNum,object MemberCode)
        {
            Hashtable result = new Hashtable(); 
            try
            {
                //Hashtable teamInfo = CaculateTearmAllow(MemberCode);
                //int teamNum = (int)teamInfo["TeamNum"];
                int teamNum = _mr.GetMemberTeam(MemberCode);//计算团队人数
                if (teamNum < recNum)
                {
                    recNum = teamNum;
                }
                int AllowSum = _mr.BaseAllowCo * recNum;//总奖金
                Decimal allow = CaculateTearmAllow(AllowSum,teamNum);//计算奖励奖金
                //sum = AllowSum + allow;
                result.Add("TeamNum",teamNum);
                result.Add("Allow", allow);
                //设置团队人数 
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void dDate_ValueChanged(object sender, EventArgs e)
        {
            GetTitle();
            ClearGrid();
        }

        private void ClearGrid()
        {
            this.gridMember.Rows.Clear();
        }
 
 
    }
}
