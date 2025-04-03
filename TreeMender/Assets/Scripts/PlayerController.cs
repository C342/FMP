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
    float verticalMove = 0f;

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

        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontalMove * moveSpeed, verticalMove * moveSpeed);

        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("FacingBackward", true);
            FacingBackward = true;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("FacingForward", true);
            FacingForward = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("FacingLeft", true);
            FacingLeft = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("FacingRight", true);
            FacingRight = true;
        }
        else
        {
            animator.SetBool("FacingBackward", false);
            animator.SetBool("FacingForward", false);
            animator.SetBool("FacingLeft", false);
            animator.SetBool("FacingRight", false);
        }
    }
}