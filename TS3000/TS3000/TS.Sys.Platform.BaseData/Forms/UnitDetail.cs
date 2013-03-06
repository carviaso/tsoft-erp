using System;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.BaseData.Forms
{
    public partial class UnitDetailForm : BaseTypeForm
    {
        private bool editFlag = false;
        private UnitService unService;
        private UnitInfo unInfo;
        private UnitForm _unForm;
        private string _referType;
        private Object[] _auns; 
 

        public UnitDetailForm()
        {
            
            InitializeComponent();
            unService = new UnitService();
            unInfo = new UnitInfo();
            this.ToolBtn=this.toolItem;
            this.TpControl=this.tpControl;
            this.Info=unInfo;
            this.BaseService=unService;
            InitForm(); 
        }

        internal UnitForm UnForm
        {
            set { this._unForm = value; }
        }

        public Object[] Auns
        {
            set { this._auns = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public UnitDetailForm(String code)
            : this()
        {
            
            InitForm("new");

            unInfo.cParent = "000000";
        }

        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public UnitDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
        }

        private void ListRefresh()
        {
            _unForm.listRefresh();
        }
    }
}
