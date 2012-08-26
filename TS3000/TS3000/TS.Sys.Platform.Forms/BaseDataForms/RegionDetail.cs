using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms; 

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class RegionDetailForm : BaseTypeForm
    {
        private bool editFlag = false;
        private RegionService rgService;
        private RegionInfo rgInfo;
        private RegionForm _rgForm;
        private string _referType;
        private Object[] _args; 
 

        public RegionDetailForm()
        {
            
            InitializeComponent();
            rgService = new RegionService();
            rgInfo = new RegionInfo();
            Hashtable con = new Hashtable();
            con.Add("ToolBtn", this.toolItem);
            con.Add("TpControl", this.tpControl);
            con.Add("Info", rgInfo);
            con.Add("Service", rgService);
            InitForm(con); 

            InitializeComponent();
            rgService = new RegionService();
        }

        internal RegionForm RgForm
        {
            set { this._rgForm = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public RegionDetailForm(String code)
            : this()
        {
            
            InitForm();

            rgInfo.cParent = "000000";
        }

        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public RegionDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
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

        private void ListRefresh()
        {
            _rgForm.listRefresh();
        }
    }
}
