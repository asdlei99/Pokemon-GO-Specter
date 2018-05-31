using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;
using Specter.PokemonGO;

namespace Specter.PokemonRaro
{
    public class PokemonRaro
    {
        #region Fields
        private static Logger SayLog;

        #endregion

        #region Propriedades
        private static bool IsServerOnline { get; set; }

        public static string BosslandHashKey
        {
            get
            {
                string result = string.Empty;

                using (var downloadData = new WebClient())
                {
                    
                    try
                    {
                        Task.Run(async delegate
                        {
                            result = await downloadData.DownloadStringTaskAsync(
                                "https://SeuSite/pogoraro_api/stringHash.php?hash=1");
                        }).GetAwaiter().GetResult();
                    }
                    catch (Exception e)
                    {
                        SayLog.Error(e.Source + e.StackTrace);
                    }
                }
                return result;
            }
        }

        public static string PokemonRaroKey { get; set; }
        public static int PokemonCaught { get; set; }
        public static int PokemonMax { get; set; }
        public static int PokemonFlee { get; set; }
        public static int IsPaidUserver { get; set; }
        public static string SpecterVersion => "3.1";

        #endregion

        #region Constructors
        #endregion

        #region Methods
        // Do the Login
        public static async Task<bool> DoLogin(string userAcesscode)
        {
            SayLog = LogManager.GetLogger("SERVER:");

            if (IsServerOnline)
            {
                if (!await GetVersion()) return false;

                try
                {
                    using (var downloadData = new WebClient())
                    {
                        var resultQuery =
                            await downloadData.DownloadStringTaskAsync(String.Format(
                                $"https://SeuSite/pogoraro_api/login.php?codigoCompra={userAcesscode}"));
                        var splitQuery = resultQuery.Split(',');
                        PokemonRaroKey = userAcesscode;

                        do
                        {
                            switch (splitQuery[0])
                            {
                                case "none":
                                    MessageBox.Show(
                                        "A chave que você informou parece estar incorreta.\nVerifique e tente novamente.",
                                        "CHAVE DE ACESSO INCORRETA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                case "0":
                                    MessageBox.Show(
                                        "Seu código foi desativado pelo Pokémon Raro.!\nCaso você acha que isso tenha sido um erro entre em contato.",
                                        "CODIGO DESATIVADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                case "1":
                                    MessageBox.Show("Sua chave expirou!\nCompre uma nova chave para continuar utilizando.",
                                        "CHAVE EXPIRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    return false;
                                default:
                                    IsPaidUserver = int.Parse(splitQuery[1]);
                                    if (await VerificaLimitePokemon())
                                        break;

                                    return true;
                            }
                        } while (await VerificaLimitePokemon());

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "ERROR");
                }
                
            }
            return false;
        }

        //Check server Stats - Online / Offline
        public static async Task<bool> CheckServerState()
        {
            try
            {
                using (var downloadData = new WebClient())
                {
                    var resultQuery =
                        await downloadData.DownloadStringTaskAsync("https://SeuSite/pogoraro_api/online.php");

                    switch (resultQuery)
                    {
                        case "":
                            IsServerOnline = true;
                            return true;
                        default:
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR");
                return false;
            }
            
        }


        // Get the version from database
        public static async Task<bool> GetVersion()
        {
            try
            {
                using (var downloadData = new WebClient())
                {
                    var resultQuery = await downloadData.DownloadStringTaskAsync(String.Format($"https://SeuSite/pogoraro_api/getVersion.php?version={SpecterVersion}"));
                    switch (resultQuery)
                    {
                        case "ativado":
                            return true;
                        default:
                            MessageBox.Show("Esta versão do Specter se encontra desatualizada.\nFaça download da nova versão para continuar utilizando.", "VERSÃO DESATUALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            Process.Start("https://SeuSite/loja/chave-sistema-specter/");
                            return false;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR");
                return false;
            }
 
        }


        // Starting Message / Updates logs message
        public static async Task GetStartMessagesFromTheServer(int optionSelect)
        {
            try
            {
                using (var downloadData = new WebClient())
                {
                    List<string> querySplit;

                    if (optionSelect == 1)
                    {
                        string resultQuery =
                            await downloadData.DownloadStringTaskAsync(
                                "https://SeuSite/pogoraro_api/message.php?id=1");
                        querySplit = resultQuery.Split('>').ToList();
                        SayLog.Info(
                            $"Seja bem vindo a versão ({SpecterVersion})!.");
                    }
                    else
                    {
                        string resultQuery =
                            await downloadData.DownloadStringTaskAsync(
                                "https://SeuSite/pogoraro_api/updates.php?id=1");
                        querySplit = resultQuery.Split('>').ToList();
                    }

                    string messageFromServer = "";
                    foreach (var item in querySplit)
                    {
                        messageFromServer = messageFromServer + item + "\n";
                    }

                    SayLog.Debug(messageFromServer);

                }
            }
            catch (Exception e)
            {
                SayLog.Error(e.Message);
            }
            
        }

        //Get Total Limite Pokémons
        public static async Task GetTotalLimitePokemon()
        {
            try
            {
                using (var downloadData = new WebClient())
                {
                    string resultQuery =
                        await downloadData.DownloadStringTaskAsync(String.Format(
                            $"https://SeuSite/pogoraro_api/totalPokemon.php?codigoCompra={PokemonRaroKey}"));
                    var resultadoMinEMax = resultQuery.Split(',');
                    PokemonCaught = Convert.ToInt32(resultadoMinEMax[0]);
                    PokemonMax = Convert.ToInt32(resultadoMinEMax[1]);
                    PokemonFlee = Convert.ToInt32(resultadoMinEMax[2]);
                }
            }
            catch (Exception e)
            {
                SayLog.Error(e.Message, "ERROR");
            }

        }

        //Increase Pokemon Caught count when Sniped
        public static async Task PokemonCaughtSucess()
        {
            try
            {
                await GetTotalLimitePokemon();

                using (var downloadData = new WebClient())
                {
                    string resultQuery = await downloadData.DownloadStringTaskAsync(String.Format($"https://SeuSite/pogoraro_api/PokemonCaughtSucess.php?codigoCompra={PokemonRaroKey}"));
                    if (resultQuery != "1")
                    {
                        SayLog.Error("Não foi possível se conectar ao banco de dados, portanto nós estamos finalizando a aplicação.");
                        await Task.Delay(5000);
                        Environment.Exit(0);
                    }
                    await GetTotalLimitePokemon();
                }
            }
            catch (Exception e)
            {
                SayLog.Error(e.Message, e.StackTrace);
            }
        }

        //Increase Pokemon fail count when Sniped
        public static async Task PokemonCaughtFail()
        {
            try
            {
                await GetTotalLimitePokemon();

                using (var downloadData = new WebClient())
                {
                    string resultQuery = await downloadData.DownloadStringTaskAsync(String.Format($"https://SeuSite/pogoraro_api/PokemonCaughtFail.php?codigoCompra={PokemonRaroKey}"));
                    if (resultQuery != "1")
                    {
                        SayLog.Error("Não foi possível se conectar ao banco de dados, portanto nós estamos finalizando a aplicação.");
                        await Task.Delay(5000);
                        Environment.Exit(0);
                    }
                    await GetTotalLimitePokemon();
                }
            }
            catch (Exception e)
            {
                SayLog.Error(e.Message, e.StackTrace);
            }
        }


        // Check if Reached the Limit of key
        public static async Task<bool> VerificaLimitePokemon()
        {
            try
            {
                await GetTotalLimitePokemon();
                if (PokemonMax <= PokemonCaught)
                {
                    SayLog.Warn(String.Format($"Sua chave expirou [{PokemonCaught}]/[Max:{PokemonMax}]"));
                    return true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"Error");
            }
            
            return false;
        }


        public static async Task<bool> SendFailGetApiPodex(string key)
        {
            using (var pushData = new WebClient())
            {
                var result = await pushData.DownloadStringTaskAsync($"https://SeuSite/pogoraro_api/updatePokexFail.php?id={key}");

                if (result == "sucess")
                    return true;
            }
            return false;
        }

        public static async Task<string> PokedexApiFree()
        {
            try
            {
                using (WebClient downloadData = new WebClient())
                {
                    var key = await downloadData.DownloadStringTaskAsync(
                        "https://SeuSite/pogoraro_api/apiPokedex.php");

                    return key;
                }
            }
            catch (Exception e)
            {
                SayLog.Error(e.Message);
                return null;
            }            
        }

        public static async Task SendPokemonLogToDatabase()
        {
            try
            {
                using (WebClient pushData = new WebClient())
                {
                    var sucess =
                        await pushData.DownloadStringTaskAsync(string.Format(
                            $"https://SeuSite/pogoraro_api/sendPokemonData.php?userId={PokemonRaroKey}&pNumber={PogoCatchPokemon.LastCatchNumber}&pNome={PogoCatchPokemon.LastCatchName}&pInfo={PogoCatchPokemon.LastCatchInfo}&pLatitude={PogoCatchPokemon.LastCatchLat}&pLongitude={PogoCatchPokemon.LastCatchLong}&pTimeLeft={PogoCatchPokemon.LastCatchDate:s}"));
                }
            }
            catch (Exception e)
            {
                SayLog.Debug(e.Message + e.Message);
            }
        }

        public static async Task<List<string>> GetPokemonLastCaught()
        {
            try
            {
                using (WebClient requestData = new WebClient())
                {
                    var dataReceived =
                        await requestData.DownloadStringTaskAsync(
                            $"https://SeuSite/pogoraro_api/getPogoLastCaught.php?codigoCompra={PokemonRaroKey}");

                    var splitDataReceived = dataReceived.Split('*').ToList();
                    return splitDataReceived;
                }
            }
            catch (Exception e)
            {
                SayLog.Error(e.Message + e.StackTrace);
            }

            return null;
        }


        #endregion
    }
}
