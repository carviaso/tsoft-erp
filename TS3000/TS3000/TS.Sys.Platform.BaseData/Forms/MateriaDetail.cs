using System;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;
using TS.Sys.Platform.Business.Forms;

namespace TS.Sys.Platform.BaseData.Forms
{
    public partial class MateriaDetailForm : BaseTypeForm
    {
        private MateriaService matService;
        private MateriaInfo matInfo;
        private MateriaForm matForm;
        private string _referType;
        private Object[] _args;


        internal MateriaForm MatForm
        {
            set { this.matForm = value; }
        }

        internal String cRegionValue
        {
            get { return this.cParent.Value.ToString(); }
            set
            {
                if (!String.IsNullOrEmpty(value) && !value.Equals("000000"))
                { this.cParent.Value = value; }
            }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }

        public MateriaDetailForm()
        {
            InitializeComponent();
            matService = new MateriaService();
            matInfo = new MateriaInfo();  
            this.ToolBtn=this.toolItem;
            this.TpControl=this.tpControl;
            this.TbControl=this.tbControl;
            this.Info=matInfo; 
            this.BaseService=matService;  
            InitForm();
        }

        /// <summary>
        /// 传入区域编号
        /// </summary>
        /// <param name="code"></param>
        public MateriaDetailForm(String code)
            :this()
        {
            InitForm("new");
            this.cParent.Value = code;       

        }

        public MateriaDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            InitForm(rowIndex, ds);
        }
         

        private void ListRefresh()
        {
            matForm.listRefresh(); 
        }

        private void cFullName_Load(object sender, EventArgs e)
        {

        }
    
    }
}
