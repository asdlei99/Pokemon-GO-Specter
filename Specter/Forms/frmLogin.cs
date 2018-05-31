using Specter.FORMS;
using Specter.MODEL;
using System;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Windows.Forms;
using System.Resources;
using System.Threading;
using System.Reflection;

namespace Specter
{
    public partial class frmLogin : Form
    {



        // Global variaveis
        private int allowVersion = 0;
        public frmLogin()
        {
            if (Convert.ToString(CultureInfo.CurrentCulture) == "pt-BR")
            {
                Configuracoes.cul = CultureInfo.CreateSpecificCulture("pt-BR");
                Configuracoes.res_man = new ResourceManager("Specter.LINGUA.pt-br", Configuracoes.language);
            }
            else
            {
                CultureInfo cul = CultureInfo.CreateSpecificCulture("en-US");
                Configuracoes.res_man = new ResourceManager("Specter.LINGUA.funciona", Configuracoes.language);
                
            }

            InitializeComponent();
            cbLingua.SelectedIndex = 0;
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            verificaConexao();
            verificaVersao();
        }

        // Button Click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (allowVersion == 1)
                realizaLogin();
            else
                MessageBox.Show(Configuracoes.res_man.GetString("frmlogin_versao_Desatualizada_pt1", Configuracoes.cul), Configuracoes.res_man.GetString("frmlogin_versao_Desatualizada_pt2", Configuracoes.cul), MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }


        //Sai do programa
        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }



        //Inicia login
        private async void realizaLogin()
        {
            if (lblEstadoServerValue.Text == "Conectado.")
            {
                WebClient clienteWeb = new WebClient();
                string resultadoString = await clienteWeb.DownloadStringTaskAsync(string.Format($"https://pokemonraro.com/pogoraro_api/login.php?codigoCompra={txtCodigoPokemonRaro.Text}"));

                //Se não o codigo não existir, retorna 'none'
                if (resultadoString == "none")
                {
                    MessageBox.Show(Configuracoes.res_man.GetString("frmlogin_chave_wrong_pt1", Configuracoes.cul), Configuracoes.res_man.GetString("frmlogin_chave_wrong_pt2", Configuracoes.cul), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoPokemonRaro.Clear();
                }
                //Se o codigo tiver sido desativado retorna 0;
                else if (resultadoString == "0")
                {
                    MessageBox.Show(Configuracoes.res_man.GetString("frmlogin_chave_disabled_pt1", Configuracoes.cul), Configuracoes.res_man.GetString("frmlogin_chave_disabled_pt2", Configuracoes.cul), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoPokemonRaro.Clear();
                }
                else if (resultadoString == "1")
                {
                    MessageBox.Show(Configuracoes.res_man.GetString("frmlogin_chave_expirada_pt1", Configuracoes.cul), Configuracoes.res_man.GetString("frmlogin_chave_expirada_pt2", Configuracoes.cul), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoPokemonRaro.Clear();
                }
                else
                {
                    Configuracoes.apiPokedex = await clienteWeb.DownloadStringTaskAsync("https://pokemonraro.com/pogoraro_api/apiPokedex.php?chave=1");
                    Configuracoes.codigoCompra = txtCodigoPokemonRaro.Text;


                    //switch (cbLingua.SelectedIndex)
                    //{
                    //    case 0:
                    //        Configuracoes.cul = CultureInfo.CreateSpecificCulture("pt-BR");
                    //        Configuracoes.res_man = new ResourceManager("Specter.LINGUA.pt-br", Configuracoes.language);
                    //        break;
                    //    case 1:
                    //        Configuracoes.cul = CultureInfo.CreateSpecificCulture("en");
                    //        Configuracoes.res_man = new ResourceManager("Specter.LINGUA.en", Configuracoes.language);
                    //        break;
                    //    case 2:
                    //        Configuracoes.cul = CultureInfo.CreateSpecificCulture("es");
                    //        Configuracoes.res_man = new ResourceManager("Specter.LINGUA.pt-br", Configuracoes.language);
                    //        break;
                    //    default:
                    //        Configuracoes.cul = CultureInfo.CreateSpecificCulture("pt-BR");
                    //        Configuracoes.res_man = new ResourceManager("Specter.LINGUA.pt-br", Configuracoes.language);
                    //        break;
                    //}


                    Form frmPrincipalAbrir = new frmPrincipal();
                    frmPrincipalAbrir.Show();
                    this.Hide();
                }
            }
        }

        //Verifica versão atual do Specter
        private async void verificaVersao()
        {
            WebClient clienteWeb = new WebClient();

            var resultadoString = await clienteWeb.DownloadStringTaskAsync(string.Format($"https://pokemonraro.com/pogoraro_api/getVersion.php?version={Configuracoes.versãoAtual}"));
            if (resultadoString == "ativado")
            {
                lblVersaoValue.Text = string.Format($"{Configuracoes.versãoAtual} Beta.");
                allowVersion = 1;
            }
            else
            {
                lblDesatualizada.Visible = true;
                lblDesatualizadaValue.Visible = true;

                lblVersaoValue.Visible = false;
                lblVersion.Visible = false;
            }
        }

        //Verifica estado da conexão
        private async void verificaConexao()
        {
            WebClient clienteWeb = new WebClient();

            var resultadoString = await clienteWeb.DownloadStringTaskAsync(string.Format($"https://pokemonraro.com/pogoraro_api/online.php"));
            if (resultadoString == string.Empty)
            {
                lblEstadoServerValue.ForeColor = Color.LightGreen;
                lblEstadoServerValue.Text = Configuracoes.res_man.GetString("frmlogin_Conectado", Configuracoes.cul);
            }
            else
            {
                lblVersaoValue.ForeColor = Color.Red;
                lblVersaoValue.Text = string.Format($"{resultadoString}");
            }
        }


    }
}