using WeatherView.Models;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace WeatherView.Services
{
  public class WeatherService
  {
    private readonly HttpClient _httpClient;
    private readonly string _baseUrl;
    
    public WeatherService(HttpClient httpClient, IConfiguration configuration)  {
      _httpClient = httpClient;
      _baseUrl = configuration["WeatherApi:BaseUrl"] ?? "https://api.open-meteo.com/v1/forecast";
    }

    public async Task<GeolocationData?> GetLocationFromIpAsync()
    {
      try
      {
        var response = await _httpClient.GetAsync("https://ipapi.co/json/");
        
        if(response.IsSuccessStatusCode)
        {
          var json = await response.Content.ReadAsStringAsync();
          var data = JsonSerializer.Deserialize<GeolocationData>(json);

          if(data != null)
          {
            return new GeolocationData 
            {
              Latitude = data.Latitude,
              Longitude = data.Longitude,
              Accuracy = 5000 // Approximate accuracy for IP-based location
            };
          }
        }
      } catch (Exception)
      {
        Console.WriteLine("Error fetching IP-based location.");
      }
      return null;
    }

    public async Task<WeatherResponse?> GetWeatherAsync(double latitude, double longitude, string timezone = "America/Denver")
    {
      var url = $"{_baseUrl}?latitude={latitude}&longitude={longitude}&current_weather=true&timezone={timezone}";
      var response = await _httpClient.GetAsync(url);
      if (response.IsSuccessStatusCode)
      {
        var weatherResponse = await response.Content.ReadFromJsonAsync<WeatherResponse>();
        return weatherResponse;
      }
      return null;
    }
  }
}