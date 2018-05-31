using Newtonsoft.Json;

namespace Specter.ApiPokedex
{
    public partial class PokemonAttributes
    {
        [JsonProperty("PokemonAtribbutes")]
        public PokemonAtribbute[] PokemonAtribbutes { get; set; }
    }

    public class PokemonAtribbute
    {

        [JsonProperty("Number")]
        public string Number { get; set; }


        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Iv")]
        public string Iv { get; set; }

        [JsonProperty("Cp")]
        public string Cp { get; set; }

        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("TimeLeft")]
        public string TimeLeft { get; set; }
    }


    public partial class PokemonAttributes
    {
        public static PokemonAttributes FromJson(string json)
        {
            return JsonConvert.DeserializeObject<PokemonAttributes>(json, Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this PokemonAttributes self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None
        };
    }
}
