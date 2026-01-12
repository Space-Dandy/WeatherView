using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherView.Models
{
    public class CurrentWeather
    {
        [JsonPropertyName("time")]
        public string time { get; set; }

        [JsonPropertyName("interval")]
        public int interval { get; set; }

        [JsonPropertyName("temperature")]
        public double temperature { get; set; }

        [JsonPropertyName("windspeed")]
        public double windspeed { get; set; }

        [JsonPropertyName("winddirection")]
        public int winddirection { get; set; }

        [JsonPropertyName("is_day")]
        public int is_day { get; set; }

        [JsonPropertyName("weathercode")]
        public int weathercode { get; set; }
    }

    public class CurrentWeatherUnits
    {
        [JsonPropertyName("time")]
        public string time { get; set; }

        [JsonPropertyName("interval")]
        public string interval { get; set; }

        [JsonPropertyName("temperature")]
        public string temperature { get; set; }

        [JsonPropertyName("windspeed")]
        public string windspeed { get; set; }

        [JsonPropertyName("winddirection")]
        public string winddirection { get; set; }

        [JsonPropertyName("is_day")]
        public string is_day { get; set; }

        [JsonPropertyName("weathercode")]
        public string weathercode { get; set; }
    }

    public class WeatherResponse
    {
        [JsonPropertyName("latitude")]
        public double latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double longitude { get; set; }

        [JsonPropertyName("generationtime_ms")]
        public double generationtime_ms { get; set; }

        [JsonPropertyName("utc_offset_seconds")]
        public int utc_offset_seconds { get; set; }

        [JsonPropertyName("timezone")]
        public string timezone { get; set; }

        [JsonPropertyName("timezone_abbreviation")]
        public string timezone_abbreviation { get; set; }

        [JsonPropertyName("elevation")]
        public double elevation { get; set; }

        [JsonPropertyName("current_weather_units")]
        public CurrentWeatherUnits current_weather_units { get; set; }

        [JsonPropertyName("current_weather")]
        public CurrentWeather current_weather { get; set; }
    }
}