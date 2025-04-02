using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class TreeFell : MonoBehaviour
{
    public static TreeFell Instance;
    public GameObject logPrefab;
    public int Health;
    public Animator animator;

    private void Awake()
    {
        if (!Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {

    }

    public void Shake()
    {

    }

    public void TakeDamage()
    {
        Shake();
        Health--;
        if (Health <= 0)
        {
            Instantiate(logPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
