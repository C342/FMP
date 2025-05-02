using UnityEngine;

public class AcornSpawner : MonoBehaviour
{
    public GameObject Acorn;
    public Vector2 spawnAreaMin = new Vector2(-10, -5);
    public Vector2 spawnAreaMax = new Vector2(10, 5);
    public float spawnInterval = 5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 0f, spawnInterval);
    }

    void SpawnObject()
    {
        if (Acorn == null)
        {
            Debug.LogWarning("No acorn assigned in inspector!");
            return;
        }

        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        Instantiate(Acorn, spawnPosition, Quaternion.identity);
    }
}