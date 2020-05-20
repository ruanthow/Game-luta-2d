using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayers : MonoBehaviour
{
    private Rigidbody2D rg;
    private float hMove;
    private float vMove;
    private float speed = 6;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
       
    }
    private void Move()
    {
        hMove = Input.GetAxis("Horizontal");
        rg.velocity = new Vector2(hMove * speed, rg.velocity.y);
    }
    private void Jump()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
         
            
        }
       
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }
}
