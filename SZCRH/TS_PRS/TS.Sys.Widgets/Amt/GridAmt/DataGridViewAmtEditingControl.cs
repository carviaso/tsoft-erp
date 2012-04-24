using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.ComponentModel;
using TS.Sys.Util;

namespace TS.Sys.Widgets.Amt.GridAmt
{
    public class DataGridViewAmtEditingControl : TextBox, IDataGridViewEditingControl
    {
        protected bool valueChanged = false;
        protected DataGridView dataGridView;
        protected int rowIndex; 
        private String _preName;
        private int _iPre=2;
        private decimal _amt;
        private String _amtFormatter;

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.RightToLeft = RightToLeft.Yes;
            base.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            base.Leave += new System.EventHandler(this.textBox_Leave);
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseDown);
            base.BorderStyle = BorderStyle.None;
            
            //throw new NotImplementedException();
        }
        //重写基类
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            NotifyDataGridViewOfValueChange();
        }

        //  当text值发生变化时，通知DataGridView
        private void NotifyDataGridViewOfValueChange()
        {
            valueChanged = true;
            dataGridView.NotifyCurrentCellDirty(true);
        }

        /// <summary>
        /// 获取或设置格式化后的值
        /// </summary>
        public object EditingControlFormattedValue
        {
            set
            {
                Text = value.ToString();
                NotifyDataGridViewOfValueChange();
            }
            get
            {
                return this.Text;
            }

        }
         

        /// <summary>
        /// 获取或设置所在的DataGridView
        /// </summary>
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }

            set
            {
                dataGridView = value;
            }
        }

        /// <summary>
        /// 控件所在行
        /// </summary>
        public int EditingControlRowIndex
        {
            get
            {
                return this.rowIndex;
            }

            set
            {
                this.rowIndex = value;
            }
        }

        /// <summary>
        /// 获取控件的Text值
        /// </summary>
        /// <param name="context">错误上下文</param>
        /// <returns></returns>
        public virtual object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            /*String test = FormatAMT(Text);
            return FormatAMT(Text);
            if (_amt == 0&&!String.IsNullOrEmpty(Text))
            {
                _amt = Decimal.Parse(NumberUtil.GetAmt(Text).ToString());
            }*/
            return Text;
        }
       
        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            //throw new NotImplementedException();
            return true;
        }

        public Cursor EditingPanelCursor
        {
            get { return Cursors.IBeam; }
        }
 

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            //throw new NotImplementedException();
            
        }

        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 是否值发生了变化
        /// </summary>
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }

            set
            {
                this.valueChanged = value;
            }
        }

        public Object Amt
        {
            get { return this._amt; }
        }

        /// <summary>
        /// 
        /// 对数值进行校验，并格式化
        /// </summary>
        private void FormatAMT(Object amtIn)
        {
            try
            {

                Decimal amt = Decimal.Parse(amtIn.ToString().Trim());
                amt = Math.Round(amt, this._iPre);
                _amt = amt;
                String pre1 = "";
                String pre2 = "";
                String precision = "￥";
                for (int i = 0; i < this._iPre; i++)
                {
                    pre1 += "#";
                    pre2 += "0";
                }
                _amtFormatter = "0." + pre2 + ";";
                precision += "#," + pre1 + _amtFormatter;
                Text = amt.ToString(precision + "-" + precision + "");
                

            }
            catch (FormatException ex)
            {
                String test = ex.ToString();      
            }

        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            FormatAMT(base.Text.Trim());
        }

        /// <summary>
        /// 焦点获取时，获得该控件数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            //Text = this._amt.ToString();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int key = e.KeyChar;
            if (key == 8 || key == 46)
            {
                if (Text.Contains('.'))
                {
                    e.Handled = true; 
                    return;
                }
                else
                {
                    return;
                }
            }
            if (key <= 32) // 特殊键(含空格), 不处理 
            { e.Handled = true; return; }
            if (!char.IsDigit(e.KeyChar)) // 非数字键, 放弃该输入 
            { e.Handled = true; return; } 

        }

        


        
    }
}
