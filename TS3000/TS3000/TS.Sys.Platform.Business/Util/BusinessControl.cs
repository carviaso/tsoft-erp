using System;
using System.Collections;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.Widgets;
using TS.Sys.Platform.Widgets.Money.GridMoney;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using TS.Sys.Util;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Session; 

namespace TS.Sys.Platform.Business.Util
{
    public class BusinessControl
    {
        /// <summary>
        /// 通过返回值设置对象
        /// </summary>
        /// <param name="info"></param>
        /// <param name="detail"></param>
        public static void SetInfoByResult(object info, Hashtable detail)
        {
            Type t = info.GetType();
            foreach (DictionaryEntry item in detail)
            {
                PropertyInfo pi = t.GetProperty(item.Key.ToString());
                if ( pi!= null)
                {
                    pi.SetValue(info, item.Value.ToString(), null);
                    
                }
            }
        }

        public static void SetInfoNull(Object info)
        {
            Type t = info.GetType();
            PropertyInfo[] pis = t.GetProperties();
            foreach (PropertyInfo pi in pis)
            {
                pi.SetValue(info,null,null);
            }
        }

        /// <summary>
        /// 通过所选的行设置对象
        /// </summary>
        /// <param name="info"></param>
        /// <param name="rowIndex"></param>
        /// <param name="grid"></param>
        public static void SetInfoByGrid(object info,DataGridView grid)
        {
            Type t = info.GetType();
            DataGridViewRow row = grid.SelectedRows[0];
            foreach (DataGridViewCell cell in row.Cells)
            {
                PropertyInfo pi = t.GetProperty(grid.Columns[cell.ColumnIndex].Name);
                if (pi != null)
                {
                    pi.SetValue(info,cell.Value, null);

                }
            }
        }

        /// <summary>
        /// 通过容器中得控件设置对象
        /// </summary>
        /// <param name="info"></param>
        /// <param name="tpControl"></param>
        public static void SetInfoProperties(object info, TableLayoutPanel tpControl)
        {
            Type t = info.GetType();
            foreach (Control c in tpControl.Controls)
            {
                Object value = BusinessControl.GetComValue(c);
                if (!(c is DataGridView))
                {
                    PropertyInfo pi = t.GetProperty(c.Name);
                    if (pi == null)
                    {
                        continue;
                    }
                    if (value != null && String.IsNullOrEmpty(value.ToString()))
                    {
                        value = null;
                    }
                    pi.SetValue(info, value, null);
                }

            }
        }
        /// <summary>
        /// 通过容器中得控件设置对象
        /// </summary>
        /// <param name="info"></param>
        /// <param name="tpControl"></param>
        public static void SetInfoProperties(object info, DataGridViewRow row)
        {
            Type t = info.GetType();
            foreach (DataGridViewCell cell in row.Cells)
            {
                Object value = new Object();
                if (cell.OwningColumn is DataGridViewMoneyColumn)
                {
                    value = NumberUtil.GetAmt(cell.FormattedValue.ToString());
                }
                else
                {
                    value = cell.Value;
                }
                PropertyInfo pi = t.GetProperty(cell.OwningColumn.Name);
                if (pi == null)
                {
                    continue;
                }
                pi.SetValue(info, value, null);
            } 
        }


        /// <summary>
        /// 通过容器中得控件设置对象
        /// </summary>
        /// <param name="info"></param>
        /// <param name="tpControl"></param>
        public static Hashtable SetSubInfoProperties(object info, DataGridViewRow row)
        {
            Type t = info.GetType();
            Hashtable con = new Hashtable();
            foreach (DataGridViewCell cell in row.Cells)
            {
                Object value = new Object();
                if (cell.OwningColumn is DataGridViewMoneyColumn)
                {
                    value = NumberUtil.GetAmt(cell.FormattedValue.ToString());
                }
                else
                {
                    value = cell.Value;
                }
                PropertyInfo pi = t.GetProperty(cell.OwningColumn.Name);
                if (pi == null)
                {
                    continue;
                }
                con.Add(cell.OwningColumn.Name,value);
            }
            return con;
        }

        public static void SetEditInfoProperties(object info, TableLayoutPanel tpControl)
        {
            Type t = info.GetType();
            foreach (Control c in tpControl.Controls)
            {
                if (c.Name != "cGUID")
                {
                    t.GetProperty(c.Name).SetValue(info, BusinessControl.GetComValue(c), null);
                }
            }
        }

        /// <summary>
        /// 获取相应的控件值
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static Object GetComValue(Control control)
        {
            Object value = null;
            if (control is LabelCombox)
            {
                value = ((LabelCombox)control).Value;
                /*if (value != null)
                {
                    value = ((DataRowView)value).Row["Code"];
                }*/
             }
            else if (control is LabelEdit)
            {
                value = ((LabelEdit)control).Value;
            }
            else if (control is LabelRefer)
            {
                value = ((LabelRefer)control).Value;
            }
            else if (control is LabelDateTime)
            {
                value = ((LabelDateTime)control).Value;
            }
            else if (control is CheckBox)
            {
                if (((CheckBox)control).Checked)
                {
                    value = "y";
                }
                else
                {
                    value = "n";
                }
            }
            return value;
        }

        /// <summary>
        /// 获取相应的控件值
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        public static void SetComValue(Control control, Object value)
        {

            if (control is LabelCombox)
            {
                //((DataRowView)value).Row["Code"] =value; 
                ((LabelCombox)control).Value = value;
            }
            else if (control is LabelEdit)
            {
                ((LabelEdit)control).Value = value;
            }
            else if (control is LabelRefer)
            {
                ((LabelRefer)control).Value = value;
            }
            else if (control is LabelDateTime)
            {
                ((LabelDateTime)control).Value = value;
            }
            else if (control is CheckBox)
            {
                if ("y" == value.ToString())
                {
                    ((CheckBox)control).Checked = true;
                }
                else if ("n" == value.ToString())
                {
                    ((CheckBox)control).Checked = false;
                }
            }
  
        }

        public static void ClearControlValue(TableLayoutPanel panel)
        {
            foreach(Control c  in panel.Controls)
            {
                SetComValue(c, null);
            }
        }

        /// <summary>
        /// 
        /// 新增时候，对编号赋值
        /// </summary>
        /// <param name="value"></param>
        /// <param name="panel"></param>
        public static void SetNewValue(Object value, TableLayoutPanel panel)
        {
            if (panel.Controls["cCode"] != null)
            {
                Control c = panel.Controls["cCode"];
                SetComValue(c, value);
            }
            if (panel.Controls["cCreator"] != null)
            {
                Control c = panel.Controls["cCreator"];
                SetComValue(c, value);
            }
        }

        /// <summary>
        /// 
        /// 保存的时候，赋值cGUID,cTimeStamp
        /// </summary>
        /// <param name="value"></param>
        /// <param name="panel"></param>
        public static void SetSaveValue(Object value, TableLayoutPanel panel)
        {
            if (panel.Controls["cGUID"] != null)
            {
                Control c = panel.Controls["cCode"];
                SetComValue(c, value);
            }
            if (panel.Controls["cTimeStamp"] != null)
            {
                Control c = panel.Controls["cCreator"];
                SetComValue(c, value);
            }
        }
        
        public static void ValidateRequire(TableLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is LabelCombox)
                {
                     
                    if (((LabelCombox)control).IsRequire)
                    {
                        if (((LabelCombox)control).Value == null || String.IsNullOrEmpty(((LabelCombox)control).Value.ToString()))
                        {
                            throw new BusinessException(((LabelCombox)control).Label+"为必输项！");
                        }
                    }
                }
                else if (control is LabelEdit)
                {
                    if (((LabelEdit)control).IsRequire)
                    {
                        if (((LabelEdit)control).Value == null || String.IsNullOrEmpty(((LabelEdit)control).Value.ToString()))
                        {
                            throw new BusinessException(((LabelEdit)control).Label + "为必输项！");
                        }
                    }
                }
                else if (control is LabelRefer)
                {
                    if (((LabelRefer)control).IsRequire)
                    {
                        if (((LabelRefer)control).Value == null || String.IsNullOrEmpty(((LabelRefer)control).Value.ToString()))
                        {
                            throw new BusinessException(((LabelRefer)control).Label + "为必输项！");
                        }
                    }
                }
                else if (control is LabelDateTime)
                {
                    if (((LabelDateTime)control).IsRequire)
                    {
                        if (((LabelDateTime)control).Value == null || String.IsNullOrEmpty(((LabelDateTime)control).Value.ToString()))
                        {
                            throw new BusinessException(((LabelDateTime)control).Label + "为必输项！");
                        }
                    }
                }
                 
            }
        }


        public static void SetControlValue(Object info, TableLayoutPanel panel)
        {
            Type type = info.GetType();
            foreach (Control c in panel.Controls)
            {
                //info.;
                String name = c.Name;
                PropertyInfo pi = type.GetProperty(name);
                if (pi != null)
                {
                    //MethodInfo m = type.GetMethod(name);
                    Object value = pi.GetValue(info, null);
                    //GetComValue(c);
                    SetComValue(c, value);
                }
            }
        }

        
        /// <summary>
        /// 设置点击保存后的状态改变
        /// btnSave:不可用
        /// btnEdit:可用
        /// btnDel:可用
        /// btnNew:可用
        /// btnCancel:不可用
        /// </summary>
        /// <param name="tool">按钮所在容器</param>
        public static void SetSaveCancelInitStatus(ToolStrip tool)
        {
            
            foreach (ToolStripItem control in tool.Items)
            {
                if (!(control is ToolStripButton))
                {
                    continue;
                }

                ToolStripButton btn = ((ToolStripButton)control);
                
                if (btn.Name.Equals("btnInfo"))
                {
                    btn.Enabled = false;
                }
                else
                {
                    btn.Enabled = true;
                }
            }
        }

        /// <summary>
        /// 设置点击新增以及修改后的状态改变
        /// btnSave:可用
        /// btnEdit:不可用
        /// btnDel:不可用
        /// btnNew:不可用
        /// btnCancel:可用
        /// </summary>
        /// <param name="tool">按钮在ToolSrip中</param>
        public static void SetNewEditStatus(ToolStrip tool)
        {
            foreach (ToolStripItem control in tool.Items)
            {
                if (!(control is ToolStripButton))
                {
                    continue;
                }
                ToolStripButton btn = ((ToolStripButton)control);
                if (btn.Name == "btnSave")
                {
                    btn.Enabled = true;
                }
                else if (btn.Name == "btnExit")
                {
                    btn.Enabled = true;
                }
                else if (btn.Name == "btnNew")
                {
                    btn.Enabled = true;
                }
                else
                {
                    btn.Enabled = false;
                }
            }
        }

        
    }
}
