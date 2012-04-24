using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;

namespace TS.Sys.Platform.Forms.BaseDataForms
{
    public partial class FaTypeDetailForm : Form
    {
        private int iType;
        private bool editFlag = false;
        private FaTypeService ftService;
        private FaTypeInfo ftInfo;
        private FaTypeForm _ftForm;
        private int _rowindex;
        private DataGridViewRowCollection _ds;
        public FaTypeDetailForm()
        {
            InitializeComponent();
            ftService = new FaTypeService();
            ftInfo = new FaTypeInfo();
            
        }

        internal FaTypeForm FtForm
        {
            set { this._ftForm = value; }
        }

        public FaTypeDetailForm(int iType):this()
        {
            this.iType = iType;
        }
         

        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public FaTypeDetailForm(int rowIndex, DataGridViewRowCollection ds, int iType)
            : this(iType)
        {
            _rowindex = rowIndex;
            this._ds = ds;           
            InitBillFormContent(rowIndex);
        }
         
        private void InitBillFormContent(int rowIndex)
        {
             
            DataGridViewRow r = _ds[rowIndex]; 
            Object cGUID = r.Cells["cGUID"].Value;
            //ArrayList mainResult = ftService.GetResultByGUID(cGUID);
            //illForm.SetMainContent(ftInfo, mainResult, tpControl);  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
         
              

        private void btnNew_Click(object sender, EventArgs e)
        {
            cGUID.Text = null;
            cCode.Value = null;
            cName.Value = null;
            cAcctCode.Value = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAction();
            btnSave.Enabled = false;
            _ftForm.listRefresh();
        }

        private void saveAction()
        {
            ftInfo.cCode = cCode.Value;
            ftInfo.cName = cName.Value;
            ftInfo.cFullName = cName.Value;
            ftInfo.cAcctCode = cAcctCode.Value;
            ftInfo.iType = iType;
            ftInfo.iForbidden = 0;
            if (cGUID.Value != null&&!String.IsNullOrEmpty(cGUID.Value.ToString()))
            {
                ftInfo.cGUID = cGUID.Value;
                ftService.DoModify(ftInfo);
            }
            else
            {
                ftService.DoAdd(ftInfo);
            }            
            MessageBox.Show(SysConst.msgSaveSuccess);
            _ftForm.Refresh();
            
        }        

        private void cAcctGUID_KeyDown(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void FaTypeDetailForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (editFlag)
            {
                DialogResult result = MessageBox.Show(SysConst.msgDataChange, SysConst.msgBoxTitle, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    e.Cancel = false;  //点击OK  
                }
                else if (result == DialogResult.No)
                {
                    editFlag = false;
                    btnExit_Click(sender, e);
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_rowindex == _ds.Count - 1)
            {
                MessageBox.Show(SysConst.msgLastPage);
            }
            else
            {
                _rowindex++;
                InitBillFormContent(_rowindex);
            }
        }


        private void btnPre_Click(object sender, EventArgs e)
        {
            if (_rowindex == 0)
            {
                MessageBox.Show(SysConst.msgFirstPage);
            }
            else
            {
                _rowindex--;
                InitBillFormContent(_rowindex);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_rowindex == _ds.Count - 1)
            {
                MessageBox.Show(SysConst.msgLastPage);
            }
            else
            {
                _rowindex = _ds.Count - 1;
                InitBillFormContent(_rowindex);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_rowindex == 0)
            {
                MessageBox.Show(SysConst.msgFirstPage);
            }
            else
            {
                _rowindex = 0;
                InitBillFormContent(_rowindex);
            }
        }
    }
}
