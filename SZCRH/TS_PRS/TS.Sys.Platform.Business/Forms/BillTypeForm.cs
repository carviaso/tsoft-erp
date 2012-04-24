using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Info;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Util;
using TS.Sys.Platform.SecuAccess;
using TS.Sys.Session;

namespace TS.Sys.Platform.Business.Forms
{
    public partial class BillTypeForm:DefaultForm,IFormEvents
    {

        private BusinessMainInfo _mainInfo;
        private AbstractBusinessService _businessService;
      
        //单据子表对象
        private BusinessSubInfo _subInfo;        
        //子表
        private DataGridView _subGrid;

        private DataGridView _sumGrid;

        private IFormPointCut _formPoint;

        private string _billType;


        public IFormPointCut FormPoint
        {
            set { this._formPoint = value; }
        }

        public BillTypeForm()
        {
            InitButton(); 
        }
                
        /// <summary>
        /// 初始化Form
        /// 需要构造参数
        /// ToolBtn，TpControl，MainInfo，Service，SubGrid
        /// </summary>
        /// <param name="con"></param>
        public void InitForm(Hashtable con)
        {
            base.InitForm(con);
            if (con["Info"] == null)
            {
                throw new BusinessException("MainInfo属性未设置");
            }
            if (con["Service"] == null)
            {
                throw new BusinessException("Service属性未设置");
            }
            if (con["SubGrid"] == null)
            {
                throw new BusinessException("SubGrid属性未设置");
            }
            else if (con["BillType"] == null)
            {
                throw new BusinessException("BillType属性未设置");
            }
            info = (BusinessMainInfo)con["Info"];
            service = (AbstractBusinessService)con["Service"];
            _businessService = (AbstractBusinessService)con["Service"];
            _mainInfo = (BusinessMainInfo)con["Info"];
            _subInfo = (BusinessSubInfo)con["SubInfo"];
            _subGrid = (DataGridView)con["SubGrid"];
            _sumGrid  = (DataGridView)con["SumGrid"];
            _billType = con["BillType"].ToString();
            this.FormEvents = this;
            //如果有子表则添加子表的事件
            if (_subGrid != null)
            {
                BindGridEvent();
            }

        }

        /// <summary>
        /// 新增时候触发
        /// </summary>
        public void InitForm()
        {
            base.InitForm();
        }

        /// <summary>
        /// 查看时候触发
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="ds"></param>
        public void InitForm(int rowIndex, DataGridViewRowCollection ds)
        {
            base.InitForm(rowIndex,ds);            
        }

        /// <summary>
        /// 列表事件绑定
        /// </summary>
        private void BindGridEvent()
        {
            _subGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(datagrid_RowPostPaint);
            _subGrid.CellPainting += new DataGridViewCellPaintingEventHandler(datagrid_CellPainting); 
        } 

        /// <summary>
        /// 初始化单据
        /// </summary>
        /// <param name="rowIndex"></param>
        public override void  InitBillFormContent(int rowIndex)
        {
            base.InitBillFormContent(rowIndex);
            DataGridViewRow r = dgRowCollection[rowIndex];
            Object cGUID = r.Cells["cGUID"].Value;
            //如果存在子表信息，给子表赋值
            if (_subGrid != null)
            {
                ArrayList subResult = _businessService.GetSubResult(cGUID);
                if (_sumGrid != null)
                {
                    _sumGrid.Rows.Clear();
                }
                SetSubContent(subResult, _subGrid);
                tpControl.GetNextControl(_sumGrid, true);
            }
            tpControl.Enabled = (_mainInfo.cAuditor == null);
            //数据装载后执行
            if (_formPoint != null)
            {
                _formPoint.doAfterLoad();
            }
        }       

        
        /// <summary>
        /// 设置子表值
        /// </summary>
        /// <param name="resultSub"></param>
        /// <param name="grid"></param>
        private  void SetSubContent(ArrayList result, DataGridView grid)
        {
            grid.Rows.Clear();
            for (int i = 0; i < result.Count; i++)
            {
                Hashtable detail = (Hashtable)result[i];
                Object[] cellValues = new Object[detail.Count];
                int index = 0;
                foreach (DataGridViewColumn col in grid.Columns)
                {
                    if (detail[col.Name] != null)
                    {
                        Object value = detail[col.Name];
                        cellValues[index] = value;
                        index++;
                    }
                } 
                grid.Rows.Add(cellValues);
                
            }
        }

        private ToolStripButton btnAudit;
        private ToolStripButton btnUnAudit;
        private ToolStripItem[] _toolBtn;
        private void InitButton()
        {
            btnAudit = new System.Windows.Forms.ToolStripButton();
            btnUnAudit = new System.Windows.Forms.ToolStripButton();
            _toolBtn = new ToolStripItem[]{ 
            btnAudit,
            btnUnAudit};

            // 
            // btnAudit
            // 
            btnAudit.Image = global::TS.Sys.Platform.Business.Properties.Resources.auditor;
            btnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnAudit.Name = "btnAudit";
            btnAudit.Size = new System.Drawing.Size(36, 42);
            btnAudit.Text = "审核";
            btnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnAudit.Click += new EventHandler(btnAudit_Click);
            // 
            // btnUnAudit
            // 
            btnUnAudit.Image = global::TS.Sys.Platform.Business.Properties.Resources.unauditor;
            btnUnAudit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnUnAudit.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnUnAudit.Name = "btnUnAudit";
            btnUnAudit.Size = new System.Drawing.Size(48, 42);
            btnUnAudit.Text = "反审核";
            btnUnAudit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnUnAudit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnUnAudit.Click += new EventHandler(btnUnAudit_Click);
            BusinessItems = _toolBtn;

        }

        /// <summary>
        /// 绘制行数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.RowHeadersVisible)
            {
                Rectangle rect = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height);
                rect.Inflate(-2, -2);
                TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, rect, e.InheritedRowStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
            }
        }

        /// <summary>
        /// 数字列右对齐，否则左对齐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datagrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            //假设vista()方法是验证是否为数字的
            if (e.RowIndex != -1 && e.ColumnIndex == 1)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            else if (e.RowIndex != -1 && e.ColumnIndex != 1)
            {
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

        }

        public virtual void New()
        {
            String code = BusinessKey.GetBusinessKey().GetBusinessCode(_billType, 3);
            BusinessControl.SetComValue(tpControl.Controls["cCode"], code);
            BusinessControl.SetComValue(tpControl.Controls["dDate"],DateTime.Today);
            BusinessControl.SetComValue(tpControl.Controls["cCreator"],UserSession.UserID); 
            if (_subGrid != null)
            {
                _subGrid.Rows.Clear();
            }
            if (_sumGrid != null)
            {
                _sumGrid.Rows.Clear();
            }
        }

        public virtual void Add()
        {
            _mainInfo = (BusinessMainInfo)this.info;
            //添加明细信息
            if (_subGrid != null)
            {
                GetSubInfo();
            }
            
            _businessService.DoAdd(_mainInfo);
            

        }

        public virtual void Modify()
        {

            if (_subGrid != null)
            {
                GetSubInfo();
            }
            _businessService.DoModify(_mainInfo);

        }

        private void GetSubInfo()
        {
            //_mainInfo.SubInfos = null;
            ArrayList subList = new ArrayList();
            foreach (DataGridViewRow r in _subGrid.Rows)
            {

                if (r.Cells[0].Value != null)
                {
                    Hashtable subHash = BusinessControl.SetSubInfoProperties(_subInfo, r);
                    subList.Add(subHash);
                }

            }
            _mainInfo.SubInfos = subList;
        }

        public virtual void Delete()
        {

            _businessService.DoDel(_mainInfo);

        }

        public virtual void Audit()
        {
            _businessService.DoAudit(_mainInfo);
        }

        public virtual void UnAudit()
        {
            _businessService.DoUnAudit(_mainInfo);
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnAudit", this.FormEvents.GetType().Name);
                Audit();

                BusinessControl.SetControlValue(_mainInfo, tpControl);
                Msg.Show("[" + _mainInfo.cCode + "]" + SysConst.msgAuditSuccess);
                tpControl.Enabled = false;
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnUnAudit_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnUnAudit", this.FormEvents.GetType().Name);
                UnAudit();
                BusinessControl.SetControlValue(_mainInfo, tpControl);

                Msg.Show("[" + _mainInfo.cCode + "]" + SysConst.msgUnAuditSuccess);
                tpControl.Enabled = true;
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }

        }
    }
}
