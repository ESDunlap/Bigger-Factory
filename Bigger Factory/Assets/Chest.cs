using UnityEngine;

public class Chest: MonoBehaviour, INPC, Medium
{
    public void Spawn()
    {

    }
    public void Speak()
    {
        Debug.Log("Shine Shine");
    }
    public void Move()
    {

    }

    public GameObject getGameObject() { return gameObject; }
}
