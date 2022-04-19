using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApi.Models
{
    public record Forecast
    {
        [JsonPropertyName("region")]
        public string Region { get; set; } = string.Empty;
        [JsonPropertyName("data_source")]
        public string DataSource { get; set; } = string.Empty;
        [JsonPropertyName("currentConditions")]
        public CurrentWeather CurrentConditions { get; set; } = new CurrentWeather();
        [JsonPropertyName("next_days")]
        public List<Day> NextDays { get; set; } = new List<Day>();
        [JsonPropertyName("contact_author")]
        public AuthorDetails ContactAuthor { get; set; }
       
    }
}
