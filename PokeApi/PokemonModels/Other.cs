﻿using Newtonsoft.Json;

namespace PokeApi.PokemonModels;

public class Other
{
    public DreamWorld dream_world { get; set; }
    public Home home { get; set; }

    [JsonProperty("official-artwork")]
    public OfficialArtwork officialartwork { get; set; }
}
