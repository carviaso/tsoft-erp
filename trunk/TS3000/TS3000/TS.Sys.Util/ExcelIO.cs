using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections;
using System;
using TS.Sys.Platform.Exceptions;

namespace TS.Sys.Util
{
    public class ExcelIO
    {

        private int _ReturnStatus;

        private string _ReturnMessage;



        private const string CREATE_ERROR = "Can not create excel file, may be your computer has not installed excel!";

        private const string IMPORT_ERROR = "Your excel file is open, please save and close it.";

        private const string EXPORT_ERROR = "This is an error that the excel file may be open when it be exported. /n";



        public int ReturnStatus
        {

            get { return _ReturnStatus; }

        }



        public string ReturnMessage
        {

            get { return _ReturnMessage; }

        }



        public ExcelIO()
        {

        }

        /// <summary> 
        /// 读取Excel文档 
        /// </summary> 
        /// <param name="Path">文件名称</param> 
        /// <returns>返回一个数据集</returns>         
        public static void ExcelToDataGridView(string filePath, DataTable dt)
        {
            string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + filePath + ";" + "Extended Properties=Excel 8.0;";
            OleDbConnection conn = new OleDbConnection(strCon);
            try
            {
                conn.Open();
                string strExcel = "";
                OleDbDataAdapter myCommand = null;
                DataSet ds = null;
                strExcel = "select * from [Sheet1$]";
                myCommand = new OleDbDataAdapter(strExcel, strCon);
                ds = new DataSet();
                myCommand.Fill(ds, "table1");

                ds.Tables["table1"].Rows.Remove(ds.Tables["table1"].Rows[0]);
                //我要导的Excel表格第一行不是列名，所以加了这行代码，根据具体情况可以注释掉
                /*
                            System.Data.DataTable dt = new System.Data.DataTable();
                            foreach (DataGridViewColumn dgvc in dgv.Columns)
                            {
                                if (dgvc.Visible && dgvc.CellType != typeof(DataGridViewCheckBoxCell))
                                {
                                    DataColumn dc = new DataColumn();
                                    dc.ColumnName = dgvc.DataPropertyName;
                                    dt.Columns.Add(dc);
                                }
                            }
            
                 */

               

                foreach (DataRow excelRow in ds.Tables[0].Rows)
                {
                    int i = 0;

                    DataRow dr = dt.NewRow();
                    foreach (DataColumn dc in dt.Columns)
                    {
                        if (i >= excelRow.ItemArray.Length)
                        {
                            break;
                        }

                        dr[dc] = excelRow[i];

                        i++;
                    }
                    dt.Rows.Add(dr);
                }
            }
            catch (OleDbException e)
            {
                throw new BusinessException("文件已被打开，请先关闭该文件！");
            } 
        }
 
    }

}
