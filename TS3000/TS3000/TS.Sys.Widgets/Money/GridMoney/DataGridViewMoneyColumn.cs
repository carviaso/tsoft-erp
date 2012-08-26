using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets.Money.GridMoney
{
    [ToolboxBitmap(typeof(DataGridViewTextBoxColumn), "DataGridViewTextBoxColumn.bmp")]
    public class DataGridViewMoneyColumn : DataGridViewColumn
    {
        /// <summary>
        /// 线间隔大小
        /// </summary>
        private int m_iLineSpace;
        /// <summary>
        /// 线粗
        /// </summary>
        private float m_fBold;

        /// <summary>
        /// 红线颜色，特殊占位颜色，普通线颜色
        /// </summary>
        private Color m_redColor;

        private Color m_specialColor;

        private Color m_normalColor;

        public DataGridViewMoneyColumn()
            : base(new DataGridViewMoneyCell())
        {
        }
        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewMoneyCell)))
                {
                    throw new InvalidCastException("不是DataGridViewMoneyCell");
                }
                base.CellTemplate = value;
            }
        }

        /// <summary>
        /// 设置正则
        /// </summary>
        [DefaultValue(12)]
        public int LineSpace
        {
            get
            {
                return this.m_iLineSpace;
            }
            set
            {
                if (this.m_iLineSpace != value)
                {
                    this.m_iLineSpace = value;
                    DataGridViewMoneyCell dataGridViewMoneyCell = (DataGridViewMoneyCell)this.CellTemplate;
                    dataGridViewMoneyCell.LineSpace = value;

                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {
                        int rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            DataGridViewCell dataGridViewCell = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dataGridViewCell is DataGridViewMoneyCell)
                            {
                                dataGridViewMoneyCell = (DataGridViewMoneyCell)dataGridViewCell;
                                dataGridViewMoneyCell.LineSpace = value;
                            }
                        }
                    }
                }
            }
        }
        public float LineBold
        {
            get
            {
                return this.m_fBold;
            }
            set
            {
                if (this.m_fBold != value)
                {
                    this.m_fBold = value;
                    DataGridViewMoneyCell dataGridViewMoneyCell = (DataGridViewMoneyCell)this.CellTemplate;
                    dataGridViewMoneyCell.LineBold = value;

                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {
                        int rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            DataGridViewCell dataGridViewCell = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dataGridViewCell is DataGridViewMoneyCell)
                            {
                                dataGridViewMoneyCell = (DataGridViewMoneyCell)dataGridViewCell;
                                dataGridViewMoneyCell.LineBold = value;
                            }
                        }
                    }
                }
            }
        }
        public Color RedColor
        {
            get
            {
                return m_redColor;
            }
            set
            {
                if (this.m_redColor != value)
                {
                    this.m_redColor = value;
                    DataGridViewMoneyCell dataGridViewMoneyCell = (DataGridViewMoneyCell)this.CellTemplate;
                    dataGridViewMoneyCell.RedColor = value;

                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {
                        int rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            DataGridViewCell dataGridViewCell = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dataGridViewCell is DataGridViewMoneyCell)
                            {
                                dataGridViewMoneyCell = (DataGridViewMoneyCell)dataGridViewCell;
                                dataGridViewMoneyCell.RedColor = value;
                            }
                        }
                    }
                }
            }
        }
        public Color SpecialColor
        {
            get
            {
                return m_specialColor;
            }
            set
            {
                if (this.m_specialColor != value)
                {
                    this.m_specialColor = value;
                    DataGridViewMoneyCell dataGridViewMoneyCell = (DataGridViewMoneyCell)this.CellTemplate;
                    dataGridViewMoneyCell.SpecialColor = value;

                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {
                        int rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            DataGridViewCell dataGridViewCell = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dataGridViewCell is DataGridViewMoneyCell)
                            {
                                dataGridViewMoneyCell = (DataGridViewMoneyCell)dataGridViewCell;
                                dataGridViewMoneyCell.SpecialColor = value;
                            }
                        }
                    }
                }
            }
        }
        public Color NormalColor
        {
            get
            {
                return m_normalColor;
            }
            set
            {
                if (this.m_normalColor != value)
                {
                    this.m_normalColor = value;
                    DataGridViewMoneyCell dataGridViewMoneyCell = (DataGridViewMoneyCell)this.CellTemplate;
                    dataGridViewMoneyCell.NormalColor = value;

                    if (this.DataGridView != null && this.DataGridView.Rows != null)
                    {
                        int rowCount = this.DataGridView.Rows.Count;
                        for (int x = 0; x < rowCount; x++)
                        {
                            DataGridViewCell dataGridViewCell = this.DataGridView.Rows.SharedRow(x).Cells[x];
                            if (dataGridViewCell is DataGridViewMoneyCell)
                            {
                                dataGridViewMoneyCell = (DataGridViewMoneyCell)dataGridViewCell;
                                dataGridViewMoneyCell.NormalColor = value;
                            }
                        }
                    }
                }
            }
        }
    }
}
