using RestSharp;
using System.Text.Json;

RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest request = new RestRequest("pokemon/xftjdtyj");
RestResponse response = pokeClient.GetAsync(request).Result;

if (response.StatusCode.ToString() == "OK")
{
  Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);
  Console.WriteLine(p.Name);
}


Console.ReadLine();