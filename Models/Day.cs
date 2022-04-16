using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WeatherApi.Models
{
    
    public record Day
    {
        [JsonPropertyName("day")]
        public string DayOfWeek { get; set; } = string.Empty;
        [JsonPropertyName("comment")]
        public string Comment { get; set; } = string.Empty;
        [JsonPropertyName("min_temp")]

        public TemperatureInCandF MinTemp { get; set; }
        [JsonPropertyName("max_temp")]
        public TemperatureInCandF MaxTemp { get; set; }
        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; } = string.Empty;

    }
}

//region "London, UK"
//currentConditions
//dayhour	"Saturday 5:00 AM"
//temp	
//c	9
//f	49
//precip	"3%"
//humidity	"90%"
//wind	
//km	3
//mile	2
//iconURL	"https://ssl.gstatic.com/onebox/weather/64/fog.png"
//comment	"Haze"
//next_days	
//0	
//day	"Saturday"
//comment	"Sunny"
//max_temp	
//c	20
//f	68
//min_temp	
//c	7
//f	45
//iconURL	"https://ssl.gstatic.com/onebox/weather/48/sunny.png"
//1	
//day	"Sunday"
//comment	"Mostly cloudy"
//max_temp	
//c	19
//f	66
//min_temp	
//c	9
//f	48
//iconURL	"https://ssl.gstatic.com/onebox/weather/48/partly_cloudy.png"
//2	
//day	"Monday"
//comment	"Cloudy"
//max_temp	
//c	16
//f	60
//min_temp	
//c	7
//f	45
//iconURL	"https://ssl.gstatic.com/onebox/weather/48/cloudy.png"
//3	
//day	"Tuesday"
//comment	"Scattered showers"
//max_temp	
//c	14
//f	58
//min_temp	
//c	7
//f	44
//iconURL	"https://ssl.gstatic.com/onebox/weather/48/rain_s_cloudy.png"
//4	
//day	"Wednesday"
//comment	"Showers"
//max_temp	
//c	14
//f	57
//min_temp	
//c	6
//f	43
//iconURL	"https://ssl.gstatic.com/onebox/weather/48/rain_light.png"
//5	
//day	"Thursday"
//comment	"Mostly cloudy"
//max_temp	
//c	16
//f	61
//min_temp	
//c	8
//f	47
//iconURL	"https://ssl.gstatic.com/onebox/weather/48/partly_cloudy.png"
//6	
//day	"Friday"
//comment	"Scattered showers"
//max_temp	
//c	16
//f	60
//min_temp	
//c	8
//f	47
//iconURL	"https://ssl.gstatic.com/onebox/weather/48/rain_s_cloudy.png"
//7	
//day	"Saturday"
//comment	"Scattered showers"
//max_temp	
//c	17
//f	63
//min_temp	
//c	8
//f	47
//iconURL	"https://ssl.gstatic.com/onebox/weather/48/rain_s_cloudy.png"
//contact_author	
//email	"communication.with.users@gmail.com"
//auth_note	"Mail me for feature requests, improvement, bug, help, ect... Please tell me if you want me to provide any other free easy-to-use API services"
//data_source	"https://www.google.com/search?lr=lang_en&q=weather+in+london"