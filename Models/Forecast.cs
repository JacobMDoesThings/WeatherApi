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
        public string? Region { get; set; }
        [JsonPropertyName("data_source")]
        public string? DataSource { get; set; }
        [JsonPropertyName("currentConditions")]
        public CurrentWeather? CurrentConditions { get; set; }
        [JsonPropertyName("next_days")]
        public Day[] NextDays {get;set;} = new Day[7];
        [JsonPropertyName("contact_author")]
        public AuthorDetails ContactAuthor { get; set; }
       
    }
}
