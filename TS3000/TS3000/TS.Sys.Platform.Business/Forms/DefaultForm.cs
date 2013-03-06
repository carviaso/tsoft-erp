using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using TS.Sys.Platform.Widgets.Refer.GridRefer; 

namespace TS.Sys.Platform.Business.Forms
{
    public partial class DefaultForm:Form
    {
        //列表数据源（翻页使用）（必填）
        protected DataGridViewRowCollection dgRowCollection;
        //单据区域（必填）
        protected TableLayoutPanel tpControl;
        //单据主表对象（必填）
        private Infos _info;
        //对象服务
        private Services _service;
        //按钮工具栏(必填)
        protected ToolStrip toolBtn;
         

        private IFormEvents formEvents;

        private TabControl _tbControl;

         
        protected int rowIndex;
        //自定义工具栏
        private ToolStripItem[] _items;
        //业务单据工具栏
        private ToolStripItem[] _businessItems;

        private ToolStripItem[] _baseItems;

        private string _referType;
        private Object[] _args;

        //按钮工具栏(必填)
        public ToolStrip ToolBtn
        {
            set { this.toolBtn = value; }
        }

        //单据区域（必填）
        public TableLayoutPanel TpControl
        {
            set { this.tpControl = value; }
        }

        /// <summary>
        /// Tab容器
        /// </summary>
        public TabControl TbControl
        {
            set { this._tbControl = value; }
        }

        /// <summary>
        /// 设置服务对象
        /// </summary>
        protected Services Service
        {
            set { this._service = value; }
            get { return this._service; }
        }

        /// <summary>
        /// 资料对象设置
        /// </summary>
        protected Infos Info
        {
            set { this._info = value; }
            get { return this._info; }
        }

        /// <summary>
        /// 初始化的时候触发
        /// </summary>
        /// <param name="con"></param>
        public void InitForm()
        {
            
            if (tpControl != null)
            {
                InitButton();
                ReferSetInfoStatus(this, btnInfo, tpControl); 
            }
        }

        /// <summary>
        /// 新增时候触发
        /// </summary>
        public void InitForm(String action)
        {
            if (action.Equals("new"))
            {
                btnNew_Click(null, null);
            }
        }

        /// <summary>
        /// 查看时候触发
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="ds"></param>
        public void InitForm(int rowindex, DataGridViewRowCollection ds)
        {
            dgRowCollection = ds;
            rowIndex = rowindex;
            if (dgRowCollection != null)
            {
                InitBillFormContent(rowIndex); 
            }

        }

        /// <summary>
        /// 自定义工具栏
        /// </summary>
        public ToolStripItem[] Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        public ToolStripItem[] BusinessItems
        {
            get { return this._businessItems; }
            set { this._businessItems = value; }
        }

        public ToolStripItem[] BaseItems
        {
            get { return this._baseItems; }
            set { this._baseItems = value; }
        }



        public IFormEvents FormEvents
        {
            get { return this.formEvents; }
            set { this.formEvents = value; }
        }

        public Object[] Args
        {
            set { this._args = value; }
        }

        public String ReferType
        {
            set { this._referType = value; }
        }
         

        /// <summary>
        /// 初始化单据
        /// </summary>
        /// <param name="rowIndex"></param>
        public virtual void InitBillFormContent(int rowIndex)
        {
            DataGridViewRow r = dgRowCollection[rowIndex];
            Object cGUID = r.Cells["cGUID"].Value;
            if (_tbControl != null)
            {
                _tbControl.TabPages[0].Text = r.Cells["cName"].Value + "的属性";
            }
            ArrayList mainResult = _service.GetMainResult(cGUID);
            if (mainResult.Count > 0)
            {
                SetMainContent(_info, (Hashtable)mainResult[0], tpControl);
            }    
        }
 

        /// <summary>
        /// 设置主表值
        /// </summary>
        /// <param name="info"></param>
        /// <param name="infoDetail"></param>
        /// <param name="tpControl"></param>
        private void SetMainContent(Object info, Hashtable infoDetail, TableLayoutPanel tpControl)
        {

            foreach (String key in infoDetail.Keys)
            {
                if (tpControl.Controls.ContainsKey(key))
                {
                    Control control = tpControl.Controls[key];
                    BusinessControl.SetComValue(control, infoDetail[key].ToString());
                    BusinessControl.SetInfoProperties(info, tpControl);
                }
            }
        }

        /// <summary>
        /// 设置参照控件的坐标变换事件
        /// </summary>
        /// <param name="tpControl"></param>
        public void ReferSetInfoStatus(Form f, ToolStripButton btn, TableLayoutPanel tpControl)
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();
            Type formType = tempAssembly.GetType("TS.Sys.Platform.Business.Forms.DefaultForm");
            Form o = (Form)System.Activator.CreateInstance(formType, null);
            foreach (Control control in tpControl.Controls)
            {
                if (control is LabelRefer)
                {
                    ((LabelRefer)control).SetInfoStatus(f, o, btn,tpControl);
                }
                
            }
        }

        /// <summary>
        /// 窗口移动事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMove(EventArgs e)
        {
            base.OnMove(e);
            if (tpControl == null)
                return;
            try
            {
                foreach (Control control in tpControl.Controls)
                {
                    if (control is LabelRefer)
                    {
                        ((LabelRefer)control).LocationChange();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

    }
}
