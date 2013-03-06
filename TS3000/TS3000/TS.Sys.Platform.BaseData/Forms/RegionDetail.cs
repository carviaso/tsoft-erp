using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.BaseData.Forms
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
            this.ToolBtn=this.toolItem;
            this.TpControl=this.tpControl;
            this.Info=rgInfo;
            this.Service=rgService;
            InitForm(); 

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
            
            InitForm("new");

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


        private void ListRefresh()
        {
            _rgForm.listRefresh();
        }
    }
}
