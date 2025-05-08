using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public int Acorns = 0;
    public static GameManager Instance;

    public int WaterBucket;
    public int MWaterCan;
    public int LWaterCan;

    public TextMeshProUGUI cText;
    public TextMeshProUGUI BucketText;
    public TextMeshProUGUI MWaterCanText;
    public TextMeshProUGUI LWaterCanText;

    private void Start()
    {
        Acorns = AcornCounter.currentAcorns;
        cText.text = Acorns.ToString();
    }

    public void BuyWaterBucket()
    {
        if (Acorns >= 50)
        {
            Acorns -= 50;
            cText.text = Acorns.ToString();

            WaterBucket += 1;
            BucketText.text = WaterBucket.ToString();
        }
        else
        {
            print("Not enough acorns!");
        }
    }

    public void BuyMWaterCan()
    {
        if (Acorns >= 75)
        {
            Acorns -= 75;
            cText.text = Acorns.ToString();

            MWaterCan += 1;
            MWaterCanText.text = MWaterCan.ToString();
        }
        else
        {
            print("Not enough acorns!");
        }
    }
    public void BuyLWaterCan()
    {
        if (Acorns >= 100)
        {
            Acorns -= 100;
            cText.text = Acorns.ToString();

            LWaterCan += 1;
            LWaterCanText.text = LWaterCan.ToString();
        }
        else
        {
            print("Not enough acorns!");
        }
    }
}