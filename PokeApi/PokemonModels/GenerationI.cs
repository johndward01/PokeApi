using Newtonsoft.Json;

namespace PokeApi.PokemonModels;

public class GenerationI
{
    [JsonProperty("red-blue")]
    public RedBlue redblue { get; set; }
    public Yellow yellow { get; set; }
}
