using Newtonsoft.Json;

namespace PokeApi.PokemonModels;

public class GenerationIii
{
    public Emerald emerald { get; set; }

    [JsonProperty("firered-leafgreen")]
    public FireredLeafgreen fireredleafgreen { get; set; }

    [JsonProperty("ruby-sapphire")]
    public RubySapphire rubysapphire { get; set; }
}
