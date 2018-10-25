using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test : MonoBehaviour
{
    public Health analLeaking; private GameObject bög; SpriteRenderer sp; public Sprite[] newSprite; private int hfghf; private void Start() { sp = GetComponent<SpriteRenderer>();
        bög = GameObject.Find("Diarrhoea"); 
        analLeaking = bög.GetComponent<Health>(); }
    private void Update() { if (Input.GetKeyDown(KeyCode.Space)) { PrematureE(); } }
    private void PrematureE() { if (newSprite.Length > hfghf) { sp.sprite = newSprite[hfghf]; hfghf++; } else print("AH!"); }
}