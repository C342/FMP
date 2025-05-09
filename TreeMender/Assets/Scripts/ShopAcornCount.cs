using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopAcornCount : MonoBehaviour
{
    public static ShopAcornCount Instance;

    public static TMP_Text shopAcornText;
    public static int currentAcorns = 0;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        shopAcornText.text = "Acorns: " + currentAcorns.ToString();
    }

    public void GetShopAcorns(int v)
    {
        currentAcorns += v;
        shopAcornText.text = "Acorns: " + AcornCounter.currentAcorns.ToString();
    }
}