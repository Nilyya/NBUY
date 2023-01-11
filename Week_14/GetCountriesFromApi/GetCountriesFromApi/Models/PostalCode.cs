﻿using System.Text.Json.Serialization;

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