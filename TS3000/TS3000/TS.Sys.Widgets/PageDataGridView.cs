using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TS.Sys.Widgets
{
    public partial class PageDataGridView : UserControl
    {
        private int pageSize = 15;

        private int currPage = 1;
        private int currIndex = 0;

        private int maxCount;
        private int maxPage;

        private DataTable dtInfo;
        
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int PageSize
        {
            set 
            {
                if (!this.cbxPageSize.Items.Contains(Convert.ToString(value)))
                {
                    this.cbxPageSize.Items.Insert(0, value);
                    this.cbxPageSize.SelectedIndex = 0;
                }
                this.pageSize = value; 
            }
            get { return this.pageSize; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DataGridView GridView
        {
            get { return this.grid; }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool PageSizeChangable
        {
            set
            {
                this.cbxPageSize.Visible = value;
            }
            get
            {
                return this.cbxPageSize.Visible;
            }
        }

        public PageDataGridView()
        {
            InitializeComponent();
        }

        public void setDataSource(DataTable dt)
        {
            this.dtInfo = dt;
            foreach (DataColumn dc in dt.Columns)
            {
                this.grid.Columns[dc.ColumnName].DataPropertyName = dc.ColumnName;
            }
            initData();
        }

        private void initData()
        {
            this.btnPre.Enabled = false;
            this.btnFirst.Enabled = false;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;

            this.pageSize = Convert.ToInt16(this.cbxPageSize.Text);
            this.currIndex = 0;
            this.currPage = 1;
            this.maxCount = this.dtInfo.Rows.Count;
            this.maxPage = this.maxCount / this.PageSize;
            if ((this.maxCount % this.PageSize) > 0) this.maxPage++;
            if (this.maxPage == 1)
            {
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
            this.labelCount.Text = "/ " + Convert.ToString(this.maxPage);

            loadData();
        }

        private void loadData()
        {
            this.currIndex = this.pageSize * (this.currPage - 1);

            int nStartPos = 0;   //当前页面开始记录行
            int nEndPos = 0;     //当前页面结束记录行

            DataTable dtTemp = dtInfo.Clone();   //克隆DataTable结构框架

            if (currPage == maxPage) nEndPos = maxCount;
            else nEndPos = this.PageSize * this.currPage;

            nStartPos = currIndex;

            //从元数据源复制记录行
            for (int i = nStartPos; i < nEndPos; i++)
            {
                dtTemp.ImportRow(dtInfo.Rows[i]);
                currIndex++;
            }

            this.grid.DataSource = dtTemp;
            this.grid.ScrollBars = ScrollBars.Both;
            this.textPos.Text = Convert.ToString(this.currPage);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.btnPre.Enabled = false;
            this.btnFirst.Enabled = false;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
            this.currPage = 1;

            loadData();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            this.currPage--;
            if (this.currPage == 1)
            {
                this.btnPre.Enabled = false;
                this.btnFirst.Enabled = false;
            }
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
            
            loadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.currPage == this.maxPage - 1)
            {
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
            this.btnPre.Enabled = true;
            this.btnFirst.Enabled = true;
            this.currPage++;

            loadData();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.btnPre.Enabled = true;
            this.btnFirst.Enabled = true;
            this.btnNext.Enabled = false;
            this.btnLast.Enabled = false;
            this.currPage = this.maxPage;

            loadData();
        }

        private void grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SetDataGridViewRowXh(e, this.grid);
        }

        private void SetDataGridViewRowXh(DataGridViewRowPostPaintEventArgs e, DataGridView dataGridView)
        {
            SolidBrush solidBrush = new SolidBrush(dataGridView.RowHeadersDefaultCellStyle.ForeColor);
            int xh = e.RowIndex + 1 + this.pageSize * (this.currPage - 1);
            e.Graphics.DrawString(Convert.ToString(xh), e.InheritedRowStyle.Font, solidBrush, e.RowBounds.Location.X + 5, e.RowBounds.Location.Y + 4);
        }

        private void textPos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int page = Convert.ToInt16(this.textPos.Text);
                if (page < 1 || page > this.maxPage || this.maxPage==1) return;

                if (page == 1) 
                    this.btnFirst_Click(this, new EventArgs());
                else if (page == this.maxPage) 
                    this.btnLast_Click(this, new EventArgs());
                else
                {
                    this.btnPre.Enabled = true;
                    this.btnFirst.Enabled = true;
                    this.btnNext.Enabled = true;
                    this.btnLast.Enabled = true;
                    this.currPage = page;
                }
                loadData();
            }
        }

        private void cbxPageSize_TextChanged(object sender, System.EventArgs e)
        {
            if(this.dtInfo!=null) initData();
        }
    }
}
