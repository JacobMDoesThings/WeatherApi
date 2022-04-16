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
        public string Status { get; set; } = string.Empty;
        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;
        [JsonPropertyName("query")]
        public string Query { get; set; } = string.Empty;
        [JsonPropertyName("code")]
        public int Code { get; set; }
        [JsonPropertyName("visit")]
        public string Visit { get; set; }=string.Empty;
        [JsonPropertyName("rejected")]
        public string Rejected { get; set; }=string.Empty;
    }
}

