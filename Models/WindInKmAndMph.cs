﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApi.Models
{
    public struct WindInKmAndMph
    {
        [JsonPropertyName("km")]
        public int KilometersPerHour { get; set; }
        [JsonPropertyName("mile")]
        public int MilesPerHour { get; set; }
    }
}
