using System.Net.Http.Json;
using APIKey;

HttpClient Http = new();
List<WeatherForecast> weatherForecast = await Http.GetFromJsonAsync<List<WeatherForecast>>(requestUri: "https://localhost:7052/WeatherForecast?apikey=12345");

foreach (var itemForecast in weatherForecast)
{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine($"Date: {itemForecast.Date}");
    Console.WriteLine($"Summary: {itemForecast.Summary}");
    Console.WriteLine($"Temp C: {itemForecast.TemperatureC}");
    Console.WriteLine($"Temp F: {itemForecast.TemperatureF}");
}
Console.ReadLine();
