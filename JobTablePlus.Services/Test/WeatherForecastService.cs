using JobTablePlus.Models.Models;

namespace JobTablePlus.Services.Test;

using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
using System.Text.Json;

public class WeatherForecastService
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public WeatherForecastService(HttpClient httpClient, IConfiguration configuration)
    {   
        _httpClient = httpClient;
        _configuration = configuration;
    }

    public async Task<IEnumerable<WeatherForecast>> GetForecastAsync(DateTime startDate)
    {
        var request = "https://localhost:44347/WeatherForecast";


        IEnumerable<WeatherForecast>? result = await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>(request);


        return result ?? Array.Empty<WeatherForecast>();


        //return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //{
        //    Date = startDate.AddDays(index),
        //    TemperatureC = Random.Shared.Next(-20, 55),
        //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //}).ToArray());

    }
}