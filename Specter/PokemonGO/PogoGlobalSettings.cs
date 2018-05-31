using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Google;
using System.Threading.Tasks;
using PokemonGo.RocketAPI;
using PokemonGo.RocketAPI.LoginProviders;
using POGOProtos.Inventory.Item;

namespace Specter.PokemonGO
{
    public static class PogoGlobalSettings
    {

        //Pogo Client Session
        public static Client PogoClient { get; set; }
        public static string SpecterApiVersion => Constants.API_VERSION;
        public static string GameApiVersion => Client.GetMinimumRequiredVersionFromUrl().ToString();

        // Player Info

        public static string PlayerName => PogoClient.Player.PlayerData.Username;
        public static string PlayerTeam => PogoClient.Player.PlayerData.Team.ToString();
        public static double PlayerLatitude => PogoClient.CurrentLatitude;
        public static double PlayerLongitude => PogoClient.CurrentLongitude;



        // Player Statistics
        public static int PlayerTotalPokeballs => (PogoClient.Inventory.GetItemCount(ItemId.ItemPokeBall) +
                                                   PogoClient.Inventory.GetItemCount(ItemId.ItemUltraBall) +
                                                   PogoClient.Inventory.GetItemCount(ItemId.ItemGreatBall) +
                                                   PogoClient.Inventory.GetItemCount(ItemId.ItemMasterBall) +
                                                   PogoClient.Inventory.GetItemCount(ItemId.ItemPremierBall));

        public static int PlayerTotalPokemons => PogoClient.Inventory.GetPokemons().Count();

        public static int PlayerAvailableStorageItems => PogoClient.Player.PlayerData.MaxItemStorage -
                                                         PogoClient.Inventory.GetItemsCount();

        public static int PlayerAvailableStoragePokemons => PogoClient.Player.PlayerData.MaxPokemonStorage;

        public static int PlayerTotalRazzBerry => PogoClient.Inventory.GetItemCount(ItemId.ItemRazzBerry);

        public static int PlayerTotalGoldenBerry => PogoClient.Inventory.GetItemCount(ItemId
            .ItemGoldenRazzBerry);

        public static int PlayerTotalNanaBerry => PogoClient.Inventory.GetItemCount(ItemId.ItemNanabBerry);
        public static int PlayerTotalPinapBerry => PogoClient.Inventory.GetItemCount(ItemId.ItemPinapBerry);

        //Pogo client information

        public static string ApiVersion => PogoClient.CurrentApiEmulationVersion.ToString();
        public static string ApiMinimumVersion => PogoClient.MinimumClientVersion.ToString();


    }
}
