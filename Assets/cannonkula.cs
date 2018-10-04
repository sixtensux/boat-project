using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonkula : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;

	void Start ()
    {
        rb.velocity = transform.up * speed;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
