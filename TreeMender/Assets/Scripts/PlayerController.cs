using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;

    private float speedX;
    private float speedY;
    private bool isFacingRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        speedX = Input.GetAxisRaw("Horizontal");
        speedY = Input.GetAxisRaw("Vertical");

        
        animator.SetFloat("xVelocity", Mathf.Abs(speedX));
        animator.SetFloat("yVelocity", Mathf.Abs(speedY));

        FlipSprite();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(speedX * moveSpeed, speedY * moveSpeed);
    }

    void FlipSprite()
    {
        if ((isFacingRight && speedX < 0) || (!isFacingRight && speedX > 0))
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }
}