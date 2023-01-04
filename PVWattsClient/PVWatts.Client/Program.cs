using System.Net.Http.Headers;

using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
  new MediaTypeWithQualityHeaderValue("application/json"));

await GetSolarPVPotential(client);

static async Task GetSolarPVPotential(HttpClient client)
{
  try
  {
    var json = await client.GetStringAsync(
      "https://developer.nrel.gov/api/pvwatts/v8.json?api_key=[REDACTED]&system_capacity=7.5&module_type=0&losses=23.8&array_type=1&tilt=26.565&azimuth=162.5&lat=45.55908915917461&lon=-122.68163691381875"
    );

    Console.Write(json);
  }
  catch (HttpRequestException e)
  {
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message: :{0} ", e.Message);
  }
}