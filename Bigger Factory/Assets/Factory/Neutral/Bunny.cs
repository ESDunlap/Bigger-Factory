using UnityEngine;

public class Bunny : MonoBehaviour, INPC
{
    private float pauseTime;
    private float maxX = 20f;
    private float maxZ = 20f;
    private float minX = -20f;
    private float minZ = -20f;
    private Vector3 startLocation;
    private Vector3 endLocation;
    private float movementTime = 0;
    private float totalDistance;
    private bool reachedEnd = false;
    private float stopTimer = 0;

    public void Spawn()
    {
        startLocation = transform.position;
        endLocation = new Vector3(Random.Range(minX, maxX),
            transform.position.y,
            Random.Range(minZ, maxZ));
        totalDistance = Vector3.Distance(startLocation, endLocation);
        pauseTime = Random.Range(0, 50f);
    }
    public void Speak()
    {
        Debug.Log("I'M GONNA STAB YOU!");
    }
    public void Move()
    {
        if (reachedEnd)
        {
            stopTimer += Time.deltaTime;
            if (stopTimer > pauseTime)
            {
                reachedEnd = false;
                stopTimer = 0;
                startLocation = transform.position;
                endLocation = new Vector3(Random.Range(minX, maxX),
                    transform.position.y,
                    Random.Range(minZ, maxZ));
                totalDistance = Vector3.Distance(startLocation, endLocation);
                pauseTime = Random.Range(0, 50f);
            }
        }
        else
        {
            movementTime += Time.deltaTime * 5f * 1 / totalDistance;
            transform.position = new Vector3(
            Mathf.Lerp(startLocation.x, endLocation.x, movementTime),
            startLocation.y,
            Mathf.Lerp(startLocation.z, endLocation.z, movementTime));
            if (movementTime >= 1)
            {
                reachedEnd = true;
                movementTime = 0;
            }
        }
    }
}
