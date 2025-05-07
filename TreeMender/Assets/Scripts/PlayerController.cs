using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector2 moveInput;
    private Rigidbody2D rb;
    private Animator animator;


    float horizontalMove = 0f;
    float verticalMove = 0f;

    private float speedX;
    private float speedY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Animate();

        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(horizontalMove * moveSpeed, verticalMove * moveSpeed);

        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

    void Animate()
    {
            animator.SetFloat("Xinput", moveInput.x);
            animator.SetFloat("Yinput", moveInput.y);
    }
}