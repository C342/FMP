using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public GameObject objectToEnable;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (objectToEnable != null)
            {
                objectToEnable.SetActive(true);
            }

            gameObject.SetActive(false);
        }
    }
}