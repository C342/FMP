using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameObject player;
    int Acorns = AcornCounter.currentAcorns;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = GameManager.Instance;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool SpendAcorns(int amount)
    {
        if (Acorns >= amount)
        {
            Acorns -= amount;
            return true;
        }
        return false;
    }

    public void AddAcorns(int amount)
    {
        Acorns += amount;
    }
}
