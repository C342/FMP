using Unity.VisualScripting;
using UnityEngine;

public class AcornSpawner : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject acornPrefab;

    private void Start()
    {
        SpawnAcorns();
    }

    void SpawnAcorns()
    {
        for (int i = 0; i < spawnLocations.Length; i++)
        {
            GameObject newAcorn = Instantiate<GameObject>(acornPrefab);
            newAcorn.transform.position = spawnLocations[i].position; 
        }
    }
}