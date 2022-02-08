// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Http.Json;
using APIKey;

HttpClient Http = new();

WeatherForecast weatherForecast = await Http.GetFromJsonAsync<WeatherForecast>("https://localhost:7052/WeatherForecast?apikey=12345");

Console.WriteLine(weatherForecast.Date);
Console.WriteLine(weatherForecast.Summary);
Console.WriteLine(weatherForecast.TemperatureC);
Console.WriteLine(weatherForecast.TemperatureF);
