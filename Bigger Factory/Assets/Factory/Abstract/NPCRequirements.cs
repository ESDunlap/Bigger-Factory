using UnityEngine;

public enum Richness
{
    Low,
    Middle,
    High
}

public enum SpawnLocation
{
    Grass,
    Desert
}

public enum Friendly
{
    Friendly,
    Neutral,
    Hostile
}

public class NPCRequirements
{
    public Friendly Friendliness { get; set; }
    public Richness RichLevel { get; set; }
    public SpawnLocation SpawnArea { get; set; }
}
