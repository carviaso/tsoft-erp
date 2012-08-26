using System;
using System.Drawing;
using System.Windows.Forms;

namespace TS.Sys.Platform.Widgets.Money.GridMoney
{
    public class DataGridViewMoneyCell : DataGridViewTextBoxCell
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


        public DataGridViewMoneyCell()
        {
            m_iLineSpace = 12;
            m_fBold = 1.0f;
            m_redColor = Color.Red;
            m_specialColor = Color.Blue;
            m_normalColor = Color.Gray;

        }
        /// <summary>
        /// 线间距
        /// </summary>
        public int LineSpace
        {
            set
            {
                m_iLineSpace = value;

            }
            get
            {
                DataGridViewMoneyColumn dataGridViewMoneyColumn = OwningColumn as DataGridViewMoneyColumn;
                if (dataGridViewMoneyColumn != null)
                {
                    if (dataGridViewMoneyColumn.LineSpace != 0)
                    {
                        return dataGridViewMoneyColumn.LineSpace;
                    }
                }
                return m_iLineSpace;
            }
        }
        public float LineBold
        {
            get
            {
                DataGridViewMoneyColumn dataGridViewMoneyColumn = OwningColumn as DataGridViewMoneyColumn;
                if (dataGridViewMoneyColumn != null)
                {
                    if (dataGridViewMoneyColumn.LineBold != 0.0f)
                    {
                        return dataGridViewMoneyColumn.LineBold;
                    }
                }
                return m_fBold;
            }
            set
            {
                m_fBold = value;
            }
        }
        public Color RedColor
        {
            get
            {
                DataGridViewMoneyColumn dataGridViewMoneyColumn = OwningColumn as DataGridViewMoneyColumn;
                if (dataGridViewMoneyColumn != null)
                {
                    if (dataGridViewMoneyColumn.RedColor != Color.Empty)
                    {
                        return dataGridViewMoneyColumn.RedColor;
                    }
                }
                return m_redColor;
            }
            set
            {
                m_redColor = value;
            }
        }
        public Color SpecialColor
        {
            get
            {
                DataGridViewMoneyColumn dataGridViewMoneyColumn = OwningColumn as DataGridViewMoneyColumn;
                if (dataGridViewMoneyColumn != null)
                {
                    if (dataGridViewMoneyColumn.SpecialColor != Color.Empty)
                    {
                        return dataGridViewMoneyColumn.SpecialColor;
                    }
                }
                return m_specialColor;
            }
            set
            {
                m_specialColor = value;
            }
        }
        public Color NormalColor
        {
            get
            {
                DataGridViewMoneyColumn dataGridViewMoneyColumn = OwningColumn as DataGridViewMoneyColumn;
                if (dataGridViewMoneyColumn != null)
                {
                    if (dataGridViewMoneyColumn.NormalColor != Color.Empty)
                    {
                        return dataGridViewMoneyColumn.NormalColor;
                    }
                }
                return m_normalColor;
            }
            set
            {
                m_normalColor = value;
            }
        }
        protected override void Paint(Graphics graphics, Rectangle clipBounds,
            Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState,
            object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {

            this.PaintPrivate(graphics, clipBounds, cellBounds, rowIndex,
                cellState, formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts, false, false, true);
        }
        private bool PaintBorder(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.Border) != DataGridViewPaintParts.None);
        }
        private bool PaintSelectionBackground(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.SelectionBackground) != DataGridViewPaintParts.None);
        }
        private bool PaintBackground(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.Background) != DataGridViewPaintParts.None);
        }
        private bool PaintFocus(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.Focus) != DataGridViewPaintParts.None);
        }
        private bool PaintSelected(DataGridViewElementStates cellState)
        {
            return (cellState & DataGridViewElementStates.Selected) != DataGridViewElementStates.None;
        }
        internal static bool PaintContentForeground(DataGridViewPaintParts paintParts)
        {
            return ((paintParts & DataGridViewPaintParts.ContentForeground) != DataGridViewPaintParts.None);
        }
        protected void PaintPrivate(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts, bool computeContentBounds, bool computeErrorIconBounds, bool paint)
        {
            SolidBrush solidBrush;

            if (paint && PaintBorder(paintParts))
            {
                this.PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            }
            Rectangle advanceRectangle = this.BorderWidths(advancedBorderStyle);
            cellBounds.Offset(advanceRectangle.X, advanceRectangle.Y);
            cellBounds.Width -= advanceRectangle.Right;
            cellBounds.Height -= advanceRectangle.Bottom;

            bool isCell = (DataGridView.CurrentCellAddress.X == base.ColumnIndex)
                && (DataGridView.CurrentCellAddress.Y == rowIndex)
                && (DataGridView.EditingControl != null);
            bool isCellSelected = (cellState & DataGridViewElementStates.Selected) != DataGridViewElementStates.None;

            if ((PaintSelectionBackground(paintParts) && isCellSelected) && !isCell)
            {
                solidBrush = new SolidBrush(cellStyle.SelectionBackColor);
            }
            else
            {
                solidBrush = new SolidBrush(cellStyle.BackColor);
            }
            if (paint && PaintBackground(paintParts)
                && cellBounds.Width > 0
                && (cellBounds.Height > 0))
            {
                graphics.FillRectangle(solidBrush, cellBounds);
            }
            int i = cellBounds.Width;
            int j = 1;


            while (i > 0)
            {
                if (i - LineSpace > 0)
                {
                    i = i - LineSpace;

                    if (j == 2)
                    {
                        using (Pen redPen = new Pen(RedColor, LineBold))
                        {
                            graphics.DrawLine(redPen, new Point(cellBounds.Left + i, cellBounds.Top),
                                                 new Point(cellBounds.Left + i, cellBounds.Top + cellBounds.Height));
                        }
                    }
                    else
                    {
                        if (j > 2 && (j - 2) % 3 == 0)
                        {
                            using (Pen specialPen = new Pen(SpecialColor, LineBold))
                            {
                                graphics.DrawLine(specialPen, new Point(cellBounds.Left + i, cellBounds.Top),
                                                     new Point(cellBounds.Left + i, cellBounds.Top + cellBounds.Height));
                            }
                        }
                        else
                        {
                            using (Pen normalPen = new Pen(NormalColor, LineBold))
                            {
                                graphics.DrawLine(normalPen, new Point(cellBounds.Left + i, cellBounds.Top),
                                                     new Point(cellBounds.Left + i, cellBounds.Top + cellBounds.Height));
                            }
                        }
                    }
                }
                else
                {
                    i = 0;
                }
                j++;
            }
            // Rectangle rec=
            //写值
            string sFormattedValue = formattedValue as string;
            if (!String.IsNullOrEmpty(sFormattedValue) && ((paint && !isCell) || computeContentBounds))
            {
                decimal d = 0;
                Decimal.TryParse(sFormattedValue, out d);
                sFormattedValue = d.ToString("#0.00");
                sFormattedValue = "￥" + sFormattedValue;
                if (!PaintContentForeground(paintParts))
                {
                    return;
                }
                int x = cellBounds.Width;
                int y = sFormattedValue.Length - 1;
                while (x > 0)
                {
                    if (y == -1)
                    {
                        break;
                    }
                    if (x - LineSpace > 0)
                    {
                        x = x - LineSpace;
                        if (sFormattedValue[y].ToString() == ".")
                        {
                            y--;
                        }
                        using (SolidBrush brush = new SolidBrush(cellStyle.ForeColor))
                        {
                            graphics.DrawString(sFormattedValue[y].ToString(), cellStyle.Font, brush,
                                    cellBounds.Left + x + 2, cellBounds.Top + 2);
                        }
                    }
                    else
                    {
                        x = 0;
                    }
                    y--;
                }

            }
        }
    }
}
