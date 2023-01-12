namespace SQSTRSolar.Api.Models;

public class StationInfo
{
  public string QueryId { get; set; }
  public string Lat { get; set; }
  public string Lon { get; set; }
  public double Tz { get; set; }
  public string Location { get; set; }
  public string City { get; set; }
  public string State { get; set; }
  public string SolarResourceFile { get; set; }
  public string WeatherDataSource { get; set; }
}