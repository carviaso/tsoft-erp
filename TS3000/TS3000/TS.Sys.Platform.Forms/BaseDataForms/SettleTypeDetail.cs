using System;
using System.Windows.Forms;
using TS.Sys.Platform.BaseData.Info;
using TS.Sys.Platform.BaseData.Service; 
using TS.Sys.Util;
using System.Collections;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util; 

namespace TS.Forms.BusinessForm.BS
{
    public partial class SettleTypeDetailForm : Form
    {
        private bool editFlag = false;
        private SettleTypeService stService;
        private SettleTypeInfo stInfo;
        private SettleTypeForm _stForm;
        private int _rowindex;
        private DataGridViewRowCollection _ds;

        public SettleTypeDetailForm()
        {
            InitializeComponent();
            stService = new SettleTypeService();
            
        }

        internal SettleTypeForm StForm
        {
            set { this._stForm = value; }
        }

         /// <summary>
        /// 初始化单据
        /// 获取主表内容
        /// 获取子表内容
        /// </summary>
        /// <param name="cGUID"></param>
        public SettleTypeDetailForm(int rowIndex, DataGridViewRowCollection ds)
            : this()
        {
            _rowindex = rowIndex;
            this._ds = ds;           
            InitBillFormContent(rowIndex);
        }
         
        private void InitBillFormContent(int rowIndex)
        {
             
            DataGridViewRow r = _ds[rowIndex]; 
            Object cGUID = r.Cells["cGUID"].Value;
            //ArrayList mainResult = stService.GetResultByGUID(cGUID);
            //BillForm.SetMainContent(stInfo, mainResult, tpControl);  
        }
 

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAction();
            btnSave.Enabled = false;
        }

        private void saveAction()
        {

            SettleTypeInfo st = new SettleTypeInfo();
            st.cCode = cCode.Value;
            st.cName = cName.Value;
            st.cAcctGUID = cAcctGUID.Value;
            st.iForbidden = 0;
            if (cGUID.Value != null&&String.IsNullOrEmpty((string)cGUID.Value))
            {
                st.cGUID = cGUID.Value;
                stService.Modify(st);
            }
            else
            {
                stService.Add(st);
            }
            MessageBox.Show(SysConst.msgSaveSuccess);
            _stForm.listRefresh();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BusinessControl.ClearControlValue(tpControl);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettleTypeDetailForm_FormClosing(object sender, FormClosingEventArgs e)
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
