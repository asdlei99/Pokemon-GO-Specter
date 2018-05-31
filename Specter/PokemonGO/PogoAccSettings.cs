using PokemonGo.RocketAPI;
using PokemonGo.RocketAPI.Enums;
using Specter.Util;

namespace Specter.PokemonGO
{
    public class PogoAccSettings : ISettings
    {
        public AuthType AuthType { get; set; }
        public double DefaultLatitude {
            get => UserGlobalConfiguration.Latitude;
            set => DefaultLatitude = value;
        }
        public double DefaultLongitude
        {
            get => UserGlobalConfiguration.Longitude;
            set => DefaultLongitude = value;
        }
        public double DefaultAltitude { get; set; }
        public string GoogleRefreshToken { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public string DevicePlatform { get => "ios"; set => DevicePlatform = value; }
        public string DeviceId { get; set; }
        public string AndroidBoardName { get; set; }
        public string AndroidBootloader { get; set; }
        public string DeviceBrand { get; set; }
        public string DeviceModel { get; set; }
        public string DeviceModelIdentifier { get; set; }
        public string DeviceModelBoot { get; set; }
        public string HardwareManufacturer { get; set; }
        public string HardwareModel { get; set; }
        public string FirmwareBrand { get; set; }
        public string FirmwareTags { get; set; }
        public string FirmwareType { get; set; }
        public string FirmwareFingerprint { get; set; }
        public bool UseProxy { get; set; }
        public bool UseProxyAuthentication { get; set; }
        public string UseProxyHost { get; set; }
        public string UseProxyPort { get; set; }
        public string UseProxyUsername { get; set; }
        public string UseProxyPassword { get; set; }
        public bool UsePogoDevHashServer { get => true; set => UsePogoDevHashServer = value; }
        public string UrlHashServices { get; set; }
        public string EndPoint { get; set; }
        public bool UseCustomAPI { get; set; }
        public string AuthAPIKey
        {
            get => PokemonRaro.PokemonRaro.BosslandHashKey; set => AuthAPIKey = value; }
        public bool DisplayVerboseLog
        {
            get => false;
            set => DisplayVerboseLog = value;
        }

        public bool AutoExitBotIfAccountFlagged { get; set; }
        public double AccountLatitude { get; set; }
        public double AccountLongitude { get; set; }
        public bool AccountActive { get; set; }
        public string Country { get => "BR";
            set
            {
                
            }
        }

        public string Language
        {
            get => "pt-br";
            set
            {
                
            }
        }

        public string TimeZone
        {
            get => "America/Bahia";
            set
            {
                
            } }

        public string POSIX
        {
            get => "br";
            set
            {
                
            }
        }
    }
}
