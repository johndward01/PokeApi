using Newtonsoft.Json;

namespace PokeApi.PokemonModels;

public class GenerationVii
{
    public Icons icons { get; set; }

    [JsonProperty("ultra-sun-ultra-moon")]
    public UltraSunUltraMoon ultrasunultramoon { get; set; }
}
