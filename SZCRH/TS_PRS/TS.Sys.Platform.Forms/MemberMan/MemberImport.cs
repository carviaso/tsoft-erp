using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TS.Sys.Platform.Exceptions;
using TS.Sys.Domain;
using TS.Sys.Util;
using TS.PRS.MemberMan.Info;
using TS.PRS.MemberMan.Service;
using System.Collections;

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberImportForm : Form
    {
        private MemberListForm mlf;

        public MemberImportForm()
        {
            InitializeComponent();
        }

        public MemberImportForm(String cCode,MemberListForm mlf):this()
        {
            this.cCompanyCode.Value = cCode;
            this.mlf = mlf;
        }
      

        private void btnAllImport_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = ImportCommonMethod();

                SetGridData(dt, gridMember);

            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void SetGridData(DataTable result, DataGridView grid)
        {
            foreach (DataRow r in result.Rows)
            {
                Object[] colValues = r.ItemArray;
                grid.Rows.Add(colValues);
            }
        }

        private DataTable ImportCommonMethod()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            foreach (DataGridViewColumn dgvc in this.gridMember.Columns)
            {
                if (dgvc.Visible && dgvc.CellType != typeof(DataGridViewCheckBoxCell))
                {
                    DataColumn dc = new DataColumn();
                    dc.ColumnName = dgvc.DataPropertyName;
                    dt.Columns.Add(dc);
                }
            }

            btnImportSalary(dt);
            return dt;
        }

        private void btnImportSalary(DataTable dt)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Excel文件";
            ofd.FileName = "";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofd.Filter = "Excel文件(*.xls)|*.xls";
            ofd.ValidateNames = true;
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;

            string strName = string.Empty;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                strName = ofd.FileName;
            }

            if (strName == "")
            {
                MessageBox.Show("没有选择Excel文件，无法导入");
                return;
            }


            ExcelIO.ExcelToDataGridView(strName, dt);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 绘制行数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void gridMember_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = (DataGridView)sender;
            if (dgv.RowHeadersVisible)
            {
                Rectangle rect = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgv.RowHeadersWidth, e.RowBounds.Height);
                rect.Inflate(-2, -2);
                TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, rect, e.InheritedRowStyle.ForeColor, TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MembersService ms = new MembersService();
                int i = 0;
                foreach (DataGridViewRow r in gridMember.Rows)
                {
                    MembersInfo m = new MembersInfo();
                    if (cCompanyCode.Value == null)
                    {
                        Msg.Show("请选择公司后再导入！");
                        return;
                    }
                    ArrayList result = ms.GetMaxCode();
                    int codeNumber = 1;
                    if (result.Count != 0)
                    {
                        Hashtable code = (Hashtable)result[0];
                        codeNumber = int.Parse(code["cCode"].ToString()) + 1;
                    }
                    m.cCode = string.Format("{0:D5}", codeNumber);

                    String cGUID = TS.Sys.Util.KeyUtil.genSimpleKey();
                    String cTimeStamp = TS.Sys.Util.KeyUtil.genSimpleKey();

                    m.cId = r.Cells["cId"].Value;
                    m.cName = r.Cells["cName"].Value;
                    m.cGUID = cGUID;
                    m.cTimeStamp = cTimeStamp;
                    m.dRecommendDate = DateTime.Today.Date;
                    m.cCompany = cCompanyCode.Value;
                    ms.Add(m);
                    i++;
                }
                Msg.Show(i + "条记录保存成功！");
                this.Close();
                this.mlf.listRefresh();
            }
            catch (BusinessException ex)
            {
                Msg.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
