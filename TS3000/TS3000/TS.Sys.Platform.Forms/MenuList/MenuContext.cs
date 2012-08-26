using System;
using System.Collections;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Domain;
using TS.Sys.Platform.Business.Util;
using TS.Sys.Platform.SysInfo.Info;
using TS.Sys.Platform.SysInfo.Service;

namespace TS.Sys.Platform.Forms.MenuList
{
    public class MenuContext:TableLayoutPanel
    {
        private MainForm _mainForm; 
        private Hashtable _menuMap;
        private MenuService ms;
        //菜单列表
        private FlowLayoutPanel MenuList;
        //导航图
        private Panel panel1;
        private Panel panelLine;
        private Label labelBaseTitle;
        private Panel panelBase;
        private Panel panelBill;
        private Panel panelReport;
        private Label labelBillTitle;
        private Label labelReportTitle;
        private TableLayoutPanel tpBase;
        private TableLayoutPanel tpList;
        private TableLayoutPanel tpReport;
        
      
        public MenuContext(MainForm mainForm)
        {
            this._mainForm = mainForm;
            ms = new MenuService();
            _menuMap = new Hashtable(); 
            initComponent();            
        }

        public MenuContext(MainForm mainForm, String modual)
            : this(mainForm)
        {
            GetFlowPanel(modual);
            GetMenuBase(modual);
            GetMenuList(modual);
            GetMenuReport(modual);
        }

        private void GetFlowPanel(string modual)
        {
            Hashtable con = new Hashtable();
            con.Add("cModual",modual);
            ArrayList mList = ms.GetFlowList(con);
            foreach (Object o in mList)
            {
                Hashtable value = (Hashtable)o;
                LinkLabel btn = new LinkLabel();
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
                btn.Location = new System.Drawing.Point(int.Parse(value["iX"].ToString()),int.Parse(value["iY"].ToString()));
                btn.Size = new System.Drawing.Size(75, 85);
                btn.TabIndex = 7;
                btn.TabStop = true;
                btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                btn.UseCompatibleTextRendering = true;
                btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_LinkClicked);
                this.panel1.Controls.Add(btn);
            }
            
            this.panel1.BackgroundImage = Image.FromFile(Application.StartupPath + "\\img\\" + modual+".png");
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
                object o = new object();
                if (name.IndexOf("Detail") > 0)
                {
                    o = System.Activator.CreateInstance(t, new Object[]{"new"});
                }
                else
                {
                    o = System.Activator.CreateInstance(t, null);
                }

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

        private void GetMenuBase(String modual)
        {
            ArrayList mList = GetMenuContextList(modual, "base");

            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi, mDetail);
                this.tpBase.Controls.Add(InitMenuContext(mi), 1, i + 1);
                this.tpBase.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                this.tpBase.Height += 20;
                this.tpList.Location = new Point(this.tpList.Location.X,this.tpList.Location.Y+20);
                this.tpReport.Location = new Point(this.tpReport.Location.X, this.tpReport.Location.Y + 20);
            }
        }
        private void GetMenuList(String modual)
        {
            ArrayList mList = GetMenuContextList(modual, "list");
            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi, mDetail);
                this.tpList.Controls.Add(InitMenuContext(mi), 1, i + 1);
                this.tpList.RowStyles.Add(new RowStyle( SizeType.Absolute, 20F));
                this.tpList.Height += 20;
                this.tpReport.Location = new Point(this.tpReport.Location.X, this.tpReport.Location.Y + 20);
            }
        }

        private void GetMenuReport(String modual)
        {
            ArrayList mList = GetMenuContextList(modual, "report");
            for (int i = 0; i < mList.Count; i++)
            {
                Hashtable mDetail = (Hashtable)mList[i];
                MenuInfo mi = new MenuInfo();
                BusinessControl.SetInfoByResult(mi, mDetail);
                this.tpReport.Controls.Add(InitMenuContext(mi), 1, i + 1);
                this.tpReport.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
                this.tpReport.Height += 20;
            }
        }

        

        private ArrayList GetMenuContextList(String modual, String cField)
        {
            Hashtable con = new Hashtable();
            con.Add("cParent", modual);
            con.Add("cField", cField);
            return ms.GetResultList(con);
        }

        /// <summary>
        /// 初始化菜单
        /// </summary>
        /// <param name="menuInfo"></param>
        /// <returns></returns>
        private LinkLabel InitMenuContext(MenuInfo menuInfo)
        {
            LinkLabel linkLabel = new LinkLabel();
            if (_menuMap[menuInfo.cCode] == null)
            {
                _menuMap.Add(menuInfo.cCode, menuInfo.cForm);
            }
            linkLabel.Anchor = AnchorStyles.Left;
            linkLabel.AutoSize = true;
            linkLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel.LinkColor = Color.Black;
            linkLabel.Location = new Point(53, 34);
            linkLabel.Name = menuInfo.cCode.ToString();
            linkLabel.Size = new Size(65, 12);
            linkLabel.TabIndex = 0;
            linkLabel.TabStop = true;
            linkLabel.Text = menuInfo.cTitle.ToString();
            linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.menuClicked);
            return linkLabel;
        }

        /// <summary>
        /// 链接点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Assembly tempAssembly = Assembly.GetExecutingAssembly();
                LinkLabel link = (LinkLabel)sender;
                String test = link.Name;
                String formUrl = _menuMap[link.Name].ToString();
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

        private void initComponent()
        {

            this.MenuList = new FlowLayoutPanel();
            this.tpList = new TableLayoutPanel();
            this.tpBase = new TableLayoutPanel();
            this.tpReport = new TableLayoutPanel();
            this.panel1 = new Panel();
            this.panelLine = new Panel();
            this.labelBaseTitle = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.labelBillTitle = new System.Windows.Forms.Label();
            this.panelBill = new System.Windows.Forms.Panel();
            this.MenuList.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuContext
            //  
           
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ColumnCount = 3;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 500F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            this.Controls.Add(this.panel1, 1, 0);
            this.Controls.Add(this.panelLine, 2, 0);
            this.Controls.Add(this.MenuList, 3, 0);
            this.Dock = DockStyle.Fill;
            this.Location = new Point(0, 0);
            this.Name = "MenuContext";
            this.RowCount = 1;
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Size = new Size(720, 650);
            this.TabIndex = 2;
            //测试用，将表格线显示出来
            //this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            // 
            // panel1
            //  
            this.panel1.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.memflow;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(500,550);
            this.panel1.TabIndex = 2; 
            this.panelLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLine.Location = new System.Drawing.Point(529, 3);
            this.panelLine.Name = "panel2";
            this.panelLine.Size = new System.Drawing.Size(11,650);
            this.panelLine.TabIndex = 0;
            this.panelLine.BackgroundImage =  global::TS.Sys.Platform.Forms.Properties.Resources.line;
            // 
            // MenuList
            // 
            this.MenuList.Controls.Add(this.tpBase);
            this.MenuList.Controls.Add(this.tpList);
            this.MenuList.Controls.Add(this.tpReport);
            this.MenuList.Dock = DockStyle.Fill;
            this.MenuList.Location = new Point(535, 3);
            this.MenuList.Name = "MenuList";
            this.MenuList.Size = new System.Drawing.Size(208, 650);
            this.MenuList.TabIndex = 0; 
            // 
            // tpBase
            //  
            this.tpBase.ColumnCount = 2;
            this.tpBase.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 30F)); 
            this.tpBase.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 150F));
            this.tpBase.Location = new Point(3, 3);
            this.tpBase.Name = "tpBase";
            this.tpBase.RowCount = 1;
            this.tpBase.RowStyles.Add(new RowStyle( SizeType.Absolute, 30F));
            this.tpBase.Size = new Size(200, 40);
            this.tpBase.TabIndex = 3;
            this.tpBase.Controls.Add(this.labelBaseTitle, 1, 0);
            this.tpBase.Controls.Add(this.panelBase, 0, 0);


            // 
            // label1
            // 
            this.labelBaseTitle.AutoSize = true;
            this.labelBaseTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBaseTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBaseTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelBaseTitle.Location = new System.Drawing.Point(55, 0);
            this.labelBaseTitle.Name = "label1";
            this.labelBaseTitle.Size = new System.Drawing.Size(119, 32);
            this.labelBaseTitle.TabIndex = 0;
            this.labelBaseTitle.Text = "基础数据";
            this.labelBaseTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBaseTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            this.panelBase.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelBase.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.configure;
            this.panelBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBase.Location = new System.Drawing.Point(25, 3);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(24, 26);
            this.panelBase.TabIndex = 1;

           
            //测试用，将表格线显示出来
            //this.tpBase.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            // 
            // tpList
            // 
            this.tpList.ColumnCount = 2;
            this.tpList.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 30F));
            this.tpList.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 150F));
            this.tpList.Location = new System.Drawing.Point(3, 39);
            this.tpList.Name = "tpList";
            this.tpList.RowCount = 1;
            this.tpList.RowStyles.Add(new RowStyle( SizeType.Absolute, 30F));
            this.tpList.Size = new System.Drawing.Size(200, 40);
            this.tpList.TabIndex = 2;
            this.tpList.Controls.Add(this.labelBillTitle, 1, 0);
            this.tpList.Controls.Add(this.panelBill, 0, 0);
            //测试用，将表格线显示出来
            //this.tpList.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;


            // 
            // label1
            // 
            this.labelBillTitle.AutoSize = true;
            this.labelBillTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBillTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBillTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelBillTitle.Location = new System.Drawing.Point(55, 0);
            this.labelBillTitle.Name = "labelBill";
            this.labelBillTitle.Size = new System.Drawing.Size(119, 32);
            this.labelBillTitle.TabIndex = 0;
            this.labelBillTitle.Text = "单据列表";
            this.labelBillTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelBillTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;

            this.panelBill.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelBill.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.bill;
            this.panelBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBill.Location = new System.Drawing.Point(25, 3);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(24, 26);
            this.panelBill.TabIndex = 1;

            // 
            // tpReport
            // 
            this.tpReport.ColumnCount = 2;
            this.tpReport.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 30F));
            this.tpReport.ColumnStyles.Add(new ColumnStyle( SizeType.Absolute, 150F));
            this.tpReport.Location = new Point(3, 85);
            this.tpReport.Name = "tpReport";
            this.tpReport.RowCount = 1;
            this.tpReport.RowStyles.Add(new RowStyle( SizeType.Absolute, 30F));
            this.tpReport.Size = new Size(200, 40);
            this.tpReport.TabIndex = 4;
            //测试用，将表格线显示出来
            //this.tpReport.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

        }
    }
}
