using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AcornCounter : MonoBehaviour
{
    public static AcornCounter instance;

    public TMP_Text acornText;
    public static int currentAcorns = 0;

    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        acornText.text = "Acorns: " + currentAcorns.ToString();
    }

    public void IncreaseAcorns(int v)
    {
        currentAcorns += v;
        acornText.text = "Acorns: " + currentAcorns.ToString();
    }
}