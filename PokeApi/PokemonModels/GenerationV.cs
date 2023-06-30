using Newtonsoft.Json;

namespace PokeApi.PokemonModels;

public class GenerationV
{
    [JsonProperty("black-white")]
    public BlackWhite blackwhite { get; set; }
}
