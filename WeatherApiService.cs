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

        private readonly Uri _baseAddress = new ("https://weatherdbi.herokuapp.com/data/weather/");
        
        private readonly HttpClient _client;
        public WeatherApiService(HttpClient client)
        {
           
           
            _client = client;
          
        }
        public async Task<Forecast> GetForecast(string location)
        {
            Forecast? forecast = new ();
            try 
            {
                var response = await _client.GetAsync(_baseAddress + location);

               
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
                        errorMessage = new();
                    }

                    throw new WeatherApiException(errorMessage.ToString());
                }
            }
            catch (Exception) { throw; }
         
    
            return forecast;

        }
    }
}
