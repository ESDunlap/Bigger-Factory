using System.Collections;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Client : MonoBehaviour
{
    public NPCRequirements currentRequest = new NPCRequirements();
    public NPCSpawner m_SpawnerNPC;
    public void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.I))
        {
            m_SpawnerNPC.SpawnBeggar();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            m_SpawnerNPC.SpawnFarmer();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            m_SpawnerNPC.SpawnShopowner();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            m_SpawnerNPC.SpawnGoblin();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            m_SpawnerNPC.SpawnOrc();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            m_SpawnerNPC.SpawnDragon();
        }*/
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 10, 150, 20), "Change Wealth"))
        {
            if(currentRequest.RichLevel == Richness.High)
                currentRequest.RichLevel = Richness.Low;
            else
                currentRequest.RichLevel = (currentRequest.RichLevel + 1);
        }
        if (GUI.Button(new Rect(10, 30, 150, 20), "Change Hostility"))
        {
            if (currentRequest.Friendliness == Friendly.Hostile)
                currentRequest.Friendliness = Friendly.Friendly;
            else
                currentRequest.Friendliness = (currentRequest.Friendliness + 1);
        }
        if (GUI.Button(new Rect(10, 50, 150, 20), "Change Location"))
        {
            if(currentRequest.SpawnArea == SpawnLocation.Grass)
                currentRequest.SpawnArea = SpawnLocation.Desert;
            else
                currentRequest.SpawnArea = SpawnLocation.Grass;
        }
        if (GUI.Button(new Rect(10, 70, 150, 20), "Spawn NPC"))
        {
            m_SpawnerNPC.SpawnRequest(currentRequest);
        }
        GUI.Label(new Rect(200, 10, 150, 20), "Wealth: " + currentRequest.RichLevel);
        GUI.Label(new Rect(200, 30, 150, 20), "Friendly: " + currentRequest.Friendliness);
        GUI.Label(new Rect(200, 50, 150, 20), "Spawn Location: " + currentRequest.SpawnArea);
    }
}
