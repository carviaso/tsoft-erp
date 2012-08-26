using System;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Platform.SecuAccess;

namespace TS.Sys.Platform.Business.Forms
{
    partial class DefaultForm
    {
        /// <summary>
        /// 新增事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                
                BusinessControl.ClearControlValue(tpControl);
                tpControl.Enabled = true;
                if (formEvents != null)
                {
                    //执行自定义新增事件
                    //考虑加入doBefore
                    formEvents.New();
                    //考虑加入doAfter();
                }
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        /// <summary>
        /// 保存事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //鉴权
                FunctionAccess.Access("btnSave", formEvents.GetType().Name);

                //校验必输项
                BusinessControl.ValidateRequire(tpControl);

                //构造fi
                BusinessControl.SetInfoProperties(info, tpControl);
                //保存时新增还是修改
                if (info.cGUID != null && !String.IsNullOrEmpty(info.cGUID.ToString()))
                {
                    if (formEvents != null)
                    {
                        //执行自定义修改事件
                        //考虑加入doBefore()
                        formEvents.Modify();
                        //考虑加入doAfter();
                    }
                }
                else
                {
                    if (formEvents != null)
                    {
                        //执行自定义修改事件
                        //考虑加入doBefore()
                        formEvents.Add();
                        //考虑加入doAfter();
                    }
                }
                BusinessControl.SetComValue(tpControl.Controls["cGUID"], info.cGUID);
                BusinessControl.SetComValue(tpControl.Controls["cTimeStamp"], info.cTimeStamp);
                //根据保存结果处理 
                Msg.Show(SysConst.msgSaveSuccess);
                BusinessControl.SetSaveCancelInitStatus(toolBtn);
                Type t = this.GetType();
                MethodInfo m = t.GetMethod("ListRefresh", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
                if (m != null)
                {
                    m.Invoke(this, null);
                }

            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionAccess.Access("btnDelete", formEvents.GetType().Name);
                DialogResult diaResult = Msg.Show("删除" + this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (diaResult.Equals(DialogResult.Cancel))
                {
                    return;
                }
                if (formEvents != null)
                {
                    //执行自定义修改事件
                    //考虑加入doBefore()
                    formEvents.Delete();
                    //考虑加入doAfter();
                }
                Msg.Show(SysConst.msgDeleteSuccess);
                btnNew_Click(sender, e);
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            Type t = this.GetType();
            MethodInfo mi = t.GetMethod("btnInfo_Click", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.ExactBinding);
            mi.Invoke(this, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (dgRowCollection == null)
            {
                Msg.Show("没有记录!");
                return;
            }
            if (rowIndex == dgRowCollection.Count - 1)
            {
                MessageBox.Show(SysConst.msgLastPage);
            }
            else
            {
                rowIndex++;
                InitBillFormContent(rowIndex);
            }
        }

        void btnPre_Click(object sender, EventArgs e)
        {
            if (dgRowCollection == null)
            {
                Msg.Show("没有记录!");
                return;
            }
            if (rowIndex == 0)
            {
                MessageBox.Show(SysConst.msgFirstPage);
            }
            else
            {
                rowIndex--;
                InitBillFormContent(rowIndex);
            }
        }

        void btnLast_Click(object sender, EventArgs e)
        {
            if (dgRowCollection == null)
            {
                Msg.Show("没有记录!");
                return;
            }
            if (rowIndex == dgRowCollection.Count - 1)
            {
                MessageBox.Show(SysConst.msgLastPage);
            }
            else
            {
                rowIndex = dgRowCollection.Count - 1;
                InitBillFormContent(rowIndex);
            }
        }

        void btnFirst_Click(object sender, EventArgs e)
        {
            if (dgRowCollection == null)
            {
                Msg.Show("没有记录!");
                return;
            }
            if (rowIndex == 0)
            {
                MessageBox.Show(SysConst.msgFirstPage);
            }
            else
            {
                rowIndex = 0;
                InitBillFormContent(rowIndex);
            }
        }
    }
}
