using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BaseMovement : MonoBehaviour
{

    Rigidbody2D rb2d;

    [Header("Speed")]
    [Range(0.1f, 20f)]
    public float speed;
    [Range(0.1f, 10f)]
    public float turnSpeed;
    [Range(0.1f, 10f)]
    public float maxSpeed;

    public float moveVertical;
    float moveHorizontal;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.gravityScale = 0;
    }

    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");

        moveVertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 movement;
        movement.x = moveHorizontal * speed;
        movement.y = moveVertical * speed;
        //rb2d.velocity = movement;
        rb2d.AddForce(Vector2.right * speed * moveHorizontal);
        rb2d.AddForce(Vector2.up * speed * moveVertical);

        if (rb2d.velocity.x > maxSpeed)
        {
            Vector2 velocity = rb2d.velocity;
            velocity.x = maxSpeed;
            rb2d.velocity = velocity;
        }
        else if (rb2d.velocity.x < -maxSpeed)
        {
            Vector2 velocity = rb2d.velocity;
            velocity.x = -maxSpeed;
            rb2d.velocity = velocity;
        }

        if (rb2d.velocity.y >= maxSpeed)
        {
            Vector2 velocity = rb2d.velocity;
            velocity.y = maxSpeed;
            rb2d.velocity = velocity;
        }
        else if (rb2d.velocity.y <= -maxSpeed)
        {
            Vector2 velocity = rb2d.velocity;
            velocity.y = -maxSpeed;
            rb2d.velocity = velocity;
        }
    }
}