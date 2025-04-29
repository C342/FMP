using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;     // The prefab to spawn
    public Vector2 spawnAreaMin = new Vector2(-10, -5);  // Bottom-left corner
    public Vector2 spawnAreaMax = new Vector2(10, 5);    // Top-right corner
    public float spawnInterval = 2f;     // Time between spawns in seconds

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 0f, spawnInterval);
    }

    void SpawnObject()
    {
        if (objectToSpawn == null)
        {
            Debug.LogWarning("No object assigned to spawn.");
            return;
        }

        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}