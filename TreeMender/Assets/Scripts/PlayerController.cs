using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    float horizontalMove = 0f;

    bool FacingBackward = false;
    bool FacingForward = false;
    bool FacingLeft = false;
    bool FacingRight = false;

    private float speedX;
    private float speedY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {



        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("FacingBackward", (FacingBackward = true));
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("FacingForward", (FacingForward = true));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("FacingLeft", (FacingLeft = true));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("FacingRight", (FacingRight = true));
        }
    }
}