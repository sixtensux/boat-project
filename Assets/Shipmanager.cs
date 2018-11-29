using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipmanager : MonoBehaviour
{
    public bool isBigRed = true;
    public bool isBigBlue = true;

    private static bool created = false;

    public SpriteRenderer bigRedRend;
    public SpriteRenderer smallRedRend;
    public SpriteRenderer bigBlueRend;
    public SpriteRenderer smallBlueRend;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }

        ApplyTint();
    }

    public void Bigblue()
    {
        isBigBlue = true;
    }

    public void Bigred()
    {
        isBigRed = true;
    }

    public void Smallblue()
    {
        isBigBlue = false;
    }

    public void Smallred()
    {
        isBigRed = false;
    }

    public void ApplyTint()
    {
        if (isBigRed)
        {
            smallRedRend.color = Color.white;
            bigRedRend.color = Color.green;
        }
        else if (!isBigRed)
        {
            bigRedRend.color = Color.white;
            smallRedRend.color = Color.green;
        }

        if (isBigBlue)
        {
            smallBlueRend.color = Color.white;
            bigBlueRend.color = Color.green;
        }
        else if (!isBigBlue)
        {
            bigBlueRend.color = Color.white;
            smallBlueRend.color = Color.green;
        }
    }
}
