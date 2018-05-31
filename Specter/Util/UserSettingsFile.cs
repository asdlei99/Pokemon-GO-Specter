using System;
using PokemonGo.RocketAPI.Enums;

namespace Specter.Util
{
    public class UserSettingFile
    {
        public UserConfig UserConfig { get; set; }
    }

    public class UserConfig
    {

        public string PokemonraroKey { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public AuthType AuthTypeAcc { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime LastTimeCatch { get; set; }
        public bool ShowWelcomeMessage { get; set; }
    }
}
