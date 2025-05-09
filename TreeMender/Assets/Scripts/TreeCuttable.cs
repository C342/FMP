using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCuttable : ToolHit
{
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
        AcornCounter.currentAcorns -= 2;
    }

    public void CursedTreeCut()
    {
        {
            AcornCounter.currentAcorns += 2;
        }
    }
}