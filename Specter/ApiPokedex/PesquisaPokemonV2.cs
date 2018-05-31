//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Discord;
//using Discord.Net.Providers.WS4Net;
//using Discord.Net.WebSockets;
//using Discord.WebSocket;
//using POGOProtos.Enums;

//namespace Specter.MODEL
//{
//    public class PesquisaPokemonV2
//    {

//        #region Prop and Constructor

//        private string _userToken;
//        public DiscordSocketClient _client;
//        public List<string> PokemonList = new List<string>();
//        public AutoCompleteStringCollection PokemonNames = new AutoCompleteStringCollection();
//        private ulong _guildNum = 252776251708801024;
//        private ulong _channelNum = 279813108938047488;



//        public PesquisaPokemonV2()
//        {
//            var WebSocketProvider = WS4NetProvider.Instance;

//            _client = new DiscordSocketClient(new DiscordSocketConfig
//            {
//                WebSocketProvider = Discord.Net.Providers.WS4Net.WS4NetProvider.Instance
//            });

//            //_client = new DiscordSocketClient();
//            _client.MessageReceived += DiscordMessageReceived;
//            _client.Disconnected += DiscordDisconected;
//            FillListPokemonNames();

//        }


//        private Task _client_Log(LogMessage arg)
//        {
//            nLogger.Info(string.Format($"Message: {arg.Message} Exception: {arg.Exception} Source: {arg.Source}"));
//            return null;
//        }

//        #endregion

//        #region Login / Logout

//        private async Task GetTokenFromServer()
//        {
//            using (var downloadData = new WebClient())
//            {
//                _userToken = await downloadData.DownloadStringTaskAsync("https://SeuSite/pogoraro_api/apiPokedex.php");
//            }
//        }

//        private async void UploadBlockedStatus(string token)
//        {
//            using (var downloadData = new WebClient())
//            {
//                try
//                {
//                    await downloadData.DownloadStringTaskAsync(
//                        string.Format($"https://SeuSite/pogoraro_api/updatePokexFail.php?id='{token}'"));
//                }
//                catch (Exception e)
//                {
//                    nLogger.Erro(string.Format($"Erro ao tentar enviar chave bloqueada para o servidor. {e.Message} {e.StackTrace}"));
//                }

//                if (_client.ConnectionState == ConnectionState.Connected || _client.LoginState == LoginState.LoggedIn)
//                    await LogoutSession();

//                await StartSession();
//                nLogger.Erro("Ocorreu um erro na pesquisa do Pokémon, tente novamente.");

//            }
//        }


//        public async Task StartSession()
//        {
//            nLogger.Info("Iniciando login no servidor de coordenadas...");

//            try
//            {
//                await GetTokenFromServer();
//                await _client.LoginAsync(TokenType.User, _userToken);

//                if (_client.LoginState.Equals(LoginState.LoggedIn))
//                    await _client.StartAsync();
//                nLogger.Sucesso("Logado ao servidor de coordenada com sucesso!");
//            }
//            catch (Exception erroLogin)
//            {
//                nLogger.Erro(string.Format($"{erroLogin.Data} {erroLogin.Message} { erroLogin.StackTrace}"));
//            }
//        }

//        public async Task LogoutSession()
//        {
//            try
//            {
//                await _client.LogoutAsync();
//                await _client.StopAsync();
//                nLogger.Sucesso("Deslogado dos servidores de coordenadas.");
//            }
//            catch (Exception errorLogout)
//            {
//                nLogger.Erro(string.Format($"{errorLogout.Data} {errorLogout.Message} { errorLogout.StackTrace}"));
//            }
//        }
//        #endregion

//        private void FillListPokemonNames()
//        {
//            foreach (string pokemonName in Enum.GetNames(typeof(PokemonId)))
//            {
//                PokemonNames.Add(pokemonName);
//            }
//        }

//        public async Task SearchPokemon(string pokemonName)
//        {
//            if (_client.ConnectionState == ConnectionState.Connected && _client.LoginState == LoginState.LoggedIn)
//            {
//                try
//                {
//                    SocketGuild Guild = _client.GetGuild(_guildNum);

//                    if (Guild == null)
//                    {
//                        UploadBlockedStatus(_userToken);
//                        return;
//                    }

//                    await Guild.GetTextChannel(_channelNum)
//                        .SendMessageAsync(string.Format($"?c {pokemonName}"));
//                    await Task.Delay(2000);
//                }
//                catch (Exception errorSendmessage)
//                {
//                    string.Format(
//                        $"Erro ao tentar buscar Pokemon. {errorSendmessage.Message} {errorSendmessage.StackTrace}");
//                }

//            }
//            else
//            {
//                nLogger.Aviso("Aparentemente não estamos logados no servidor de coordenadas... CLIQUE NO BOTÃO DON'T PANIC 2 VEZES.");
//            }
//        }



//        #region Events

//        // Received Message Event Handler
//        private async Task DiscordMessageReceived(SocketMessage socketMessage)
//        {


//            //    nLogger.Sucesso(string.Format(
//            //        $"Name:{socketMessage.Author}\tChannel:{socketMessage.Channel}\tMessage:{socketMessage.Content}\n------------------------------------------------------------\n"));
//            //nLogger.Aviso($"{_client.ConnectionState} {_client.LoginState}");


//            if (socketMessage.Content.Contains(_client.CurrentUser.Id.ToString()))
//            {

//                if (socketMessage.Content.Contains("Sorry, no") ||
//                    socketMessage.Content.Contains("candies can be found"))
//                {
//                    nLogger.Aviso(
//                        "Infelizmente não encontramos nenhuma coordenada deste Pokemon no momento, tente mais tarde ou outro Pokemon.");
//                    PokemonList.Clear();
//                }
//                else
//                {
//                    var regexGetCoords = @"-?\d{1,2}.\d{6},-?\d{1,3}.\d{6}";
//                    var regexGetTime = @"\(.{1,5}\)";
//                    var regexPokemonName = @"<:(.*?):";
//                    var regexGetIV = @"(\d{2,3})IV";

//                    var split = socketMessage.Content.Split(new[] { "\n" }, StringSplitOptions.None);

//                    PokemonList.Clear();
//                    foreach (var t in split)
//                    {
//                        var getName = Regex.Match(t, regexPokemonName, RegexOptions.None);
//                        var getTime = Regex.Match(t, regexGetTime, RegexOptions.None);
//                        var getCoordinates = Regex.Match(t, regexGetCoords, RegexOptions.None);
//                        var getIV = Regex.Match(t, regexGetIV, RegexOptions.None);
//                        if (getCoordinates.Value != string.Empty)
//                            PokemonList.Add(getIV.Value == ""
//                                ? string.Format($"{getCoordinates},{getTime},?,")
//                                : string.Format($"{getCoordinates},{getTime},{getIV},"));
//                    }

//                    var pokemonfull = string.Empty;

//                    foreach (var line in PokemonList)
//                        pokemonfull += line;

//                    var Split = pokemonfull.Split(',');
//                    PokemonList.Clear();
//                    PokemonList = Split.ToList();
//                    PokemonList.RemoveAt(PokemonList.Count - 1);
//                }
//            }
//        }

//        // Disconect Event Handler Handler
//        private Task DiscordDisconected(Exception lostConnectionError)
//        {
//            nLogger.Erro("Perdemos a conexão com o servidor de coordenadas. Clique no botão don't Panic.");
//            return null;
//        }

//        #endregion


//    }
//}