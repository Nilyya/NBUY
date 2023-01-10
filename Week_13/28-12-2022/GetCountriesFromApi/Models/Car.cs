using System.Text.Json.Serialization;

namespace GetCountriesFromApi.Models
{
    public class Car
    {
        [JsonPropertyName("sings")]
        public string[] Sings { get; set; }
        [JsonPropertyName("side")]
        public string Side { get; set; }
    }
}