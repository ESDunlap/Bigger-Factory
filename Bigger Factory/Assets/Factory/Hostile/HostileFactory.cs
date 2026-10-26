using UnityEngine;

public class HostileFactory : INPCFactory
{
    private GameObject prefab;
    private Vector3 randomLocation;
    public INPC Create(NPCRequirements requirements)
    {
        switch(requirements.RichLevel)
        {
            case Richness.Low:
                {
                    prefab = Resources.Load("Goblin") as GameObject;
                    break;
                }
            case Richness.Middle:
                {
                    prefab = Resources.Load("Orc") as GameObject;
                    break;
                }
            case Richness.High:
                {
                    prefab = Resources.Load("Dragon") as GameObject;
                    break;
                }
        }

        switch (requirements.SpawnArea)
        {
            case SpawnLocation.Grass:
                {
                    randomLocation = new Vector3(Random.Range(-10.0f, 10.0f),
                    1f,
                    Random.Range(-10.0f, 10.0f));
                    break;
                }
            case SpawnLocation.Desert:
                {
                    randomLocation = new Vector3(Random.Range(30.0f, 50.0f),
                    1f,
                    Random.Range(-10.0f, 10.0f));
                    break;
                }
        }

        Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0f, 360.0f), 0);
        var finishedNPC = GameObject.Instantiate(prefab, randomLocation, Quaternion.identity) as GameObject;
        finishedNPC.transform.rotation = randomRotation;
        return finishedNPC.GetComponent<INPC>();
    }
}
