using System.Net.Http.Headers;
using PVWatts.Client.Models;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
  new MediaTypeWithQualityHeaderValue("application/json"));

var apiKey = Environment.GetEnvironmentVariable("PVWattsKey");
// When launched from Finder on Mac, this project will not inherit environment variables.
// To resolve, launch VS Code from the Terminal.

await GetSolarPVPotential(client, apiKey);

static async Task GetSolarPVPotential(HttpClient client, string key)
{
  try
  {
    var json = await client.GetStringAsync(
      $"https://developer.nrel.gov/api/pvwatts/v8.json?api_key={key}&system_capacity={Request.SystemCapacity}&module_type={Request.ModuleType}&losses={Request.Losses}&array_type={Request.ArrayType}&tilt={Request.Tilt}&azimuth={Request.Azimuth}&lat={Request.Lat}&lon={Request.Lon}"
    );

    Console.Write(json);
  }
  catch (HttpRequestException e)
  {
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message: :{0} ", e.Message);
  }
}
