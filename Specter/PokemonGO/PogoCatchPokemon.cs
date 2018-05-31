using System;
using System.Linq;
using System.Threading.Tasks;
using NLog;
using Google;
using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using POGOProtos.Map.Pokemon;
using POGOProtos.Networking.Responses;
using Specter.Util;

namespace Specter.PokemonGO
{
    public class PogoCatchPokemon
    {
        private static Logger _sayLog;
        private static int _searchCount;
        private static int _catchTryCount;


        #region Last Pokemon Caught Data{
        public static string LastCatchName { get; set; }
        public static string LastCatchInfo { get; set; }
        public static DateTime LastCatchDate { get; set; }
        public static int LastCatchNumber { get; set; }
        public static string LastCatchLat { get; set; }
        public static string LastCatchLong { get; set; }
        #endregion

        public static async Task<bool> CatchPokemon(PokemonId pokemonId, double pokemonLat, double pokemonLong, ItemId pokebolaId, ItemId berryId)
        {
            _searchCount = 0;
            _catchTryCount = 0;
            PogoGlobalSettings.PogoClient.Player.SetCoordinates(pokemonLat, pokemonLong, 10);
            _sayLog = LogManager.GetLogger("CAPTURADOR:");


            var mapObjects = await SearchPokemon();
            if (mapObjects == null) return false;

            var pokemonsNearby = mapObjects.MapCells.SelectMany(q => q.NearbyPokemons).ToList();
            var pokemonsWild = mapObjects.MapCells.SelectMany(q => q.WildPokemons).ToList();
            

            _sayLog.Info(
                $"Encontramos [{pokemonsNearby.Count} Pokemons em sua região.] e [{pokemonsWild.Count} ao seu redor].");

            //Mostra lista de Pokémons aos redores.
            _sayLog.Fatal("Pokémons que podem ser capturados (Ao seu redor):");
            foreach (var pokemon in pokemonsWild)
                _sayLog.Fatal($"{pokemon.PokemonData.PokemonId}");


            foreach (var pokemon in pokemonsWild)
                if (pokemon.PokemonData.PokemonId == pokemonId)
                {
                    _sayLog.Info($"Nós encontramos o Pokémon {pokemon.PokemonData.PokemonId}!");

                    return await EncounterPokemon(pokemon,pokebolaId,berryId);
                }
            _sayLog.Error("Pokémon não foi encontrado. Tente outro.");
            return false;
        }

        private static async Task<GetMapObjectsResponse> SearchPokemon()
        {
            GetMapObjectsResponse mapObjects;

            while (true)
            {
                mapObjects = await PogoGlobalSettings.PogoClient.Map.GetMapObjects(true, false);

                // Check if we got any pokemon
                if (mapObjects.MapCells.SelectMany(q => q.CatchablePokemons).Count() +
                    mapObjects.MapCells.SelectMany(q => q.NearbyPokemons).Count() +
                    mapObjects.MapCells.SelectMany(q => q.WildPokemons).Count() == 0)
                {
                    await Task.Delay(3000);
                    if (_searchCount < 5)
                    {
                        _sayLog.Info($"Procurando pokémons aos redores.. [Tentativa: {_searchCount+1}/5]");
                        _searchCount++;
                        continue;
                    }
                }
                else
                {
                    return mapObjects;
                }

                break;
            }
            return mapObjects;
        }


        private static async Task<bool> EncounterPokemon(WildPokemon pokemon, ItemId pokebolaId, ItemId berryId)
        {
            var encounterResponse =
                await PogoGlobalSettings.PogoClient.Encounter.EncounterPokemon(pokemon.EncounterId,
                    pokemon.SpawnPointId);

            switch (encounterResponse.Status)
            {
                case EncounterResponse.Types.Status.EncounterAlreadyHappened:
                    _sayLog.Warn("Não conseguimos iniciar o processo de captura pois o mesmo já ocorreu.");
                    return false;
                case EncounterResponse.Types.Status.PokemonInventoryFull:
                    _sayLog.Warn("Não é possível capturar, pois sua mochila de Pokémon está cheia");
                    return false;
                case EncounterResponse.Types.Status.EncounterClosed:
                    _sayLog.Warn("Não é possível mais realizar o inicio de captura para este pokemon.");
                    return false;
                case EncounterResponse.Types.Status.EncounterNotFound:
                    _sayLog.Warn("Não encontramos o Pokémon para iniciar o processo de captura");
                    return false;
                case EncounterResponse.Types.Status.EncounterNotInRange:
                    _sayLog.Warn("Não foi possível iniciar o processo de captura pois o Pokémon está muito longe");
                    return false;
                case EncounterResponse.Types.Status.EncounterError:
                    _sayLog.Warn("Não foi possivel capturar o Pokémon, pois ocorreu um erro desconhecido.");
                    return false;
                case EncounterResponse.Types.Status.EncounterPokemonFled:
                    _sayLog.Fatal("O Pokémon fugiu e não foi possível iniciar o processo de captura");
                    return false;
                case EncounterResponse.Types.Status.EncounterSuccess:
                    _sayLog.Info("Batalha contra o Pokémon iniciada.");
                    //Inicia captura
                    return await CatchPokemon(encounterResponse.WildPokemon,pokebolaId, berryId);
            }
            return false;
        }

        private static async Task<bool> CatchPokemon(WildPokemon pokemon, ItemId pokebola, ItemId berry)
        {

            if (berry != ItemId.ItemUnknown)
            {
                
                if (berry == ItemId.ItemGoldenRazzBerry || berry == ItemId.ItemGoldenNanabBerry ||
                    berry == ItemId.ItemGoldenPinapBerry)
                {
                    var useItemResponse =
                        await PogoGlobalSettings.PogoClient.Inventory.UseRareCandy(SelectBerry(berry),
                            pokemon.PokemonData.PokemonId);


                    if (useItemResponse.Result == UseItemRareCandyResponse.Types.Result.Success)
                        _sayLog.Info($"{berry} Utilizada!");
                    else
                        _sayLog.Error($"Erro ao utilizar {berry}.");
                }
                else
                {
                    var useItemResponse = await PogoGlobalSettings.PogoClient.Encounter.UseCaptureItem(pokemon.EncounterId, SelectBerry(berry),
                        pokemon.SpawnPointId);

                    if (useItemResponse.Success)
                        _sayLog.Info($"{berry} Utilizada!");
                    else
                        _sayLog.Error($"Erro ao utilizar {berry}.");
                }

               

            }

            _sayLog.Info($"Arremesando ({pokebola}) no Pokemon {pokemon.PokemonData.PokemonId}");

            var catchPokemonResponse = await PogoGlobalSettings.PogoClient.Encounter.CatchPokemon(pokemon.EncounterId,
                pokemon.SpawnPointId,
                SelectPokeball(pokebola));

            switch (catchPokemonResponse.Status)
            {
                case CatchPokemonResponse.Types.CatchStatus.CatchError:
                    _sayLog.Warn("Ocorreu um erro desconhecido ao tentar capturar o Pokémon.");
                    await PokemonRaro.PokemonRaro.PokemonCaughtFail();
                    return false;

                case CatchPokemonResponse.Types.CatchStatus.CatchFlee:
                    _sayLog.Error($"{pokemon.PokemonData.PokemonId} Fugiu ):!\n" +
                                  $"CP: {pokemon.PokemonData.Cp}\n" +
                                  $"IV: {Iv(pokemon.PokemonData.IndividualAttack, pokemon.PokemonData.IndividualDefense, pokemon.PokemonData.IndividualStamina):0.##}\n" +
                                  $"Moves: ({pokemon.PokemonData.Move1},{pokemon.PokemonData.Move2})");
                    await PokemonRaro.PokemonRaro.PokemonCaughtFail();
                    return false;

                case CatchPokemonResponse.Types.CatchStatus.CatchSuccess:
                    LastCatchName = pokemon.PokemonData.PokemonId.ToString();
                    LastCatchInfo =
                        string.Format(
                            $"[CP:{pokemon.PokemonData.Cp}]-[IV:{Iv(pokemon.PokemonData.IndividualAttack, pokemon.PokemonData.IndividualDefense, pokemon.PokemonData.IndividualStamina):0.##}]");
                    LastCatchDate = DateTime.Now;
                    LastCatchNumber = (int)Enum.Parse(typeof(PokemonId), pokemon.PokemonData.PokemonId.ToString());
                    LastCatchLat = pokemon.Latitude.ToString();
                    LastCatchLong = pokemon.Longitude.ToString();

                    await PokemonRaro.PokemonRaro.SendPokemonLogToDatabase();
                    await PokemonRaro.PokemonRaro.PokemonCaughtSucess();
                    _sayLog.Debug($"{LastCatchName} foi capturado com sucesso!\n" +
                                  $"CP: {pokemon.PokemonData.Cp}\n" +
                                  $"IV: {Iv(pokemon.PokemonData.IndividualAttack,pokemon.PokemonData.IndividualDefense,pokemon.PokemonData.IndividualStamina):0.##}\n" +
                                  $"Moves: ({pokemon.PokemonData.Move1},{pokemon.PokemonData.Move2})");
                    

                    UserGlobalConfiguration.SaveSettingsFromUserWithTime();
                    return true;

                case CatchPokemonResponse.Types.CatchStatus.CatchEscape:
                    if (_catchTryCount > 5)
                    {
                        _sayLog.Info(
                            $"O total de tentativas se esgotou. Tente outro Pokémon. [Tentativas:{_catchTryCount+1}/5]");
                        return false;
                    }
                    else if (_catchTryCount < 5)
                    {
                        _sayLog.Info($"O Pokémon escapou, tentando capturar novamente. [Tentativas:{_catchTryCount+1}/5]");
                        await Task.Delay(1000);
                        _catchTryCount++;
                        await CatchPokemon(pokemon,pokebola,berry);
                    }
                    break;
                case CatchPokemonResponse.Types.CatchStatus.CatchMissed:
                    _sayLog.Info("Erramos a pokebola, tentando capturar novamente.");
                    await CatchPokemon(pokemon, pokebola, berry);
                    break;
            }

            return false;
        }

        private static ItemId SelectBerry(ItemId berry)
        {
            if(berry == ItemId.ItemUnknown)
                return ItemId.ItemUnknown;

            if (PogoGlobalSettings.PogoClient.Inventory.GetItemCount(berry) > 0)
                return berry;
            if (PogoGlobalSettings.PlayerTotalRazzBerry > 0)
                return ItemId.ItemRazzBerry;
            if (PogoGlobalSettings.PlayerTotalGoldenBerry > 0)
                return ItemId.ItemGoldenRazzBerry;
            if (PogoGlobalSettings.PlayerTotalPinapBerry > 0)
                return ItemId.ItemPinapBerry;
            if (PogoGlobalSettings.PlayerTotalNanaBerry > 0)
                return ItemId.ItemNanabBerry;
            return ItemId.ItemUnknown;
        }

        private static ItemId SelectPokeball(ItemId pokeball)
        {
            if (PogoGlobalSettings.PogoClient.Inventory.GetItemCount(pokeball) > 0)
                return pokeball;
            if(PogoGlobalSettings.PogoClient.Inventory.GetItemCount(ItemId.ItemPremierBall) > 0)
                return ItemId.ItemPremierBall;
            if(PogoGlobalSettings.PogoClient.Inventory.GetItemCount(ItemId.ItemMasterBall) > 0)
                return ItemId.ItemMasterBall;
            if(PogoGlobalSettings.PogoClient.Inventory.GetItemCount(ItemId.ItemUltraBall) > 0)
                return ItemId.ItemUltraBall;
            if (PogoGlobalSettings.PogoClient.Inventory.GetItemCount(ItemId.ItemGreatBall) > 0)
                return ItemId.ItemGreatBall;
            return ItemId.ItemPokeBall;
        }

        private static float Iv(int atk, int def, int sta)
        {
            return ((float)(atk + def + sta) / 45) * 100;
        }
    }
}
