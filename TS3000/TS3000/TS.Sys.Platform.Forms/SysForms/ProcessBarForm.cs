using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TS.Sys.Platform.Forms.SysForms
{
    public partial class ProcessBarForm : Form
    {
        public ProcessBarForm()
        {
            InitializeComponent();
        }
        /// <summary>

        /// Increase process bar

        /// </summary>

        /// <param name="nValue">the value increased</param>

        /// <returns></returns>

        public bool Increase(int nValue)
        {

            if (nValue > 0)
            {

                if (prcBar.Value + nValue < prcBar.Maximum)
                {

                    prcBar.Value += nValue;

                    return true;

                }

                else
                {

                    prcBar.Value = prcBar.Maximum;

                    this.Close();

                    return false;

                }

            }

            return false;

        }


    }
}
