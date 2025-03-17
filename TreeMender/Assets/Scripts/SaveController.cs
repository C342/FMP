using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.U2D;

public class SaveController : MonoBehaviour
{
    private string saveLocation;
    private InventoryController inventoryController;

    void Start()
    {
        saveLocation = Path.Combine(Application.persistentDataPath, "saveData.json");
        inventoryController = FindObjectOfType<InventoryController>();

        LoadGame();
    }

    public void SaveGame()
    {
        playerPosition = gameObject.FindObjectWithTag("Player").transform.position;
        mapBoundary = FindObjectOfType<CinemachineConfiner>().m_BoundingShape2D.gameObject.name;
    }

    File.WriteAllText(saveLocation, JsonUtility.ToJson(saveData));
}

public void LoadGame()
{
    if (File.Exists(saveLocation))
    {
        SaveData saveData = JsonUtility.FromJson<SaveData>(File.ReadAllText(saveLocation));

        GameObject.FindObjectWithTag("Player").transform.position = saveData.playerPosition;
    }
}
