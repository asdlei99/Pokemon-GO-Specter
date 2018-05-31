using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Specter.Util;

namespace Specter.Forms
{
    public partial class frmWelcome : Form
    {
        private int i = 1;
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 1:
                    picGuide.Image = global::Specter.Properties.Resources.GUIA2;
                    break;
                case 2:
                    picGuide.Image = global::Specter.Properties.Resources.GUIA3;
                    break;
                case 3:
                    picGuide.Image = global::Specter.Properties.Resources.GUIA4;
                    break;
                case 4:
                    picGuide.Image = global::Specter.Properties.Resources.GUIA5;
                    btnNext.Text = "FECHAR";
                    break;
                default:
                    UserGlobalConfiguration.MessageWelcome = false;
                    this.Hide();
                    break;


            }

            i++;
        }
    }
}
