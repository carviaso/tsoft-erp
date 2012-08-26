using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TS.Sys.Platform.Forms.MenuList;
using TS.Sys.Platform.SysInfo.Service;
using System.Collections;

namespace TS.Sys.Platform.Forms
{
    public partial class WelcomeForm : Form
    {
        private MainForm _mainForm;
        private String _modual;
        private String _defaulEvent = "btnMember_Click";
        private ToolStripButton preButton;
        private ModualService modualService;

        public WelcomeForm()
        {
            InitializeComponent();
            this.ControlBox = false;//隐藏tool按钮

        }

        public WelcomeForm(MainForm mainForm)
            : this()
        {
            this._mainForm = mainForm;
            modualService = new ModualService();
           
        }

        public String DefaultEvent
        {
            get { return this._defaulEvent; }
            set { this._defaulEvent = value; }
        }



        private void btnBase_Click(object sender, EventArgs e)
        {
            if (_modual != null && !_modual.Equals("base"))
            {
                this.tpControl.Controls.Remove(tpControl.Controls["MenuContext"]);
            }
            else if (_modual.Equals("base"))
            {
                return;
            }
            this._modual = "base";
            this.tpControl.Controls.Add(new MenuBase(_mainForm), 1, 0);
            if (preButton != null)
            {
                preButton.BackgroundImage = null;
                preButton.ForeColor = Color.White;
            }
            btnBase.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.MenuSelectedBG;
            btnBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnBase.ForeColor = System.Drawing.SystemColors.HotTrack;
            preButton = btnBase;

        }



        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true); this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            InitMenuModual();
            ToolStripButton btn = (ToolStripButton)this.toolModual.Items[0];
            String modual = btn.Name.Substring(3);
            CreatMenuContext(btn, modual, "business");
            preButton = btn;
        }

        private void InitMenuModual()
        {
            //业务菜单
            InitBusinessModual();
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            this.toolModual.Items.Add(toolStripSeparator1);
            InitBaseModual();



        }

        private void InitBaseModual()
        {
            CreateMenuButton("base");
        }

        private void InitBusinessModual()
        {
            CreateMenuButton("business");
        }

        private void CreateMenuButton(String type)
        {
            ArrayList moduals = modualService.GetResultList(type);
            foreach (Object o in moduals)
            {
                Hashtable value = (Hashtable)o;
                ToolStripButton btn = new ToolStripButton();
                btn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                btn.ImageTransparentColor = System.Drawing.Color.Magenta;
                btn.Name = "btn" + value["cName"];
                if (value["cImgPath"] != null && !String.IsNullOrEmpty(value["cImgPath"].ToString()))
                {
                    btn.Image = Image.FromFile(Application.StartupPath + "\\img" + value["cImgPath"]);

                    btn.ImageAlign = ContentAlignment.MiddleCenter;
                    btn.ImageTransparentColor = System.Drawing.Color.Magenta;
                }
                btn.Size = new System.Drawing.Size(172, 50);
                btn.Text = "     " + value["cTitle"];
                btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                if (type.Equals("base"))
                {
                    btn.Click += new System.EventHandler(Base_Click);
                }
                else
                {
                    btn.Click += new System.EventHandler(Business_Click);
                }
                this.toolModual.Items.Add(btn);

            }
        }



        private void Business_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, "business");
        }

        private void Base_Click(object sender, EventArgs e)
        {
            ButtonClick(sender, "base");
        }

        private void ButtonClick(object sender, String type)
        {
            String modual = ((ToolStripButton)sender).Name.Substring(3);
            CreatMenuContext((ToolStripButton)sender, modual, type);
            preButton = (ToolStripButton)sender;
        }

        private void CreatMenuContext(ToolStripButton btn, String modual, String type)
        {
            if (_modual != null && !_modual.Equals(modual))
            {
                this.tpControl.Controls.Remove(tpControl.Controls["MenuContext"]);
            }
            else if (_modual != null && _modual.Equals(modual))
            {
                return;
            }
            this._modual = modual;
            if (type.Equals("base"))
            {
                this.tpControl.Controls.Add(new MenuBase(_mainForm, this._modual), 0, 1);
            }
            else
            {
                this.tpControl.Controls.Add(new MenuContext(_mainForm, this._modual), 0, 1);
            }
            if (preButton != null)
            {
                preButton.BackgroundImage = null;
                preButton.ForeColor = Color.White;
            }
            btn.BackgroundImage = global::TS.Sys.Platform.Forms.Properties.Resources.MenuSelectedBG;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.ForeColor = SystemColors.HotTrack;
            preButton = btnBase;
        }

    }
}
