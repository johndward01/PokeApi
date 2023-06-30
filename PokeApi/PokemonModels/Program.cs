

using Newtonsoft.Json;
using PokeApi.PokemonModels;

var client = new HttpClient();
var url = "https://pokeapi.co/api/v2/pokemon/pikachu";
var response = client.GetStringAsync(url).Result;
var root = JsonConvert.DeserializeObject<Root>(response);

Console.WriteLine(root.sprites.front_default);
