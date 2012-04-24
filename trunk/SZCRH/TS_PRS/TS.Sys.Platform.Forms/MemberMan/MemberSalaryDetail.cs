using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.PRS.MemberMan.Info;
using TS.PRS.MemberMan.Service;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Forms;
using TS.Sys.Platform.Exceptions;
using System.Data;
using TS.Sys.Util;

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberSalaryDetailForm  : BillTypeForm
    {
        private MembersSalaryService maService;
        private MemberSalaryListForm maListForm;
        private MembersSalaryInfo maInfo;
        private MembersSalarySubInfo masInfo;
        private string _referType;
        private Object[] _args;
        private String cPeriod;
        private String cTitle = "会员工资";

        internal MemberSalaryListForm MAListForm
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

        public MemberSalaryDetailForm()
        {
            InitializeComponent();
            ToolStripDropDownButton btnImportMember = new ToolStripDropDownButton();
             
            InitDefinedButton(btnImportMember);
            ToolStripItem[] items = new ToolStripItem[] { btnImportMember };
            Items = items;
            maService = new MembersSalaryService();
            maInfo = new MembersSalaryInfo();
            masInfo = new MembersSalarySubInfo();
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolItem);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", maInfo);
            con.Add("SubInfo", masInfo);
            con.Add("Service", maService);
            con.Add("SubGrid", this.gridMember);
            con.Add("BillType", "MS");
            con.Add("SumGrid", this.gridMember);
            InitForm(con);
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

         public MemberSalaryDetailForm(String action)
            :this()
        {
            InitForm();
        }

        public MemberSalaryDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex,ds);
        }

        /// <summary>
        /// 获取标题
        /// </summary>
        private void GetTitle()
        {
            
            cPeriod = "(" + this.dDate.DateTime.Value.Year + "-" + this.dDate.DateTime.Value.Month + ")";
            txtTitle.Text = cTitle + cPeriod;
        }


        private void InitDefinedButton(ToolStripDropDownButton btnMemberImport)
        {
            // 
            // btnImportMember
            // 
            ToolStripMenuItem btnAllImport = new ToolStripMenuItem();
            ToolStripMenuItem btnPlusImport = new ToolStripMenuItem();

            btnMemberImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            btnAllImport,
            btnPlusImport});

            btnMemberImport.Image = global::TS.Sys.Platform.Forms.Properties.Resources.Import;
            btnMemberImport.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnMemberImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMemberImport.Name = "btnImportSalary";
            btnMemberImport.Size = new System.Drawing.Size(60, 42);
            btnMemberImport.Text = "导入工资";
            btnMemberImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnMemberImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText; 


            // 
            // 全量导入ToolStripMenuItem
            // 
            btnAllImport.Name = "btnAllImport";
            btnAllImport.Size = new System.Drawing.Size(152, 22);
            btnAllImport.Text = "全量导入";
            btnAllImport.Click += new System.EventHandler(btnImportAllMember_Click);
            // 
            // 追加导入ToolStripMenuItem
            // 
            btnPlusImport.Name = "btnPlustImport";
            btnPlusImport.Size = new System.Drawing.Size(152, 22);
            btnPlusImport.Text = "追加导入";
            btnPlusImport.Click += new System.EventHandler(btnImportPlusMember_Click);

           
        }

        private void btnImportPlusMember_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ImportCommonMethod();

                SetGridData(dt, gridMember);

            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnImportAllMember_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ImportCommonMethod();
                gridMember.Rows.Clear();
                SetGridData(dt, gridMember);
                
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private System.Data.DataTable ImportCommonMethod()
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

            System.Data.DataTable dt = new System.Data.DataTable();
            foreach (DataGridViewColumn dgvc in this.gridMember.Columns)
            {
                if (dgvc.Visible && dgvc.CellType != typeof(DataGridViewCheckBoxCell))
                {
                    DataColumn dc = new DataColumn();
                    dc.ColumnName = dgvc.DataPropertyName;
                    dt.Columns.Add(dc);
                }
            }

            btnImportSalary(dt);
            return dt;
        }

        private void btnImportSalary(DataTable dt)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Excel文件";
            ofd.FileName = "";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "Excel文件(*.xls)|*.xls";
            ofd.ValidateNames = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            string strName = string.Empty;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strName = ofd.FileName;
            }

            if (strName == "")
            {
                MessageBox.Show("没有选择Excel文件，无法导入");
                return;
            }


            ExcelIO.ExcelToDataGridView(strName, dt);
        }

        /// <summary>
        /// 全量导入
        /// </summary>
        /// <param name="result"></param>
        /// <param name="grid"></param>
        private void SetGridData(DataTable result, DataGridView grid)
        {
            
            foreach(DataRow r in result.Rows)
            {
                Object[] colValues = r.ItemArray;
                grid.Rows.Add(colValues);
            }
             
        }

        


        /// <summary>
        /// 资料按钮事件
        /// </summary>
        private void btnInfo_Click()
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();

            Type t = tempAssembly.GetType(this._referType);
            object[] args = this._args;
            object o = System.Activator.CreateInstance(t, args);

            ((Form)o).WindowState = FormWindowState.Normal;
            ((Form)o).ShowDialog();
        }

        /// <summary>
        /// 同步更新列表信息
        /// </summary>
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
            this.maInfo = new MembersSalaryInfo();
        }
    }
}
