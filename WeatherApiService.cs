using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using WeatherApi.Models;
using WeatherApi.Models.ErrorHandling;

namespace WeatherApi
{
    public class WeatherApiService : IWeatherApiService
    {


        private readonly HttpClient _client;
        public WeatherApiService(HttpClient client)
        {

            _client = client;
        }
        public async Task<Forecast> GetForecast(string location)
        {
            Forecast? forecast = new ();
            var response = await _client.GetAsync(location);
            Console.WriteLine(_client.BaseAddress+location); ;
            Console.WriteLine(response.StatusCode.ToString());
            if (response.IsSuccessStatusCode)
            {
                
                forecast = await response.Content.ReadFromJsonAsync<Forecast>();
                if (forecast is null)
                {
                    forecast = new Forecast();
                }

            }
            else if (response.StatusCode == HttpStatusCode.UnprocessableEntity || response.StatusCode == HttpStatusCode.BadRequest)
            {
                var errorMessage = await response.Content.ReadFromJsonAsync<ErrorResponse>();
                if (errorMessage is null)
                {
                    errorMessage = new ();
                }
             
                throw new WeatherApiException(errorMessage.ToString());
            }
            return forecast;

        }
    }
}
