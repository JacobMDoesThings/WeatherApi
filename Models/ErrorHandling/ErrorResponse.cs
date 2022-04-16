using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApi.Models
{
    public record ErrorResponse
    {
        [JsonPropertyName("status")]
        public string? Status { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("query")]
        public string? Query { get; set; }
        [JsonPropertyName("code")]
        public int? Code { get; set; }
        [JsonPropertyName("visit")]
        public string? Visit { get; set; }
        [JsonPropertyName("rejected")]
        public string? Rejected { get; set; }
    }
}

