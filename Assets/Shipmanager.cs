using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipmanager : MonoBehaviour
{
    public bool isBigRed = true;
    public bool isBigBlue = true;

    private static bool created = false;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
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

}
