using System.Text.Json.Serialization;

namespace GetCountriesFromApi.Models
{
    public class Maps
    {
        [JsonPropertyName("googleMaps")]
        public string GoogleMaps { get; set; }
        [JsonPropertyName("openstreetmaps")]
        public string OpenStreetMaps { get; set; }
    }
}