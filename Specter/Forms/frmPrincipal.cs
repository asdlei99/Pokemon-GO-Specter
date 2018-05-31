using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using PokemonGo.RocketAPI.Enums;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using Specter.ApiPokedex;
using Specter.Forms;
using Specter.MODEL;
using Specter.PokemonGO;
using Specter.Util;
using Form = System.Windows.Forms.Form;

namespace Specter.FORMS
{
    public partial class FrmPrincipal : Form
    {
        public static readonly string[] PokemonNames = Enum.GetNames(typeof(PokemonId));
            

        private async void SetInitialSettingsUi()
        {
            // Set NLogger

            NLogger.Setconfig();
            SayLog = LogManager.GetLogger("SPECTER:");

            // CHECK IF ITS THE FIRST TIME OPENING SPECTER

            if (UserGlobalConfiguration.MessageWelcome)
            {
                frmWelcome openGreetings = new frmWelcome();
                openGreetings.Show();
            }
            if (PokemonRaro.PokemonRaro.IsPaidUserver == 0)
                cbIv100.Enabled = false;

            //VERIFY THE LIMIT OF POKEMON BEFORE CONTINUE
            if (await PokemonRaro.PokemonRaro.VerificaLimitePokemon())
            {
                btnProcurarPokemon.Enabled = false;
                menuSnipe.Enabled = false;
            }

            //--------------------------------------------
            //SET VALUES ON SCREEEN
            cbPokebola.SelectedIndex = 0; // Select Pokeball
            lblVersionValue.Text =
                string.Format($"{PokemonRaro.PokemonRaro.SpecterVersion}"); //Print Specter Version on screen    

            lblApiValue.Text = PogoGlobalSettings.SpecterApiVersion;

            lblTotalCapturado.Text =
                string.Format(
                    $"{PokemonRaro.PokemonRaro.PokemonCaught} Total | {PokemonRaro.PokemonRaro.PokemonMax} Max");
            lblEscapadoValue.Text =
                string.Format($"{PokemonRaro.PokemonRaro.PokemonFlee}");

            UpdateLastPokemonCaught(true);

            // ---------------------------------------------
            // LOAD INFORMATION FROM .JSON

            txtPogoUsername.Text = UserGlobalConfiguration.Username;
            txtPogoPassword.Text = UserGlobalConfiguration.Password;
            if (UserGlobalConfiguration.TypeAcc.ToString().ToUpper() == "PTC")
                rbPTC.Checked = true;
            else
                rbGoogle.Checked = true;


            //----------------------------------------------

            //PRINT THE MESSAGE FROM THE SERVER
            await PokemonRaro.PokemonRaro.GetStartMessagesFromTheServer(1);
            //----------------------------------------------

            // Check if the gameversion its updated.
            CheckGameVersion();

            // Works with auto complete textbox
            AutoCompleteStringCollection collectionNamesPokemon = new AutoCompleteStringCollection();
            collectionNamesPokemon.AddRange(PokemonNames);
            txtProcuraPoke.AutoCompleteCustomSource = collectionNamesPokemon;

            FrmCapturaManual.ThresholdReached += FrmCapturaManual_ThresholdReached;
        }

        private void FrmCapturaManual_ThresholdReached(object sender, EventArgs e)
        {
            UpdateLastPokemonCaught(false);
        }

    

        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (!FieldErrorCheck("login"))
                return;


            try
            {
                SayLog.Info("Processo de login iniciado! Isso pode levar alguns segundos, aguarde...");
                //Check if account its PTC / Google.
                if (rbGoogle.Checked)
                    PogoGlobalSettings.PogoClient =
                        await PogoClient.GetClient(txtPogoUsername.Text, txtPogoPassword.Text, AuthType.Google);

                else if (rbPTC.Checked)
                    PogoGlobalSettings.PogoClient =
                        await PogoClient.GetClient(txtPogoUsername.Text, txtPogoPassword.Text, AuthType.Ptc);
            }
            catch (Exception)
            {
                SayLog.Error("Falha no login...");
                return;
            }

            if (PogoGlobalSettings.PogoClient.Player.PlayerData == null)
            {
                SayLog.Fatal(
                    "Infelizmente a conta informada aparenta estar temporariamente suspensa. Tente outra conta.");
                return;
            }


            SayLog.Debug("Logado com sucesso!");
            PogoGlobalSettings.PogoClient.Inventory.OnInventoryUpdated += Inventory_OnInventoryUpdated;
            btnLogout.Enabled = true;
            btnLogin.Enabled = false;
            UpdatePlayerStatistic();
            timerAtualizaStatus.Enabled = true;


            //Save settings updated to file
            UserGlobalConfiguration.Username = txtPogoUsername.Text;
            UserGlobalConfiguration.Password = txtPogoPassword.Text;
            if(rbGoogle.Checked)
                UserGlobalConfiguration.TypeAcc = AuthType.Google;
            else
                UserGlobalConfiguration.TypeAcc = AuthType.Ptc;

            UserGlobalConfiguration.SaveSettingsFromUser();
        }

        private void Inventory_OnInventoryUpdated()
        {
            UpdatePlayerStatistic();
        }




        /// <summary>
        ///     Update Player Details on UI
        /// </summary>
        private async void UpdatePlayerStatistic()
        {
            await Task.Run(() =>
            {
                Invoke((MethodInvoker) delegate
                {
                    //Panel Left
                    lblNomeValue.Text = PogoGlobalSettings.PlayerName;
                    lblTimeValue.Text = PogoGlobalSettings.PlayerTeam;

                    lblMochilaValue.Text =
                        string.Format(
                            $"{PogoGlobalSettings.PlayerTotalPokemons}/{PogoGlobalSettings.PlayerAvailableStoragePokemons}");
                    
                    lblPokebolasValue.Text = PogoGlobalSettings.PlayerTotalPokeballs.ToString();

                    // Panel Right

                    lblTotalCapturado.Text =
                        string.Format(
                            $"{PokemonRaro.PokemonRaro.PokemonCaught} Total | {PokemonRaro.PokemonRaro.PokemonMax} Max");

                    lblEscapadoValue.Text =
                        string.Format($"{PokemonRaro.PokemonRaro.PokemonFlee}");

                    if (PokemonRaro.PokemonRaro.PokemonCaught >= PokemonRaro.PokemonRaro.PokemonMax)
                    {
                        btnLogin.Enabled = false;
                        btnProcurarPokemon.Enabled = false;
                        menuSniperCatchManual.Enabled = false;
                        menuSniperGoldenBerry.Enabled = false;
                        menuSniperCatchStandard.Enabled = false;
                        menuSniperRazzBerry.Enabled = false;
                        menuSniperPinapBerry.Enabled = false;
                        menuSniperRazzBerry.Enabled = false;

                        SayLog.Warn("Limite de Pokémons atingido, realize a compra de uma nova chave!");
                    }

                    //Menu Strip info
                    menuSniperRazzBerry.Text =
                        string.Format($"CAPTURAR [RazzBerry] ({PogoGlobalSettings.PlayerTotalRazzBerry})");

                    menuSniperPinapBerry.Text =
                        string.Format($"CAPTURAR [Pinap Berry]  ({PogoGlobalSettings.PlayerTotalPinapBerry})");

                    menuSniperNanaBerry.Text =
                        string.Format(
                            $"CAPTURAR [Nana Berry]  ({PogoGlobalSettings.PlayerTotalNanaBerry})");

                    menuSniperGoldenBerry.Text =
                        string.Format($"CAPTURAR [Golden Berry]  ({PogoGlobalSettings.PlayerTotalNanaBerry})");
                });
            });
        }


        // DESLOGAR DO JOGO
        private async void btnDeslogar_Click(object sender, EventArgs e)
        {
            if (!PogoGlobalSettings.PogoClient.AccessToken.IsExpired)
            {
                //TODO: CANCEL THE HTTP CLIENT
                SayLog.Info("Deslogando...");
                await Task.Delay(3000);

                //TODO: VERY IF WE LOGOUT WITH SUCESS
                SayLog.Debug("Deslogado com sucesso!");

                btnLogout.Enabled = false;
                btnLogin.Enabled = true;

                lblNomeValue.Text = "0";
                lblMochilaValue.Text = "0";
                lblTimeValue.Text = "0";
                lblPokebolasValue.Text = "0";
            }
        }


        private void timerAtualizaStatus_Tick(object sender, EventArgs e)
        {
            UpdatePlayerStatistic();
        }

        private async void SnipePokemon(ItemId pokebolaId, ItemId berryId)
        {
            if (!FieldErrorCheck("snipePokemon")) return;

            PokemonId pokemon;
            Enum.TryParse(Convert.ToString(gridPokemons.CurrentRow.Cells[cName.DisplayIndex].FormattedValue), true,
                out pokemon);
            var cLatitudes = Convert.ToDouble(gridPokemons.CurrentRow.Cells[cLatitude.DisplayIndex].FormattedValue);
            var cLongitudes = Convert.ToDouble(gridPokemons.CurrentRow.Cells[cLongitude.DisplayIndex].FormattedValue);

            SayLog.Info($"Capturando {pokemon} na localização {cLatitudes},{cLongitudes}. Aguarde!");
            try
            {
                if (await PogoCatchPokemon.CatchPokemon(pokemon, cLatitudes, cLongitudes, pokebolaId, berryId))
                {
                    UpdateLastPokemonCaught(false);
                }
            }
            catch (Exception e)
            {
                SayLog.Error(e.Message + e.StackTrace);
            }
        }

        private async void UpdateLastPokemonCaught(bool isLoginJustHappened)
        {
            if (isLoginJustHappened)
            {
                var list = await PokemonRaro.PokemonRaro.GetPokemonLastCaught();
                if (list == null || list[0] == "none")
                    return;

                lblLastPogoName.Text = list[1];
                lblLastPogoDate.Text = list[3];
                lblLastPogoInfo.Text = list[2];

                imgPokemonLastCaught.Image = Image.FromFile(@"Images\pokemons\" + list[0] + ".png");
            }
            else
            {
                lblLastPogoName.Text = PogoCatchPokemon.LastCatchName;
                lblLastPogoDate.Text = PogoCatchPokemon.LastCatchDate.ToString();
                lblLastPogoInfo.Text = PogoCatchPokemon.LastCatchInfo;

                imgPokemonLastCaught.Image = Image.FromFile(@"Images\pokemons\" + PogoCatchPokemon.LastCatchNumber + ".png");
            }

        }



        private ItemId GetSelectedPokeball()
        {
            switch (cbPokebola.SelectedIndex)
            {
                case 1: return ItemId.ItemPokeBall;
                case 2: return ItemId.ItemGreatBall;
                case 3: return ItemId.ItemUltraBall;
                case 4: return ItemId.ItemMasterBall;
                case 5: return ItemId.ItemPremierBall;
                default:
                    return ItemId.ItemPokeBall;
            }
        }

        private async void CheckGameVersion()
        {
            if (PogoGlobalSettings.SpecterApiVersion != PogoGlobalSettings.GameApiVersion)
            {
                MessageBox.Show(
                    $"O Pokémon GO foi atualizado para a versão [{PogoGlobalSettings.GameApiVersion}], entretanto o Specter ainda se encontra" +
                    $"na versão [{PogoGlobalSettings.SpecterApiVersion}]. Aguarde a proxima atualização.",
                    "Atualização Necessária", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnLogin.Enabled = false;
                btnProcurarPokemon.Enabled = false;
                await Task.Delay(5000);
                Environment.Exit(0);
            }
        }

        //PROCURAR POKÉMON
        private async void btnProcurarPokemon_Click(object sender, EventArgs e)
        {

            if (!FieldErrorCheck("searchPokemon"))
                return;

            timerUpdateGrid.Enabled = false;
            timerUpdateGrid.Stop();

            gridPokemons.Rows.Clear();
            btnProcurarPokemon.Enabled = false;
            txtProcuraPoke.Enabled = false;
            btnProcurarPokemon.Text = "PROCURANDO";
            PokemonAttributes pokemonList = null;

            try
            {
                if (cbIv100.Checked)
                {
                    pokemonList =
                        await PesquisaPokemon.SearchPokemon(true, (int)Enum.Parse(typeof(PokemonId), txtProcuraPoke.Text));
                }

                else
                    pokemonList =
                        await PesquisaPokemon.SearchPokemon(false,
                            (int)Enum.Parse(typeof(PokemonId), txtProcuraPoke.Text));

                if (pokemonList == null)
                {
                    timerUpdateGrid.Enabled = true;
                    timerUpdateGrid.Start();
                    btnProcurarPokemon.Enabled = true;
                    txtProcuraPoke.Enabled = true;
                    btnProcurarPokemon.Text = "PROCURAR";
                    return;
                }

                    
                
            }
            catch (Exception exception)
            {
                SayLog.Error(exception.Message + exception.StackTrace);
                return;
            }                      


            var countryImage = new DataGridViewImageColumn();
            countryImage.Description = "image";
            countryImage.ImageLayout = DataGridViewImageCellLayout.Normal;

            var pokemonIcon = new DataGridViewImageColumn();
            pokemonIcon.Description = "image";
            pokemonIcon.ImageLayout = DataGridViewImageCellLayout.Stretch;

            foreach (var pokemon in pokemonList.PokemonAtribbutes)
            {
                if (pokemon == null)
                    continue;

                if (!string.IsNullOrEmpty(pokemon.Country))
                {
                    try
                    {
                        var imagePathCountry = @"Images\flags\" + pokemon.Country + ".gif";
                        var imagePathIcon = @"Images\pokemons\" + pokemon.Number + ".png";
                        countryImage.Image = Image.FromFile(imagePathCountry);
                        pokemonIcon.Image = Image.FromFile(imagePathIcon);

                        gridPokemons.Rows.Add(pokemonIcon.Image, pokemon.Number, pokemon.Name, countryImage.Image,
                            pokemon.Iv, pokemon.Cp, pokemon.TimeLeft, pokemon.Latitude, pokemon.Longitude,
                            PesquisaPokemon.CalculateTimeLeft(PogoGlobalSettings.PlayerLatitude,
                                PogoGlobalSettings.PlayerLongitude, pokemon.Latitude, pokemon.Longitude).ToString());
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        SayLog.Error(exception.Message + "\t" + exception.StackTrace);
                    }
                }
                else
                {
                    var imagePathCountry = @"Images\flags\bra.gif";
                    var imagePathIcon = @"Images\pokemons\" + pokemon.Number + ".png";

                    countryImage.Image = Image.FromFile(imagePathCountry);
                    pokemonIcon.Image = Image.FromFile(imagePathIcon);
                    gridPokemons.Rows.Add(pokemonIcon.Image, pokemon.Number, pokemon.Name, countryImage.Image,
                        pokemon.Iv, pokemon.Cp, pokemon.TimeLeft, pokemon.Latitude, pokemon.Longitude,
                        PesquisaPokemon.CalculateTimeLeft(PogoGlobalSettings.PlayerLatitude,
                            PogoGlobalSettings.PlayerLongitude, pokemon.Latitude, pokemon.Longitude).ToString());
                }
            }


            timerUpdateGrid.Enabled = true;
            timerUpdateGrid.Start();
            btnProcurarPokemon.Enabled = true;
            txtProcuraPoke.Enabled = true;
            btnProcurarPokemon.Text = "PROCURAR";
        }




        #region VERIFICAÇÃO DE ERROS UI

        private bool FieldErrorCheck(string type)
        {
            switch (type)
            {
                case "login":
                    if (txtPogoUsername.Text == string.Empty || txtPogoPassword.Text == string.Empty)
                    {
                        SayLog.Warn("Existem campo(s) em branco. Verifque seu usuario e senha.");
                        return false;
                    }
                    else if (rbGoogle.Checked == false && rbPTC.Checked == false)
                    {
                        SayLog.Warn(
                            "Você esqueceu de selecionar se sua conta é Google ou PTC. Selecione e realize o login novamente.");
                        return false;
                    }

                    return true;
                case "searchPokemon":

                    var isPokemonInList = false;
                    foreach (string pokemonName in PokemonNames)
                    {
                        if (pokemonName == txtProcuraPoke.Text)
                            isPokemonInList = true;
                    }  

                    if (!isPokemonInList)
                    {
                        SayLog.Warn("Você digitou o nome do Pokémon incorretamente.");
                        return false;
                    }
                    if (PogoGlobalSettings.PogoClient == null)
                    {
                        SayLog.Warn("Realize o login antes de iniciar a procura de Pokémon.");
                        return false;
                    }
                    else if (txtProcuraPoke.Text == string.Empty)
                    {
                        SayLog.Warn("Você não especificou o nome do Pokémon. Digite novamente.");
                        return false;
                    }
                    else if (btnAutoCatch.Value)
                    {
                        SayLog.Warn("Desative a captura automatica.");
                        return false;
                    }
                    return true;
                case "snipePokemon":
                    if (PogoGlobalSettings.PogoClient == null)
                    {
                        SayLog.Warn("Realize o login antes de iniciar a captura do Pokemon.");
                        return false;
                    }
                    return true;
                default:
                    return true;
            }
        }

        #endregion


        private void timerUpdateGrid_Tick(object sender, EventArgs e)
        {
            for (var i = 0; i < gridPokemons.RowCount; i++)
            {
                var timeLeftCatch = TimeSpan.Parse(gridPokemons[cCatchTime.Index, i].Value.ToString());


                if (timeLeftCatch.TotalSeconds == 0)
                    gridPokemons["cCatchTime", i].Style.BackColor = Color.ForestGreen;
                if (timeLeftCatch.TotalSeconds > 0)
                    gridPokemons["cCatchTime", i].Value =
                        TimeSpan.Parse(gridPokemons["cCatchTime", i].Value.ToString())
                            .Subtract(new TimeSpan(0, 0, 0, 0, 1000)).ToString(@"hh\:mm\:ss");
            }
        }

        #region Prop / Global variables

        private readonly FrmCapturaManual _openCaptura = new FrmCapturaManual();
        private static Logger SayLog;
        FrmCapturaManual _frmCapturaManual = new FrmCapturaManual();

        #endregion


        #region Context Menu Sniper

        // Catch Standard
        private void menuSniperCatchStandard_Click(object sender, EventArgs e)
        {
            SnipePokemon(ItemId.ItemPokeBall, ItemId.ItemUnknown);
        }

        // Catch With Razz Berry
        private void menuSniperRazzBerry_Click(object sender, EventArgs e)
        {
            SnipePokemon(GetSelectedPokeball(), ItemId.ItemRazzBerry);
        }

        // Catch With Pinap Berry
        private void menuSniperPinapBerry_Click(object sender, EventArgs e)
        {
            SnipePokemon(GetSelectedPokeball(), ItemId.ItemPinapBerry);
        }

        // Catch With Nana Berry
        private void menuSniperNanaBerry_Click(object sender, EventArgs e)
        {
            SnipePokemon(GetSelectedPokeball(), ItemId.ItemNanabBerry);
        }

        // Catch With Gold Berry
        private void menuSniperGoldenBerry_Click(object sender, EventArgs e)
        {
            SnipePokemon(GetSelectedPokeball(), ItemId.ItemGoldenRazzBerry);
        }

        // Copiar coordenadas
        private void cOPIARCOORDENADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Clipboard.SetText(string.Format(
                $"{gridPokemons.CurrentRow.Cells[cName.DisplayIndex].FormattedValue},{double.Parse(gridPokemons.CurrentRow.Cells[cLatitude.DisplayIndex].FormattedValue.ToString())},{double.Parse(gridPokemons.CurrentRow.Cells[cLongitude.DisplayIndex].FormattedValue.ToString())}"));
        }

        private void menuSnipe_Opened(object sender, EventArgs e)
        {
            menuSniperCopyCoordinates.Enabled = gridPokemons.Rows.Count > 0;
        }

        #endregion


        #region CATCH POKEMONS MENU BUTTONS


        #endregion


        #region OPEN LINKS

        private void linkPaginaOficial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://SeuSite/loja/chave-sistema-specter/");
        }

        private void linkComprarChave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://SeuSite/produto/chave-sistema-specter/");
        }

        private void linkGerarSenhaApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://SeuSite/como-gerar-uma-senha-de-app-google/");
        }

        private void linkNomePokemons_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://SeuSite/nome-pokemons-specter/");
        }

        private void linkErrorBugs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://SeuSite/erros-solucoes-specter/");
        }

        #endregion


        #region WindowSettings and Prop

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion


        #region Constructors and LoadForms

        public FrmPrincipal()
        {
            // We need to set this to get correct cordinates
            
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            SetInitialSettingsUi();
        }

        #endregion

        private void menuSniperCatchManual_Click(object sender, EventArgs e)
        {
            _frmCapturaManual.Show();
        }

        private void btnConfigurarAutoCatch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta opção está em desenvolvimento, somente Beta-Tester podem utiliza-la.","ATENÇÃO");
        }

    }
}