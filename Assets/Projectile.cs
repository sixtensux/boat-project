using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 40;
    public GameObject impactEffect;

	void Start ()
    {
        rb.velocity = transform.up * speed;	
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Health health = hitInfo.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);	
	}
}
