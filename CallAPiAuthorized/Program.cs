// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Http.Json;
using APIKey;

HttpClient Http = new();

List<WeatherForecast> weatherForecast = await Http.GetFromJsonAsync<List<WeatherForecast>>(requestUri: "https://localhost:7052/WeatherForecast?apikey=12345");


foreach (var itemForecast in weatherForecast)
{
    Console.WriteLine(itemForecast.Date);
    Console.WriteLine(itemForecast.Summary);
    Console.WriteLine(itemForecast.TemperatureC);
    Console.WriteLine(itemForecast.TemperatureF);
}


Console.ReadLine();
