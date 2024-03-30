using UnityEngine;

public class SpawnOverTimeScript : MonoBehaviour
{
    // Object to spawn
    [SerializeField]
    private GameObject spawnObject;

    // Delay between spawns
    [SerializeField]
    private float spawnDelay = 2f;

    private Renderer render;

    // Use this for initialization
    void Start()
    {
        render = GetComponent<Renderer>();

        // Stop our Spawner from being visible!
        render.enabled = false;

        // Call the given function after spawnDelay seconds, 
        // and then repeatedly call it after spawnDelay seconds.
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    void Spawn()
    {
        // Calculates the minimum x-coordinate that objects can spawn
        float minXBound = transform.position.x - render.bounds.size.x / 2;
        // Calculates the maximum x-coordinate that objects can spawn
        float maxXBound = transform.position.x + render.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(minXBound, maxXBound), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
