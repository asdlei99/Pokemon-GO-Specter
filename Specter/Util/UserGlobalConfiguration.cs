using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PokemonGo.RocketAPI.Enums;
using Specter.PokemonGO;

namespace Specter.Util
{
    public class UserGlobalConfiguration
    {

        public static string PogoRaroKey = string.Empty;
        public static string Username = string.Empty;
        public static string Password = string.Empty;
        public static AuthType TypeAcc = AuthType.Ptc;
        public static double Latitude;
        public static double Longitude;
        public static DateTime LastCaptureTime;
        public static bool MessageWelcome = true;

        public static void LoadSettingsFromFile()
        {

            if (File.Exists(@"usersettings.json"))
            {
                using (StreamReader reader = new StreamReader(@"usersettings.json"))
                {
                    var userSetting = JObject.Parse(reader.ReadToEnd());
                    PogoRaroKey = userSetting.SelectToken(@"$.UserConfig.PokemonraroKey").ToString();
                    Username = userSetting.SelectToken(@"$.UserConfig.User").ToString();
                    Password = userSetting.SelectToken(@"$.UserConfig.Password").ToString();
                    TypeAcc =  (AuthType)Enum.Parse(typeof(AuthType), userSetting.SelectToken(@"$.UserConfig.AuthTypeAcc").ToString(),true);
                    Latitude = double.Parse(userSetting.SelectToken(@"$.UserConfig.Latitude").ToString());
                    Longitude = double.Parse(userSetting.SelectToken(@"$.UserConfig.Longitude").ToString());
                    LastCaptureTime = DateTime.Parse(userSetting.SelectToken(@"$.UserConfig.LastTimeCatch").ToString());
                    MessageWelcome = bool.Parse(userSetting.SelectToken(@"$.UserConfig.ShowWelcomeMessage").ToString());
                    reader.Close();
                }
            }

        }

        public static void SaveSettingsFromUserWithTime()
        {
            Latitude = PogoGlobalSettings.PlayerLatitude;
            Longitude = PogoGlobalSettings.PlayerLongitude;
            LastCaptureTime = DateTime.Now;

            var userSettingsToJsonFile = new UserSettingFile
            {
                UserConfig = new UserConfig
                {
                    User = Username,
                    Password = Password,
                    AuthTypeAcc = TypeAcc,
                    LastTimeCatch = LastCaptureTime,
                    Latitude = Latitude,
                    Longitude = Longitude,
                    PokemonraroKey = PokemonRaro.PokemonRaro.PokemonRaroKey,
                    ShowWelcomeMessage = MessageWelcome
                }
            };



            using (StreamWriter writer = new StreamWriter(@"usersettings.json"))
            {
                var encodeToJson = JsonConvert.SerializeObject(userSettingsToJsonFile);
                writer.Write(encodeToJson);
                writer.Close();
            }

        }

        public static void SaveSettingsFromUser()
        {
            Latitude = PogoGlobalSettings.PlayerLatitude;
            Longitude = PogoGlobalSettings.PlayerLongitude;
 
            var userSettingsToJsonFile = new UserSettingFile
            {
                UserConfig = new UserConfig
                {
                    User = Username,
                    Password = Password,
                    AuthTypeAcc = TypeAcc,
                    LastTimeCatch = LastCaptureTime,
                    Latitude = Latitude,
                    Longitude = Longitude,
                    PokemonraroKey = PokemonRaro.PokemonRaro.PokemonRaroKey,
                    ShowWelcomeMessage = MessageWelcome
                }
            };
                using (StreamWriter writer = new StreamWriter(@"usersettings.json"))
                {
                    var encodeToJson = JsonConvert.SerializeObject(userSettingsToJsonFile);
                    writer.Write(encodeToJson);
                    writer.Close();
                }
                
            
        }
    }
}