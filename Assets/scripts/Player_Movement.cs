using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;
    // Update is called once per frame
    void Update()
    {
        //Prossesing input
        ProcessInputs();
    }

    void FixedUpdate()
    {
        //Phisics calculations
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX,moveY).normalized;
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * movespeed, moveDirection.y * movespeed);
    }
}
