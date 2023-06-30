using Newtonsoft.Json;

namespace PokeApi.PokemonModels;

public class GenerationVi
{
    [JsonProperty("omegaruby-alphasapphire")]
    public OmegarubyAlphasapphire omegarubyalphasapphire { get; set; }

    [JsonProperty("x-y")]
    public XY xy { get; set; }
}
