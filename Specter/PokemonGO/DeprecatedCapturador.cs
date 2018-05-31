//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;
//using GeoCoordinatePortable;
//using Google.Common.Geometry;
//using Google.Protobuf;
//using POGOProtos.Enums;
//using POGOProtos.Inventory.Item;
//using POGOProtos.Networking.Requests;
//using POGOProtos.Networking.Requests.Messages;
//using POGOProtos.Networking.Responses;

//namespace Specter.MODEL
//{
//    public class Capturador
//    {
//        //Global varables
//        public delegate void CapturaFinalizada(object source, EventArgs e);
//        public static event CapturaFinalizada CapturaConcludia;
        

//        public static async void IniciarCaptura(GeoCoordinate pokemonLocation, int pokebola)
//        {
//            Configuracoes.MySession.Player.SetCoordinates(pokemonLocation);

//            try
//            {

//                var celulasMapa = await GetMapObjects();

//                if (celulasMapa.MapCells == null)
//                {
//                    nLogger.Erro("GetMapObjects returned null!");
//                }
//                else
//                {
//                    if (Configuracoes.MySession.Map.Cells.Count > 0)
//                    {
//                        // TODO: Cleaner?
//                        var pokemonCatchable = celulasMapa.MapCells.SelectMany(c => c.CatchablePokemons).Count();
//                        var pokemonWild = celulasMapa.MapCells.SelectMany(c => c.WildPokemons).Count();
//                        var pokemonNearby = celulasMapa.MapCells.SelectMany(c => c.NearbyPokemons).Count();
//                        var pokemonCount = pokemonCatchable + pokemonWild + pokemonNearby;


//                        //nLogger.Info($"Recebido '{mapObjects.MapCells.Count}' celulas de mapa.");
//                        //nLogger.Info($"Encontrado '{pokemonCount}' pokemon. Catchable({pokemonCatchable}) Selvagem({pokemonWild}) aos redores({pokemonNearby})");

//                        if (pokemonWild > 0)
//                        {
//                            nLogger.Info("Pokémons diposniveis nesta regiao:"); // Pokémons diposniveis nesta regiao:
//                            var wildpokemons = celulasMapa.MapCells.SelectMany(c => c.WildPokemons).ToArray();
//                            var catchablepokemons = celulasMapa.MapCells.SelectMany(c => c.CatchablePokemons).ToArray();

//                            foreach (var wildpkmn in wildpokemons)
//                            {
//                                nLogger.Info($" - {wildpkmn.PokemonData.PokemonId}");
//                            }

//                            if (celulasMapa.MapCells.Count == 0)
//                            {
//                                nLogger.Info("Não encontramos nada, as coordenadas estão corretas?"); //Não encontramos nada, as coordenadas estão corretas?
//                            }

//                            List<PokemonId> PokemonNearby = new List<PokemonId>();

//                            foreach (var cell in celulasMapa.MapCells)
//                            {
//                                foreach (var wildpokemon in cell.WildPokemons)
//                                {
//                                    if (wildpokemon.PokemonData.PokemonId != Configuracoes.NomePokemon)
//                                    {
//                                        if(Configuracoes.TotalTentivasProcura >= pokemonCatchable)
//                                        {
//                                            await Task.Delay(2000);
//                                           Configuracoes.TotalTentivasProcura = 0;
//                                            QuandoConcluirCaptura();
//                                            nLogger.Aviso("Pokémon não foi encontrado aos redores, tente procurar outro Pokemon.\n"); // Pokémon não foi encontrado aos redores, tente procurar outro Pokemon.\n
//                                            return;
//                                        }

//                                        PokemonNearby.Add(wildpokemon.PokemonData.PokemonId);
//                                        Configuracoes.MySession.Player.SetCoordinates(wildpokemon.Latitude, wildpokemon.Longitude);
//                                        Configuracoes.TotalTentivasProcura++;
//                                        continue;
//                                    }


//                                    if (wildpokemon.PokemonData.PokemonId == Configuracoes.NomePokemon)
//                                    {
//                                        PokemonNearby.Add(wildpokemon.PokemonData.PokemonId);
//                                        nLogger.Info($"Encontramos o Pokémon {wildpokemon.PokemonData.PokemonId}!"); // Encontramos o Pokémon 

//                                        ByteString _encounter;
//                                        do
//                                        {
//                                            _encounter = await Configuracoes.MySession.RpcClient.SendRemoteProcedureCallAsync(new Request
//                                            {
//                                                RequestType = RequestType.Encounter,
//                                                RequestMessage = new EncounterMessage
//                                                {
//                                                    EncounterId = wildpokemon.EncounterId,
//                                                    PlayerLatitude = pokemonLocation.Latitude,
//                                                    PlayerLongitude = pokemonLocation.Longitude,
//                                                    SpawnPointId = wildpokemon.SpawnPointId
//                                                }.ToByteString()
//                                            });     

//                                        } while (_encounter == null);
                                        
//                                        var encounter = EncounterResponse.Parser.ParseFrom(_encounter);

//                                        if (encounter.Status == EncounterResponse.Types.Status.EncounterSuccess)
//                                        {
//                                            var pokemon = encounter.WildPokemon;
//                                            bool caught = false;
//                                            nLogger.Sucesso($"iniciando processo de captura do: {pokemon.PokemonData.PokemonId}. CP: {pokemon.PokemonData.Cp}"); //iniciando processo de captura do:

//                                            do
//                                            {
//                                                if (Configuracoes.CapturarComBerry == 1 ||
//                                                    Configuracoes.CapturarComBerry == 2 ||
//                                                    Configuracoes.CapturarComBerry == 3)
//                                                {
//                                                    var berrySelecionada = Configuracoes.CapturarComBerry == 1 ? ItemId.ItemRazzBerry : ItemId.ItemPinapBerry;

                                                    
//                                                var _usarItem = await Configuracoes.MySession.RpcClient
//                                                    .SendRemoteProcedureCallAsync(new Request
//                                                    {
//                                                        RequestType = RequestType.UseItemEncounter,
//                                                        RequestMessage = new UseItemEncounterMessage
//                                                        {
//                                                            EncounterId = wildpokemon.EncounterId,
//                                                            Item = berrySelecionada,
//                                                            SpawnPointGuid = wildpokemon.SpawnPointId
//                                                        }.ToByteString()
//                                                    });

//                                                var usarItem = UseItemEncounterResponse.Parser.ParseFrom(_usarItem);

//                                                    switch (usarItem.Status)
//                                                {
//                                                    case UseItemEncounterResponse.Types.Status.Success:
//                                                        nLogger.Info(string.Format($"{berrySelecionada} utilizada com sucesso!"));
//                                                        break;
//                                                    case UseItemEncounterResponse.Types.Status.NoItemInInventory:
//                                                        nLogger.Erro(string.Format($"Você não possui {berrySelecionada} em seu inventário!"));
//                                                        break;
//                                                        case UseItemEncounterResponse.Types.Status.ActiveItemExists:
//                                                            nLogger.Erro(string.Format($"A berry {berrySelecionada} já foi ativada!"));
//                                                            break;
//                                                }
//                                                }

//                                                var _mon = await Configuracoes.MySession.RpcClient.SendRemoteProcedureCallAsync(new Request
//                                                {
//                                                    RequestType = RequestType.CatchPokemon,
//                                                    RequestMessage = new CatchPokemonMessage
//                                                    {
//                                                        EncounterId = wildpokemon.EncounterId,
//                                                        HitPokemon = true,
//                                                        NormalizedReticleSize = 1.95, //excellent throw
//                                                        Pokeball = GetBall(encounter),
//                                                        SpawnPointId = wildpokemon.SpawnPointId,
//                                                        SpinModifier = 1 //taken from NecroBot. Idk what this means TBH
//                                                    }.ToByteString()
//                                                });
//                                                nLogger.Info($"Jogando {GetBall(encounter).ToString().Replace("Item", string.Empty)}. Tentativa ({Configuracoes.TotalTentivasCaptura + 1})"); // Jogando , Tentativa
//                                                Configuracoes.TotalTentivasCaptura++;
//                                                var mon = CatchPokemonResponse.Parser.ParseFrom(_mon);
//                                                if (mon.Status == CatchPokemonResponse.Types.CatchStatus.CatchSuccess)
//                                                {
//                                                    TempoRestanteCaptura();
//                                                    double teste = ((Convert.ToDouble(pokemon.PokemonData.IndividualAttack) + Convert.ToDouble(pokemon.PokemonData.IndividualDefense) + Convert.ToDouble(pokemon.PokemonData.IndividualStamina)) / 45) * 100;
//                                                    nLogger.Sucesso($"{pokemon.PokemonData.PokemonId} foi capturado com sucesso!\nCP:{pokemon.PokemonData.Cp}\nIV(Genética): {teste:0.##} \n{pokemon.PokemonData.IndividualAttack} ATK, {pokemon.PokemonData.IndividualDefense} DEF, {pokemon.PokemonData.IndividualStamina} STA)\nHabilidades: {pokemon.PokemonData.Move1.ToString().Replace("Fast", string.Empty)}, {pokemon.PokemonData.Move2}\n"); // foi capturado com sucesso!\nCP:, \nIV(Genética):, \nHabilidades:, Erro: Erro desconhecido ao tentar capturar o Pokémon.

//                                                    await PokemonRaro.PokemonCaughtSucess();
//                                                    caught = true;
//                                                    Configuracoes.TotalTentivasProcura = 0;
//                                                    Configuracoes.TotalTentivasCaptura = 0;
//                                                    await Task.Delay(3000);
//                                                    QuandoConcluirCaptura();
//                                                    return;
//                                                }
//                                                if (mon.Status == CatchPokemonResponse.Types.CatchStatus.CatchError)
//                                                {
//                                                    TempoRestanteCaptura();
//                                                    nLogger.Aviso("Erro: Erro desconhecido ao tentar capturar o Pokémon."); // Erro: Erro desconhecido ao tentar capturar o Pokémon.
//                                                }
//                                                if (mon.Status == CatchPokemonResponse.Types.CatchStatus.CatchEscape)
//                                                {
//                                                    nLogger.Aviso($"{wildpokemon.PokemonData.PokemonId} escapou de nossa {GetBall(encounter).ToString().Replace("Item", string.Empty)}!");
//                                                    await Task.Delay(4000);
//                                                }
//                                                if (mon.Status == CatchPokemonResponse.Types.CatchStatus.CatchFlee)
//                                                {
//                                                    TempoRestanteCaptura();
//                                                    double teste = ((Convert.ToDouble(pokemon.PokemonData.IndividualAttack) + Convert.ToDouble(pokemon.PokemonData.IndividualDefense) + Convert.ToDouble(pokemon.PokemonData.IndividualStamina)) / 45) * 100;
//                                                    nLogger.Erro($"Ohhh não! O Pokémon {wildpokemon.PokemonData.PokemonId} fugiu! ): \nCP: {pokemon.PokemonData.Cp}IV(Genética): {teste:0.##}\n({pokemon.PokemonData.IndividualAttack} ATK, {pokemon.PokemonData.IndividualDefense} DEF, {pokemon.PokemonData.IndividualStamina} STA)\nHabilidades: {pokemon.PokemonData.Move1.ToString().Replace("Fast", string.Empty)}, {pokemon.PokemonData.Move2}\n"); //Ohhh não! O Pokémon,  fugiu! ): \nCP: 

//                                                    Configuracoes.TotalPokemonEscapado += 1;
//                                                    Configuracoes.TotalTentivasProcura = 0;
//                                                    Configuracoes.TotalTentivasCaptura = 0;


//                                                    await Task.Delay(3000);
//                                                    QuandoConcluirCaptura();
//                                                    return;
//                                                }
//                                                if (mon.Status == CatchPokemonResponse.Types.CatchStatus.CatchMissed)
//                                                {
//                                                    TempoRestanteCaptura();
//                                                    nLogger.Aviso("Perdemos o Pokémon!):"); // Perdemos o Pokémon!):
//                                                }
//                                                Thread.Sleep(500);
//                                            } while (!caught);
//                                        }
//                                        else
//                                        {
//                                            nLogger.Erro($"Não conseguimos iniciar o processo de captura {wildpokemon.PokemonData.PokemonId}: {encounter.Status}.\n"); // Não conseguimos iniciar o processo de captura 
//                                            QuandoConcluirCaptura();
//                                        }
                                        
//                                    }
//                                    if (!PokemonNearby.Contains(Configuracoes.NomePokemon) || PokemonNearby.Count == 0)
//                                    {
//                                        nLogger.Aviso($"Não encontramos o Pokémon {Configuracoes.NomePokemon}  aqui. Talvez ele já tenha sido capturado, ou ele sumiu."); //Não encontramos o Pokémon , aqui. Talvez ele já tenha sido capturado, ou ele sumiu.
//                                        await Task.Delay(2000);
//                                        QuandoConcluirCaptura();
//                                    }
//                                }
//                            }
//                        }
//                        else
//                        {
//                            nLogger.Aviso(string.Format($"Procurando Pokémon... tentativa ({Configuracoes.TotalTentivasProcura + 1}).")); // Procurando Pokémon... tentativa
//                            TotalTentivasProcuraPoke(4);

//                            if (Configuracoes.TotalTentivasProcura == 4)
//                            {
//                                nLogger.Aviso("Não encontramos nada, desculpe. Tente outro Pokémon!\n"); // Não encontramos nada, desculpe. Tente outro Pokémon!\n
//                                Configuracoes.TotalTentivasProcura = 0;
//                                Configuracoes.TotalTentivasCaptura = 0;
//                                QuandoConcluirCaptura();
//                            }
//                        }
//                    }
//                    else
//                    {
//                        nLogger.Aviso($"Objetos do mapa:  {Configuracoes.MySession.Map.Cells.Count}"); // Objetos do mapa: 
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                TempoRestanteCaptura();
//                QuandoConcluirCaptura();
//                nLogger.Erro(e.Message);
//                nLogger.Erro(e.StackTrace);
//                nLogger.Erro(e.Source);
//                Configuracoes.TotalTentivasCaptura = 0;
//                Configuracoes.TotalTentivasProcura = 0;
//            }
//        }


//        //Chama evento após concluír a compra.
//        private static void QuandoConcluirCaptura()
//        {
//            if (CapturaConcludia != null)
//            {
//                CapturaConcludia(null, EventArgs.Empty);
//            }
//        }

//        private static void TempoRestanteCaptura()
//        {
//            if(Configuracoes.TempoRestanteSnipe.Ticks > 0)
//            {
//                Configuracoes.TempoRestanteSnipe = Configuracoes.TempoRestanteSnipe.Subtract(TimeSpan.FromTicks(Configuracoes.TempoRestanteSnipe.Ticks));
//                Configuracoes.TempoRestanteSnipe = Configuracoes.TempoRestanteSnipe.Add(TimeSpan.FromMinutes(120));
//            }
//            else
//                Configuracoes.TempoRestanteSnipe = Configuracoes.TempoRestanteSnipe.Add(TimeSpan.FromMinutes(120));
//        }

//        //NUMERO DE TENTATIVAS NO MÁXIMO DE ENCONTRAR O POKÉMON.
//        private static async void TotalTentivasProcuraPoke(int totalTentativas)
//        {
//            if (Configuracoes.TotalTentivasProcura >= totalTentativas) return;
//            await Task.Delay(3000);
//            GeoCoordinate coordenadasPokemon = new GeoCoordinate(Configuracoes.Pokemonlatitude, Configuracoes.LastCatchLong);
//            IniciarCaptura(coordenadasPokemon, Configuracoes.PokebolaSeleciona);
//            Configuracoes.TotalTentivasProcura++;
//        }

//        public static ulong[] GetCellIdsForLatLong(double latitude, double longitude)
//        {
//            var latLong = S2LatLng.FromDegrees(latitude, longitude);
//            var cell = S2CellId.FromLatLng(latLong);
//            var cellId = cell.ParentForLevel(15);
//            var cells = cellId.GetEdgeNeighbors();
//            var cellIds = new List<ulong>
//            {
//                cellId.Id
//            };

//            foreach (var cellEdge1 in cells)
//            {
//                if (!cellIds.Contains(cellEdge1.Id)) cellIds.Add(cellEdge1.Id);

//                foreach (var cellEdge2 in cellEdge1.GetEdgeNeighbors())
//                {
//                    if (!cellIds.Contains(cellEdge2.Id)) cellIds.Add(cellEdge2.Id);
//                }
//            }

//            return cellIds.ToArray();
//        }

//        private static async Task<GetMapObjectsResponse> GetMapObjects()
//        {

//            var cellIds = GetCellIdsForLatLong(Configuracoes.MySession.Player.Latitude, Configuracoes.MySession.Player.Longitude);
//            var sinceTimeMs = new List<long>(cellIds.Length);

//            for (var i = 0; i < cellIds.Length; i++)
//            {
//                sinceTimeMs.Add(0);
//            }
//            ByteString response;
//            do
//            {
//                response = await Configuracoes.MySession.RpcClient.SendRemoteProcedureCallAsync(new Request
//                {
//                    RequestType = RequestType.GetMapObjects,
//                    RequestMessage = new GetMapObjectsMessage
//                    {
//                        CellId = { cellIds },
//                        SinceTimestampMs = { sinceTimeMs.ToArray() },
//                        Latitude = Configuracoes.MySession.Player.Latitude,
//                        Longitude = Configuracoes.MySession.Player.Longitude
//                    }.ToByteString()
//                });
//            } while (response == null);

//            return GetMapObjectsResponse.Parser.ParseFrom(response);
//        }

//        public static async void HumanLikeWalking(GeoCoordinate targetLocation, double walkingSpeedInKilometersPerHour)
//        {
//            double speedInMetersPerSecond = walkingSpeedInKilometersPerHour / 3.6; // Velocidade
//            GeoCoordinate sourceLocation = new GeoCoordinate(Configuracoes.MySession.Player.Latitude, Configuracoes.MySession.Player.Longitude); // Localização personagem servidor atual
//            double distanceToTarget = CoordinatesHelper.CalculaDistanciaEmMetros(sourceLocation, targetLocation); //Distancia entre inicial > Final
//            double bearingDegrees = CoordinatesHelper.DegreeBearing(sourceLocation, targetLocation);
//            double distanceInMeters = speedInMetersPerSecond;
//            GeoCoordinate geoCoordinate = CoordinatesHelper.CreateWaypoint(sourceLocation, distanceInMeters, bearingDegrees);
//            DateTime requestSendDateTime = DateTime.Now;
//            Configuracoes.MySession.Player.SetCoordinates(geoCoordinate.Latitude, geoCoordinate.Longitude, 100); 
//            //nLogger.Info(string.Format($"Distancia ate o alvo: {distanceToTarget} \t Distancia em Metros: {distanceInMeters}"));
//            nLogger.Info(distanceToTarget.ToString("0.##")); 

//            do
//            {
//                double totalMilliseconds = (DateTime.Now - requestSendDateTime).TotalMilliseconds;
//                sourceLocation = new GeoCoordinate(Configuracoes.MySession.Player.Latitude, Configuracoes.MySession.Player.Longitude); // tem que ser assim.
//                double num = CoordinatesHelper.CalculaDistanciaEmMetros(sourceLocation, targetLocation);
//                nLogger.Info("Restante: "+num.ToString("0.##"));
//                if (num < 40.0 && speedInMetersPerSecond > 2.7777777777777777)
//                {
//                    speedInMetersPerSecond = 2.7777777777777777;
//                }
//                distanceInMeters = Math.Min(num, totalMilliseconds / 1000.0 * speedInMetersPerSecond);
//                bearingDegrees = CoordinatesHelper.DegreeBearing(sourceLocation, targetLocation);
//                geoCoordinate = CoordinatesHelper.CreateWaypoint(sourceLocation, distanceInMeters, bearingDegrees);
//                requestSendDateTime = DateTime.Now;
//                Configuracoes.MySession.Player.SetCoordinates(geoCoordinate.Latitude, geoCoordinate.Longitude);
//                nLogger.Sucesso($"Se movendo para: {Configuracoes.MySession.Player.Latitude},{Configuracoes.MySession.Player.Longitude}");
//                await Task.Delay(Math.Min((int)(distanceToTarget / speedInMetersPerSecond * 100.0), 3000));
//            }
//            while (CoordinatesHelper.CalculaDistanciaEmMetros(sourceLocation, targetLocation) >= 30.0);

//        }

//        public static ItemId GetBall(EncounterResponse resp)
//        {
//            if (Configuracoes.PokebolaSeleciona == 0 && Configuracoes.TotalPokeBall > 0)
//            {
//                return ItemId.ItemPokeBall;
//            }
//            if (Configuracoes.PokebolaSeleciona == 1 && Configuracoes.TotalGreatBall > 0)
//            {
//                return ItemId.ItemGreatBall;
//            }
//            if (Configuracoes.PokebolaSeleciona == 2 && Configuracoes.TotalUltraBall > 0)
//            {
//                return ItemId.ItemUltraBall;
//            }

//            if (Configuracoes.TotalPokeBall > Configuracoes.TotalGreatBall &&
//                Configuracoes.TotalPokeBall > Configuracoes.TotalUltraBall)
//                return ItemId.ItemPokeBall;
//            if (Configuracoes.TotalGreatBall > Configuracoes.TotalPokeBall &&
//                Configuracoes.TotalGreatBall > Configuracoes.TotalUltraBall)
//                return ItemId.ItemGreatBall;
//            if (Configuracoes.TotalUltraBall > Configuracoes.TotalPokeBall &&
//                Configuracoes.TotalUltraBall > Configuracoes.TotalGreatBall)
//                return ItemId.ItemUltraBall;

//            return ItemId.ItemPokeBall;
//        }
//    }
//}