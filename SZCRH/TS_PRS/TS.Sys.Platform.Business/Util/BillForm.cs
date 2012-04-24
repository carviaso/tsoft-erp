using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using TS.Sys.Platform.Business.Service;
using TS.Sys.Platform.Widgets.Refer.WidgetRefer;
using TS.Sys.Util;

namespace TS.Sys.Platform.Business.Util
{
    public  class BillForm
    {
        public static Hashtable GetWidgetBind(Services service, TableLayoutPanel tpControl, string cGUID)
        {
            Hashtable stInfo = new Hashtable();
            ArrayList result = new ArrayList();// service.GetResultByGUID(cGUID);
            if (result.Count != 0)
            {
                stInfo = (Hashtable)result[0];
                foreach (String key in stInfo.Keys)
                {
                    if (tpControl.Controls.ContainsKey(key))
                    {
                        Control control = tpControl.Controls[key];
                        BusinessControl.SetComValue(control, stInfo[key].ToString());
                    }
                }
                return stInfo;

            }
            return null;
        }

        public static Hashtable SetMainContent(Object info,ArrayList result, TableLayoutPanel tpControl)
        {
            Hashtable stInfo = new Hashtable();
            if (result.Count != 0)
            {
                stInfo = (Hashtable)result[0];
                foreach (String key in stInfo.Keys)
                {
                    if (tpControl.Controls.ContainsKey(key))
                    {
                        Control control = tpControl.Controls[key];
                        BusinessControl.SetComValue(control, stInfo[key].ToString());
                        BusinessControl.SetInfoProperties(info,tpControl);
                    }
                }
                return stInfo;

            }
            return null;
        }

        public static void SetSubContent(DataTable resultSub, DataGridView grid)
        {
            grid.Rows.Clear();
            foreach (DataRow row in resultSub.Rows)
            {
                Object[] values = row.ItemArray;
                Object[] cellValues = new Object[values.Length];
                int index = 0;
                foreach (Object v in values)
                {
                    Object value = new Object();
                    if (v is Decimal)
                    {
                        value = NumberUtil.FormatAMT(v);
                    }
                    else
                    {
                        value = v;
                    }
                    cellValues[index] = value;
                    index++;

                }
                grid.Rows.Add(cellValues);
            }
        }

        /// <summary>
        /// 设置资料按钮事件
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="form"></param>
        /// <param name="btn"></param>
        public static void SetInfoBtnContext(String dir, Form form, ToolStripButton btn)
        {
            if (String.IsNullOrEmpty(dir))
            {
                btn.Enabled = false;
            }
            else
            {
                Type t = form.GetType();
                t.GetProperty("ReferType").SetValue(form, dir, null);
                btn.Enabled = true;
            }
        }
        
        /// <summary>
        /// 设置参照控件的坐标变换事件
        /// </summary>
        /// <param name="tpControl"></param>
        public static void ReferLocationChange(TableLayoutPanel tpControl)
        {
            foreach (Control control in tpControl.Controls)
            {
                if (control is LabelRefer)
                {
                    ((LabelRefer)control).LocationChange();
                }
            }
        }

        /// <summary>
        /// 设置参照控件的坐标变换事件
        /// </summary>
        /// <param name="tpControl"></param>
        public static void ReferSetInfoStatus(Form form,ToolStripButton btn,TableLayoutPanel tpControl)
        {
            foreach (Control control in tpControl.Controls)
            {
                if (control is LabelRefer)
                {
                    ((LabelRefer)control).SetInfoStatus(form,btn);
                }
            }
        }

    }
}
