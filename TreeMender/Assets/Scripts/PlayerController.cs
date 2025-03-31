using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private string currentState;

    private Rigidbody2D rb;
    private Animator animator;

    private float speedX;
    private float speedY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.Play("Idle");
    }

    void ChangeAnimationState(string newState)
    {

    }

    void Update()
    {

        speedX = Input.GetAxisRaw("Horizontal");
        speedY = Input.GetAxisRaw("Vertical");


        animator.SetFloat("xVelocity", Mathf.Abs(speedX));
    }
}