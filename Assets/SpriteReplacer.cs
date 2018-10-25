using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject Boat;
    public Health healt;
    SpriteRenderer SR;
    public Sprite[] newSprite;
    private int counter;
    

    private void Start()
    {
        Boat = GameObject.Find("sak");
        healt = Boat.GetComponent<Health>();


        SR = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown("fire1"))
        {
            ReplaceSprite();
        }
    }

    private void ReplaceSprite()
    {
        SR.sprite = newSprite[counter];
        counter++;
    }
}