using System;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using NLog;
using POGOProtos.Enums;
using Specter.Util;
using Wibci.CountryReverseGeocode;
using Wibci.CountryReverseGeocode.Models;

namespace Specter.ApiPokedex
{
    public class PesquisaPokemon
    {
        public static string IdPokedex100;
        private static Logger _sayLog;
        private static string _freeUserKey;


        public static string ApiPremium =>
            "http://api.pokedex100.com/feedlink/&fe2x8RxP44pqPiTOqCP9vW/r6I21RyvzvZMSEZVEBoY0ArHoGu97fAEyrpdHv6vhAITH/TnVAn9RDFWM3nzlFA==,feature,iv";

        public static async Task<PokemonAttributes> SearchPokemon(bool isPremium, int numberPokemon)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            _sayLog = LogManager.GetLogger("SERVIDOR COORDENADAS:");
            using (var downloadData = new WebClient())
            {
                var allPokemon = string.Empty;


                if (isPremium)
                {
                    allPokemon = await downloadData.DownloadStringTaskAsync(ApiPremium);
                    _sayLog.Info("Estamos carregando a lista. Aguarde...");
                }
                else
                {
                    _freeUserKey = await PokemonRaro.PokemonRaro.PokedexApiFree();
                    allPokemon =
                        await downloadData.DownloadStringTaskAsync(string.Format(
                            $"http://api.pokedex100.com/feedlink/{_freeUserKey},candies,{numberPokemon}"));
                }


                if (!CheckReceivedData(allPokemon).Result)
                    return null;


                var splitPokemonByLine = allPokemon.Split(new[] {"\n"}, StringSplitOptions.None).ToList();
                splitPokemonByLine.RemoveAt(0);

                var pokemonList = new PokemonAttributes
                {
                    PokemonAtribbutes = new PokemonAtribbute[splitPokemonByLine.Count]
                };

                //Regex search settings
                const string regexCoordinates = @"-?\d{1,2}.\d{6},-?\d{1,3}.\d{6}";
                const string regexIv = @"iv((\d{1,3})|\?)";
                const string regexCP = @"cp((\d{1,4})|\?)";
                const string regexTimeLeft = @"\(\d{1,2}:\d{1,2}\)";
                const string regexGetNumber = @",\d{1,3},";


                for (var i = 0; i < splitPokemonByLine.Count; i++)
                {
                    var numPokemon = Regex.Match(splitPokemonByLine[i], regexGetNumber).Value;
                    numPokemon = numPokemon.Remove(0, 1);
                    numPokemon = numPokemon.Remove(numPokemon.Length - 1, 1);
                    var nomePokemon = Enum.GetName(typeof(PokemonId), int.Parse(numPokemon));

                    var coordinates = Regex.Match(splitPokemonByLine[i], regexCoordinates).Value;
                    var getLatLong = coordinates.Split(',');
                    if(!getLatLong[0].Contains('.'))
                        continue;
                    else if(!getLatLong[1].Contains('.'))
                        continue;

                    var getIv =  Regex.Match(splitPokemonByLine[i], regexIv).Value;
                    if (string.IsNullOrEmpty(getIv))
                        getIv = "?";
                    else
                        getIv = getIv.Remove(0, 2);


                    var getCp = Regex.Match(splitPokemonByLine[i], regexCP).Value;
                    if (string.IsNullOrEmpty(getCp))
                        getCp = "?";
                    else
                        getCp = getCp.Remove(0, 2);


                    var getTimeLeft = Regex.Match(splitPokemonByLine[i], regexTimeLeft).Value;
                    var country = string.Empty;

                    GeoLocation geoLoc = new GeoLocation();
                    geoLoc.Latitude = 0;
                    geoLoc.Longitude = 0;
                    
                    try
                    {
                        geoLoc.Latitude = double.Parse(getLatLong[0]);
                        geoLoc.Longitude = double.Parse(getLatLong[1]);
                        _sayLog.Fatal($"lat: {geoLoc.Latitude} long: {geoLoc.Longitude}");
                        var teste = new CountryReverseGeocodeService();

                        country = teste.FindCountry(geoLoc).Id;
                        country = country.ToLower();
                    }
                    catch (Exception e)
                    {
                        _sayLog.Error(e.Message + " " + e.StackTrace);
                    }

                    pokemonList.PokemonAtribbutes[i] = new PokemonAtribbute();
                    pokemonList.PokemonAtribbutes[i].Name = nomePokemon;
                    pokemonList.PokemonAtribbutes[i].Number = numPokemon;
                    pokemonList.PokemonAtribbutes[i].Country = country ?? "bra";
                    pokemonList.PokemonAtribbutes[i].Iv = getIv;
                    pokemonList.PokemonAtribbutes[i].Cp = getCp;
                    pokemonList.PokemonAtribbutes[i].TimeLeft = getTimeLeft;
                    pokemonList.PokemonAtribbutes[i].Latitude = geoLoc.Latitude;
                    pokemonList.PokemonAtribbutes[i].Longitude = geoLoc.Longitude;
                }

                return pokemonList;
            }
        }


        private static async Task<bool> CheckReceivedData(string stringData)
        {
            if (stringData == "FailGet" || stringData == string.Empty)
            {
                _sayLog.Fatal("Ocorreo um erro ao buscar o Pokémon");
                return false;
            }

            if (stringData.Contains("Invalid feedlink") || stringData.Contains("exceed limit for free user"))
            {
                if (await PokemonRaro.PokemonRaro.SendFailGetApiPodex(_freeUserKey))
                    _sayLog.Debug("Chave atualizada com sucesso.");
                return false;
            }
            if (stringData.Contains("Found 0"))
            {
                _sayLog.Warn("Infelizmente no momento não existe nenhum dado deste Pokémon em nosso banco de dados.");
                return false;
            }
            return true;
        }

        private static double CalculateOtherShit(double pokemonNeederTime)
        {
            var passedTimed = DateTime.Now.Subtract(UserGlobalConfiguration.LastCaptureTime).TotalSeconds;
            if (pokemonNeederTime - passedTimed <= 0)
                return 0;
            return pokemonNeederTime - passedTimed;
        }

        public static TimeSpan CalculateTimeLeft(double initLat, double initLong, double destLat, double destLong)
        {
            var distance = CoordinatesHelper.CalculaDistanciaEmMetros(initLat, initLong, destLat, destLong) / 1000;

            if (distance <= 2)
                return TimeSpan.FromSeconds(CalculateOtherShit(60));
            if (distance > 2 && distance <= 5)
                return TimeSpan.FromSeconds(CalculateOtherShit(120));
            if (distance > 5 && distance <= 7)
                return TimeSpan.FromSeconds(CalculateOtherShit(300));

            if (distance > 7 && distance <= 10)
                return TimeSpan.FromSeconds(CalculateOtherShit(420));

            if (distance > 10 && distance <= 12)
                return TimeSpan.FromSeconds(CalculateOtherShit(480));
            if (distance > 12 && distance <= 18)
                return TimeSpan.FromSeconds(CalculateOtherShit(600));

            if (distance > 18 && distance <= 26)
                return TimeSpan.FromSeconds(CalculateOtherShit(900));

            if (distance > 26 && distance <= 42)
                return TimeSpan.FromSeconds(CalculateOtherShit(1140));

            if (distance > 42 && distance <= 65)
                return TimeSpan.FromSeconds(CalculateOtherShit(1320));

            if (distance > 65 && distance <= 81)
                return TimeSpan.FromSeconds(CalculateOtherShit(1500));

            if (distance > 81 && distance <= 100)
                return TimeSpan.FromSeconds(CalculateOtherShit(2100));

            if (distance > 100 && distance <= 200)
                return TimeSpan.FromSeconds(CalculateOtherShit(2400));

            if (distance > 200 && distance <= 250)
                return TimeSpan.FromSeconds(CalculateOtherShit(2700));

            if (distance > 250 && distance <= 350)
                return TimeSpan.FromSeconds(CalculateOtherShit(3060));

            if (distance > 350 && distance <= 460)
                return TimeSpan.FromSeconds(CalculateOtherShit(3480));

            if (distance > 460 && distance <= 500)
                return TimeSpan.FromSeconds(CalculateOtherShit(3600));

            if (distance > 500 && distance <= 565)
                return TimeSpan.FromSeconds(CalculateOtherShit(4020));

            if (distance > 565 && distance <= 700)
                return TimeSpan.FromSeconds(CalculateOtherShit(4500));

            if (distance > 700 && distance <= 716)
                return TimeSpan.FromSeconds(CalculateOtherShit(4860));

            if (distance > 716 && distance <= 830)
                return TimeSpan.FromSeconds(CalculateOtherShit(5160));

            if (distance > 830 && distance <= 1000)
                return TimeSpan.FromSeconds(CalculateOtherShit(5400));

            if (distance > 1000 && distance <= 1499)
                return TimeSpan.FromSeconds(CalculateOtherShit(6500));
            if(distance > 1500)
                return TimeSpan.FromSeconds(CalculateOtherShit(7200));


            return TimeSpan.FromSeconds(CalculateOtherShit(10000));
        }
    }
}