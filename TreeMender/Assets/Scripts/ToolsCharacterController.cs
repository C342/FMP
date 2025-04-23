using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ToolsCharacterController : MonoBehaviour
{
    CharacterController character;
    Rigidbody2D rb;
    [SerializeField] float offsetDistance = 1f;
    [SerializeField] float sizeOfInteractableArea = 1.2f;

    Vector2 lastMotionVector;

    private void Awake()
    {
        character = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (input != Vector2.zero)
        {
            lastMotionVector = input.normalized;
        }

        if (Input.GetMouseButton(0))
        {
            UseTool();
        }
    }

    private void UseTool()
    {
        Vector2 position = rb.position + lastMotionVector * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach (Collider2D c in colliders)
        {
            ToolHit hit = c.GetComponent<ToolHit>();
            if (hit != null)
            {
                hit.Hit();
                break;
            }
        }
    }
}