using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject Tree;
    public Vector2 spawnAreaMin = new Vector2(-10, -5);
    public Vector2 spawnAreaMax = new Vector2(10, 5);
    public float spawnInterval = 10f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnTree), 0f, spawnInterval);
    }

    void SpawnTree()
    {
        if (Tree == null)
        {
            Debug.LogWarning("No tree type assigned in inspector!");
            return;
        }

        Vector2 spawnPosition = new Vector2(
            Random.Range(spawnAreaMin.x, spawnAreaMax.x),
            Random.Range(spawnAreaMin.y, spawnAreaMax.y)
        );

        Instantiate(Tree, spawnPosition, Quaternion.identity);
    }
}