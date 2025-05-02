using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public float pickupRange = 3f;
    public Transform holdPoint;
    public KeyCode interactKey = KeyCode.E;

    private GameObject heldObject;
    private Rigidbody heldRb;

    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            if (heldObject == null)
            {
                TryPickup();
            }
            else
            {
                DropObject();
            }
        }

        if (heldObject != null)
        {
            heldObject.transform.position = holdPoint.position;
        }
    }

    void TryPickup()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        Debug.DrawRay(ray.origin, ray.direction * pickupRange, Color.red, 1f);

        if (Physics.Raycast(ray, out hit, pickupRange))
        {
            Debug.Log("Raycast hit: " + hit.collider.name);

            if (hit.collider.CompareTag("Pickup"))
            {
                heldObject = hit.collider.gameObject;
                heldRb = heldObject.GetComponent<Rigidbody>();

                if (heldRb != null)
                {
                    heldRb.useGravity = false;
                    heldRb.velocity = Vector3.zero;
                    heldRb.angularVelocity = Vector3.zero;
                    heldRb.constraints = RigidbodyConstraints.FreezeRotation;
                }

                heldObject.transform.position = holdPoint.position;
                heldObject.transform.parent = holdPoint;
                Debug.Log("Picked up object: " + heldObject.name);
            }
            else
            {
                Debug.Log("Hit object is not tagged 'Pickup'");
            }
        }
        else
        {
            Debug.Log("Raycast hit nothing");
        }
    }

    void DropObject()
    {
        if (heldObject != null)
        {
            heldObject.transform.parent = null;

            if (heldRb != null)
            {
                heldRb.useGravity = true;
                heldRb.constraints = RigidbodyConstraints.None;
            }

            heldObject = null;
            heldRb = null;
        }
    }
}