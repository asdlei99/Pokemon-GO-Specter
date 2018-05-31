using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Specter.MODEL;
using Specter.Util;

namespace Specter.FORMS
{
    public partial class frmNewLogin : Form
    {
        public frmNewLogin()
        {
            InitializeComponent();
            
        }

        private async void frmNewLogin_Load(object sender, EventArgs e)
        {
            if (await PokemonRaro.PokemonRaro.CheckServerState())
            {
                lblVersao.Text = string.Format( await PokemonRaro.PokemonRaro.GetVersion() ? $"VERSÃO: {PokemonRaro.PokemonRaro.SpecterVersion}." : $"VERSÃO: DEZATUALIZADA.");
                UserGlobalConfiguration.LoadSettingsFromFile();

                if(UserGlobalConfiguration.PogoRaroKey != string.Empty)
                    txtCodigo.Text = UserGlobalConfiguration.PogoRaroKey;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!await PokemonRaro.PokemonRaro.DoLogin(txtCodigo.Text)) return;

            this.Hide();
            FrmPrincipal openFrmPrincipal = new FrmPrincipal();
            openFrmPrincipal.Show();
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtCodigo.TextAlign = HorizontalAlignment.Left;
        }
    }
}
