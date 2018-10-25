using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 1;
    public GameObject impactEffect;
    public float deSpawnTime = 5f;
    public float time;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;	
	}

    private void Update()
    {
        time += Time.deltaTime;
        if (time > deSpawnTime)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Health health = hitInfo.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
            Instantiate(impactEffect, transform.position, Quaternion.identity);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);	
	}
}
