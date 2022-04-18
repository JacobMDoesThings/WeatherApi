# WeatherApi
.Net Library for weatherdbi.herokuapp.com Api

Install with nuget
Install-Package WeatherDbWeatherApi -Version 1.0.2

Create or inject new WeatherApiService passing a HttpClient dependency.
HttpClient must have unaltered BaseAddress.

Call await GetForecast(string location)
location can be (zipcode) when applicable, (city, state,) (city state) etc...

get a Forecast object in response.  If a 400 or 422 (bad chars) (unprocessable location)
a WeatherApiException is thrown with a response describing the issue.

Find out more here https://weatherdbi.herokuapp.com/documentation/v1
