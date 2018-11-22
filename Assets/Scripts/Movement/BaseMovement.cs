using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BaseMovement : MonoBehaviour
{

	protected Rigidbody2D rb2d;

	[Header("Speed")]
	//[Range(0.1f, 20f)]
	//public float acceleration;
	[Range(0.1f, 15f)]
	public float maxSpeed;
	[Range(0.1f, 10f)]
	public float turnSpeed;
	private Vector2 direction;

	[Header("Player")]
	public bool player1;

	private float moveVertical;
	private float moveHorizontal;

	private bool rotateRight;
	private bool rotateLeft;

	void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();
		rb2d.gravityScale = 0;
		rb2d.drag = 2.5f;
		rb2d.angularDrag = 2.5f;
	}

	void Update()
	{
		if (player1)
		{
			if (Input.GetAxis("P1LeftStickHorizontal") != 0 || Input.GetAxis("P1LeftStickVertical") != 0)
			{
				moveHorizontal = Input.GetAxis("P1LeftStickHorizontal");
				moveVertical = Input.GetAxis("P1LeftStickVertical");

			}
			else
			{
				moveHorizontal = Input.GetAxis("P1KeyHorizontal");
				moveVertical = Input.GetAxis("P1KeyVertical");
			}
		}
		else if (!player1)
		{
			if (Input.GetAxis("P2LeftStickHorizontal") != 0 || Input.GetAxis("P2LeftStickVertical") != 0)
			{
				moveHorizontal = Input.GetAxis("P2LeftStickHorizontal");
				moveVertical = Input.GetAxis("P2LeftStickVertical");
			}
			else
			{
				moveHorizontal = Input.GetAxis("P2KeyHorizontal");
				moveVertical = Input.GetAxis("P2KeyVertical");
			}
		}

		if (player1)
		{
			if (Input.GetAxis("P1RightStickHorizontal") >= 0 || Input.GetKey(KeyCode.PageDown))
			{
				rotateRight = true;
			}
			else
			{
				rotateRight = false;
			}
			if (Input.GetAxis("P1RightStickHorizontal") <= 0 || Input.GetKey(KeyCode.PageUp))
			{
				rotateLeft = true;
			}
			else
			{
				rotateLeft = false;
			}
		}
		else if (!player1)
		{
			if (Input.GetAxis("P2RightStickHorizontal") >= 0 || Input.GetKey(KeyCode.E))
			{
				rotateRight = true;
			}
			else
			{
				rotateRight = false;
			}
			if (Input.GetAxis("P2RightStickHorizontal") <= 0 || Input.GetKey(KeyCode.Q))
			{
				rotateLeft = true;
			}
			else
			{
				rotateLeft = false;
			}

		}
		else
		{
			print("Indecisive Bitch");
		}
	}

	void FixedUpdate()
	{
		direction = (Vector2.right * moveHorizontal + Vector2.up * moveVertical);
		direction = direction.normalized;
		rb2d.AddForce(direction * maxSpeed);

		/*if (rb2d.velocity.x > maxSpeed)
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
        }*/

		if (rotateRight && rotateLeft)
		{
		}
		else if (rotateRight)
		{
			transform.Rotate(0, 0, -turnSpeed);
		}
		else if (rotateLeft)
		{
			transform.Rotate(0, 0, turnSpeed);
		}
	}
}