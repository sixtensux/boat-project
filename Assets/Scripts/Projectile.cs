using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float speed = 20f;
    public Rigidbody2D rb;
    public int damage = 1;
    public float inAccuracy = 0;
    public GameObject impactEffect;
    public float deSpawnTime = 5f;
    public float time;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (inAccuracy > 0)
        {
            transform.Rotate(0, 0, Random.Range(-inAccuracy, inAccuracy));
        }
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



    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Instantiate(impactEffect, transform.position, Quaternion.identity);

        Health health = hitInfo.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}