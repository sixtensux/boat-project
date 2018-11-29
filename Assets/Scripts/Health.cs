using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(SpriteRenderer))]
public class Health : MonoBehaviour
{

    public float maxHealth;
    public float health;

    public GameObject deathEffect;
    public Sprite[] spriteStates; //stores sprites

    private float percentHp;

    SpriteRenderer spriteRenderer;


    private void Start()
    {
        health = maxHealth;

        //reverses the array of sprites so they show in the correct order
        System.Array.Reverse(spriteStates);

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>(); //assigns the Spriterenderer as spriterenderer

        //null check
        if (spriteRenderer == null)
        {
            Debug.Log($"spriterenderer is null on {gameObject.name}");
        }
        else
        {
            spriteRenderer.sprite = spriteStates[2];
        }

        //null check
        if (spriteStates == null || spriteStates.Length == 0)
        {
            Debug.Log($"YOU don't have any sprites on {gameObject.name}");
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        percentHp = health / maxHealth;

        int spriteIndex = (int)(spriteStates.Length * percentHp - 0.1f);

        spriteRenderer.sprite = spriteStates[spriteIndex];

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        GameObject.Find("GameController").GetComponent<dead>().deado = true;

        Destroy(gameObject);
    }
}
