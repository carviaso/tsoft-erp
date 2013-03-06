using System;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service;

namespace TS.Sys.Platform.BaseData.Forms
{
    public partial class MateriaClassDetailForm : Form
    {
        private int iType;
        private bool editFlag = false;
        private MateriaClassService mcService;
        private MateriaClassInfo mcInfo;
        private MateriaClassForm _ftForm;
        private int _rowindex;
        private DataGridViewRowCollection _ds;
        public MateriaClassDetailForm()
        {
            InitializeComponent();
            mcService = new MateriaClassService();
            mcInfo = new MateriaClassInfo();
            
        }

        internal MateriaClassForm FtForm
        {
            set { this._ftForm = value; }
        }

        public MateriaClassDetailForm(int iType):this()
        {
            this.iType = iType;
        }
         

        /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public MateriaClassDetailForm(int rowIndex, DataGridViewRowCollection ds, int iType)
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
            //ArrayList mainResult = mcService.GetResultByGUID(cGUID);
            //illForm.SetMainContent(mcInfo, mainResult, tpControl);  
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
            cParent.Value = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAction();
            btnSave.Enabled = false;
            _ftForm.listRefresh();
        }

        private void saveAction()
        {
            mcInfo.cCode = cCode.Value;
            mcInfo.cName = cName.Value; 
            mcInfo.iForbidden = 0;
            if (cGUID.Value != null&&!String.IsNullOrEmpty(cGUID.Value.ToString()))
            {
                mcInfo.cGUID = cGUID.Value;
                mcService.DoModify(mcInfo);
            }
            else
            {
                mcService.DoAdd(mcInfo);
            }            
            MessageBox.Show(SysConst.msgSaveSuccess);
            _ftForm.Refresh();
            
        }        

        private void cAcctGUID_KeyDown(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void MateriaClassDetailForm_FormClosing(object sender, FormClosingEventArgs e)
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
