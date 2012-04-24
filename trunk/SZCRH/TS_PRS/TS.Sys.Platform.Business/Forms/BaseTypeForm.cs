using System;
using System.Collections;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SecuAccess;

namespace TS.Sys.Platform.Business.Forms
{
    public class BaseTypeForm:DefaultForm,IFormEvents
    {
        private BaseInfo _baseInfo;
        private AbstractBaseService _baseService;
        private ToolStripButton btnForbidden;
        private ToolStripButton btnValueable;
        private ToolStripItem[] _toolBtn;
        //数据长度
        private int _cCodeType = 3;

        public BaseTypeForm()
        {
            InitButtons();
        }

        /// <summary>
        /// 初始化Form
        /// 工具栏：toolBtn；
        /// 控件容器：tpControl；
        /// 对象：Info；
        /// 服务：Service；
        /// 编号长度：CodeType；
        /// </summary>
        /// <param name="con"></param>
        public void InitForm(Hashtable con)
        {

            base.InitForm(con);
            info = (BaseInfo)con["Info"];
            _baseInfo = (BaseInfo)con["Info"];
            service = (AbstractBaseService)con["Service"];
            _baseService = (AbstractBaseService)con["Service"];
            try
            {
                if (con["CodeType"] != null)
                {
                    _cCodeType = (int)con["CodeType"];
                }               
            }
            catch (Exception ex)
            {
                Console.WriteLine("编号长度输入错误！");
            }
            this.FormEvents = this;
        }

       private void InitButtons()
       {
           btnForbidden = new ToolStripButton();
           btnValueable = new ToolStripButton();
           _toolBtn = new ToolStripItem[]{ 
            btnForbidden,
            btnValueable};
           // 
           // btnForbidden
           // 
           this.btnForbidden.Image = global::TS.Sys.Platform.Business.Properties.Resources.Cancellation;
           this.btnForbidden.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
           this.btnForbidden.Name = "btnForbidden";
           this.btnForbidden.Size = new System.Drawing.Size(36, 42);
           this.btnForbidden.Text = "禁用";
           this.btnForbidden.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
           this.btnForbidden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
           this.btnForbidden.Click += new System.EventHandler(this.btnForbidden_Click);
           // 
           // btnValueable
           // 
           this.btnValueable.Image = global::TS.Sys.Platform.Business.Properties.Resources.unblankout;
           this.btnValueable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
           this.btnValueable.Name = "btnValueable";
           this.btnValueable.Size = new System.Drawing.Size(36, 42);
           this.btnValueable.Text = "启用";
           this.btnValueable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
           this.btnValueable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
           this.btnValueable.Click += new System.EventHandler(this.btnValueable_Click);
           BaseItems = _toolBtn;
       }

        public override void InitBillFormContent(int rowIndex)
        {
            base.InitBillFormContent(rowIndex);
        }

        public virtual void New()
        {
            
            ArrayList result = _baseService.GetMaxCode();
            int codeNumber = 1;
            if (result.Count != 0)
            {
                Hashtable code = (Hashtable)result[0];
                codeNumber = int.Parse(code["cCode"].ToString()) + 1;
            }
            _baseInfo = new BaseInfo();
            BusinessControl.SetNewValue(string.Format("{0:D"+this._cCodeType+"}", codeNumber), tpControl);
        }

        public virtual void Delete()
        {
            _baseService.DoDel(_baseInfo);
        }

        public virtual void Add()
        {
            _baseInfo = (BaseInfo)this.info;
            _baseService.DoAdd(_baseInfo);
        }

        public virtual void Modify()
        {
            _baseService.DoModify(_baseInfo);
        }

        private void btnForbidden_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnForbidden", this.FormEvents.GetType().Name);
                _baseService.DoForbidden(_baseInfo);

                BusinessControl.SetControlValue(_baseInfo, tpControl);
                Msg.Show("[" + _baseInfo.cCode + "]" + SysConst.msgForbiddenSuccess);
         
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnValueable_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnValueable", this.FormEvents.GetType().Name);
                _baseService.DoValueable(_baseInfo);

                BusinessControl.SetControlValue(_baseInfo, tpControl);
                Msg.Show("[" + _baseInfo.cCode + "]" + SysConst.msgValueableSuccess);
                 
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }
    }
}
