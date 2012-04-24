using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TS.Sys.Platform.Business.Util;
using System.Windows.Forms;
using TS.Sys.Domain;
using System.Reflection;
using System.Drawing;
using TS.Sys.Util;
using System.Collections;
using TS.Sys.Session;

namespace TS.Sys.Platform.Business.Forms
{
    partial class BillTypeForm
    { 
  
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
        /*
        void ButtonEvent(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;
            Assembly assem = Assembly.GetExecutingAssembly();
            Type t = assem.GetType("TS.Sys.Platform.Forms.BillTypeForm");
            MethodInfo mi = t.GetMethod(btn.Name, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
            //如果存在按钮
            if (mi != null)
            {
                mi.Invoke(this, null);
            }
        }*/

        private void btnNew_Click(object sender, EventArgs e)
        {
            BusinessControl.SetNewEditStatus(_toolBtn);
            BusinessControl.ClearControlValue(_tpControl);
            String code = BusinessKey.GetBusinessKey().GetBusinessCode(_billType, 3);
            BusinessControl.SetNewValue(code, _tpControl);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            //构造fi
            BusinessControl.SetInfoProperties(_mainInfo, _tpControl);
            //添加明细信息
            if (_subGrid != null)
            {
                ArrayList subList = new ArrayList();
                foreach (DataGridViewRow r in _subGrid.Rows)
                {

                    if (r.Cells[0].Value != null)
                    {
                        BusinessControl.SetSubInfoProperties(_subInfo, r);
                        subList.Add(_subInfo);
                    }

                }
                _mainInfo.SubInfos = subList;
            }

            //保存时新增还是修改
            if (_mainInfo.cGUID != null && !String.IsNullOrEmpty(_mainInfo.cGUID.ToString()))
            {
                result = _service.DoModify(_mainInfo);
            }
            else
            {
                result = _service.DoAdd(_mainInfo);
            }

            //根据保存结果处理 
            MessageBox.Show(SysConst.msgSaveSuccess);
            BusinessControl.SetSaveCancelInitStatus(_toolBtn);
            //fcForm.listRefresh();
            Type t = this.GetType();
            MethodInfo m = t.GetMethod("listRefersh");
            if (m != null)
            {
                m.Invoke(this, null);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("删除" + this.Text, SysConst.msgDeleteConfirm, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (diaResult.Equals(DialogResult.Cancel))
            {
                return;
            }
            Result result = _service.DoDel(_mainInfo);
            MessageBox.Show(SysConst.msgSaveSuccess);
            
        }

        private void btnAudit_Click(object sender, EventArgs e)
        {
            if (_tpControl == null)
                return;
            Result result = new Result();
            result = _service.DoAudit(_mainInfo);
            if (result.Code != SysConst.exeSucess)
            {
                MessageBox.Show(result.Message, SysConst.msgBoxTitle, MessageBoxButtons.OK);
            }
            else
            {
                BusinessControl.SetControlValue(_mainInfo,_tpControl);
                MessageBox.Show("单据[" + _mainInfo.cCode + "]" + SysConst.msgAuditSuccess, SysConst.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
                _tpControl.Enabled = false;
                /*BusinessControl.s
                cAuditor.Value = UserSession.UserID;
                dAuditDate.Value = UserSession.LoginDate;
                
                cTimeStamp.Value = fi.cTimeStamp;
                ;*/
            }
        }

        private void btnUnAudit_Click(object sender, EventArgs e)
        {
            Result result = new Result();
            result = _service.DoUnAudit(_mainInfo);
            if (result.Code != SysConst.exeSucess)
            {
                MessageBox.Show(result.Message, SysConst.msgBoxTitle, MessageBoxButtons.OK);
            }
            else
            {
                BusinessControl.SetControlValue(_mainInfo, _tpControl); 
                
                MessageBox.Show("单据[" + _mainInfo.cCode + "]" + SysConst.msgUnAuditSuccess, SysConst.msgBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.None);
                _tpControl.Enabled = true;
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Assembly tempAssembly = Assembly.GetExecutingAssembly();

            Type t = this.GetType();
            MethodInfo mi = t.GetMethod("btnInfo_Click",BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
            mi.Invoke(this,null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        void btnPre_Click(object sender, EventArgs e)
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

        void btnLast_Click(object sender, EventArgs e)
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

        void btnFirst_Click(object sender, EventArgs e)
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
