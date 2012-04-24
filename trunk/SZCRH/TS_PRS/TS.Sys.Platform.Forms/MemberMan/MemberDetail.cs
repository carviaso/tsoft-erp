using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.PRS.MemberMan.Info;
using TS.PRS.MemberMan.Service;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.SecuAccess;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Domain;

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberDetailForm : BaseTypeForm
    {

        private MembersService memberService;
        private MemberListForm memberListForm;
        private MembersInfo bankAcctInfo; 
        private string _referType;
        private Object[] _args;


        internal MemberListForm MemberlistForm
        {
            set { this.memberListForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public MemberDetailForm()
        {
            InitializeComponent();
            this.Items =InitDefinedButton();
            memberService = new MembersService();
            bankAcctInfo = new MembersInfo();  
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolBtn);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", bankAcctInfo); 
            con.Add("Service", memberService);
            con.Add("CodeType", 5);
            InitForm(con); 
        }

        private ToolStripItem[] InitDefinedButton()
        {
            ToolStripButton btnModifyRecom = new ToolStripButton();
            btnModifyRecom.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Modify;
            btnModifyRecom.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnModifyRecom.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnModifyRecom.Name = "btnModifyRecom";
            btnModifyRecom.Size = new System.Drawing.Size(72, 42);
            btnModifyRecom.Text = "修改推荐人";
            btnModifyRecom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnModifyRecom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnModifyRecom.Click += new System.EventHandler(this.btnModifyRecom_Click);
            return  new ToolStripItem[] {btnModifyRecom};
        } 

         public MemberDetailForm(String code)
            :this()
        {
            InitForm();
            this.cCompany.Value = code;    
            this.cName.Focus();

        }

        public MemberDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
            ForbRecoMember(false);
        }

        private void btnInfo_Click()
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();

            Type t = tempAssembly.GetType(_referType);
            object[] args = _args;
            object o = System.Activator.CreateInstance(t, args);

            ((Form)o).WindowState = FormWindowState.Normal;
            ((Form)o).ShowDialog();
        }
        public override void New()
        {
            base.New();
            this.dRecommendDate.Value = DateTime.Today;
            ForbRecoMember(true);
        }

        public override void Add()
        {
            base.Add();
            ForbRecoMember(false);
        }

        public override void Modify()
        {
            base.Modify();
            ForbRecoMember(false);
        }

        /// <summary>
        /// 禁用推荐人的状态
        /// </summary>
        private void ForbRecoMember(bool flag)
        {
            this.cRecomMember.Enabled = flag;
            this.dRecommendDate.Enabled = flag;
        }

         

        private void ListRefresh()
        {
            if (memberListForm != null)
            {
                memberListForm.listRefresh();
            }
        }

        private void btnModifyRecom_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnModifyRecom", this.GetType().Name);
                ForbRecoMember(true);
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

 

    }
}
