using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeCuttable : ToolHit
{
    public AudioSource audioSource;

    [SerializeField] GameObject pickUpDrop;
    [SerializeField] static int DropCount = 2;
    [SerializeField] float spread = 0.7f;

    public override void Hit()
    {

        while (DropCount > 0)
        {
            DropCount -= 1;

            Vector3 position = transform.position;
            position.x += spread * UnityEngine.Random.value - spread / 2;
            position.y += spread * UnityEngine.Random.value - spread / 2;
            GameObject go = Instantiate(pickUpDrop);
            go.transform.position = position;
        }
        Destroy(gameObject);
        audioSource.Play();
        if (Input.GetMouseButtonDown(0))
        {
            ShopAcornCount.shopAcornText.text = "Acorns: " + -2;
        }
    }
    public void CursedTreeCut()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShopAcornCount.shopAcornText.text = "Acorns: " + 2;
        }
    }
}