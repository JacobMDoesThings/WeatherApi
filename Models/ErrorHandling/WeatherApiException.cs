using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApi.Models.ErrorHandling
{
    public class WeatherApiException:Exception
    {
        public WeatherApiException()
        {
        }

        public WeatherApiException(string message)
            : base(message)
        {
        }

        public WeatherApiException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
