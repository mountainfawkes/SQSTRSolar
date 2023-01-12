namespace SQSTRSolar.Api.Models;

public class Query
{
  public string Id { get; set; }
  public string Date { get; set; }
  public string SystemCapacity { get; set; }
  public string ModuleType { get; set; }
  public string Losses { get; set; }
  public string ArrayType { get; set; }
  public string Tilt { get; set; }
  public string Azimuth { get; set; }
  public string Lat { get; set; }
  public string Lon { get; set; }
  public string PVWattsVersion { get; set; }
  public int SscVersion { get; set; }
  public string SscBuild { get; set; }
  public string SscModule { get; set; }
}