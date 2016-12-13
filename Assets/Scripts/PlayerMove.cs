using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D rigidbody2D;

     // Awake is called when the script instance is being loaded
     void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // This function is called every fixed framerate frame, if the MonoBehaviour is enabled
    void FixedUpdate()
    {
        float xMove = Input.GetAxis("Horizontal");
        float yMove = Input.GetAxis("Vertical");

        float xSpeed = xMove * speed;
        float ySpeed = yMove * speed;

        Vector2 newVelocity = new Vector2(xSpeed, ySpeed);

        rigidbody2D.velocity = newVelocity;
    }
}
