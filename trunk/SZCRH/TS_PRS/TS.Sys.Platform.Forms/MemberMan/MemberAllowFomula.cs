using System;
using System.Windows.Forms;

namespace TS.Sys.Platform.Forms.MemberMan
{
    public partial class MemberAllowFomula : Form
    {
        private MemberAllowDetailForm _mForm;

        public MemberAllowFomula()
        {
            InitializeComponent();
        }

        public MemberAllowFomula(MemberAllowDetailForm mForm)
            : this()
        {
            this._mForm = mForm;

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
