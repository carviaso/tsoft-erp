using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.SysInfo.Service;

namespace TS.Sys.Platform.Forms.MenuList
{

    /// <summary>
    /// 基础设置菜单项
    /// </summary>
    public class MenuBase : TableLayoutPanel
    {

        private MainForm _mainForm;
        private Hashtable _menuMap;
        private MenuService ms;
        public MenuBase(MainForm mainForm)
        {
            this._mainForm = mainForm;
            ms = new MenuService();
            _menuMap = new Hashtable();
            initComponent();
        }



        public MenuBase(MainForm mainForm, String modual)
            : this(mainForm)
        {
            GetMenuBase(modual);
        }

        private void GetMenuBase(String modual)
        {
            ArrayList mList = GetMenuBaseList(modual);
            int col = 0;
            int row = 0;
            this.RowCount = 1;
            this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            foreach (Object o in mList)
            {
                Hashtable value = (Hashtable)o;
                LinkLabel btn =new LinkLabel();
                _menuMap.Add(value["cCode"], value["cForm"]);
                btn.Name = "btn" + value["cCode"];
                btn.Text = value["cTitle"].ToString();
                
                if (value["cImgPath"] != null && !String.IsNullOrEmpty(value["cImgPath"].ToString()))
                {
                    btn.Image = Image.FromFile(Application.StartupPath + "\\img" + value["cImgPath"]);
                }
                btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
                btn.LinkArea = new System.Windows.Forms.LinkArea(0, 5);
                btn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
                btn.LinkColor = System.Drawing.Color.Black;
                btn.Location = new System.Drawing.Point(182, 163);
                btn.Size = new System.Drawing.Size(75, 85);
                btn.TabIndex = 7;
                btn.TabStop = true;                
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btn.UseCompatibleTextRendering = true;
                btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_LinkClicked);
                this.Controls.Add(btn,col,row);
                col++;
                if (col == 6)
                {
                    col = 0;
                    row++;
                    this.RowCount++;
                    this.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
                    this.Height += 150;
                }
            }

            
        }
        private ArrayList GetMenuBaseList(String modual)
        {
            Hashtable con = new Hashtable();
            con.Add("cParent", modual);
            con.Add("cField", "item");
            return ms.GetResultList(con);
        }
         



        public void initComponent()
        {
            // 
            // tpBase
            // 
            this.Controls.Clear();
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ColumnCount = 6;
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));            
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddRows;
            this.Location = new System.Drawing.Point(183, 113);
            this.Name = "MenuContext";
            this.Size = new System.Drawing.Size(812, 150);
            this.TabIndex = 1;
               
            
        }

 

        private void btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Assembly tempAssembly = Assembly.GetExecutingAssembly();
                LinkLabel link = (LinkLabel)sender;
                String name = link.Name.Substring(3);
                String formUrl = _menuMap[name].ToString();
                Type t = tempAssembly.GetType(formUrl);
                object o = System.Activator.CreateInstance(t, null);

                int index = 0;
                foreach (Form f in this._mainForm.MdiChildren)
                {
                    if (f.Name.Equals(((Form)o).Name))
                    {
                        f.Activate();
                        break;
                    }
                    index++;
                }
                if (index == this._mainForm.MdiChildren.Length)
                {
                    ((Form)o).MdiParent = this._mainForm;
                    ((Form)o).Show();
                    this._mainForm.AddChildItem(((Form)o).Name, ((Form)o).Text);
                }
            }
            catch (Exception ex)
            {
                Msg.Show(ExceptionConst.Error_Form);
            }
        }
    }


}
