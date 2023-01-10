using System.Text.Json.Serialization;
using System.Threading.Tasks.Dataflow;

namespace GetCountriesFromApi.Models
{
    public class PostalCode
    {
        [JsonPropertyName("format")]
        public string Format { get; set; }
        [JsonPropertyName("regex")]
        public string Regex { get; set; }
    }
}