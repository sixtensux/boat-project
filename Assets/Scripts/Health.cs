using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public int maxHealth;
    public int health;

    public GameObject deathEffect;


    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage (int damage)
    {
    
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
	}
	
	void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
	}
}
