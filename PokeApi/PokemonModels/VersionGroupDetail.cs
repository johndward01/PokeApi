﻿namespace PokeApi.PokemonModels;

public class VersionGroupDetail
{
    public int level_learned_at { get; set; }
    public MoveLearnMethod move_learn_method { get; set; }
    public VersionGroup version_group { get; set; }
}
