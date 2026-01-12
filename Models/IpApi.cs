namespace WeatherView.Models;

public class IpApiResponse
{
  public double latitude { get; set; }
  public double longitude { get; set; }
  public string? city { get; set; }
  public string? region { get; set; }
  public string? country_name { get; set; }
  public string? time_zone { get; set; }
}