using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopEnable : MonoBehaviour
{
    public string sceneName = "TargetScene";         
    public string objectName = "ObjectToEnable";
    public int cost = 5;

    public void TryEnableObject()
    {
        if (GameManager.Instance == null)
        {
            Debug.LogError("GameManager instance not found!");
            return;
        }

        if (GameManager.Instance.SpendAcorns(cost))
        {
            Scene targetScene = SceneManager.GetSceneByName(sceneName);
            if (!targetScene.isLoaded)
            {
                Debug.LogWarning("Scene not loaded: " + sceneName);
                return;
            }

            GameObject[] rootObjects = targetScene.GetRootGameObjects();
            foreach (GameObject obj in rootObjects)
            {
                if (obj.name == objectName)
                {
                    obj.SetActive(true);
                    Debug.Log("Enabled object: " + objectName);
                    return;
                }
            }

            Debug.LogWarning("Object not found in scene: " + objectName);
        }
        else
        {
            Debug.Log("Not enough acorns.");
        }
    }
}