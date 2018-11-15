using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodStartScriptBoot : MonoBehaviour
{
    private bool bigRed;
    private bool bigBlue;

    public GameObject Bigblue;
    public GameObject Bigred;

    public GameObject SmallBlue;
    public GameObject SmallRed;


    void Start()
    {
        bigRed = GameObject.Find("Shipmanager").GetComponent<Shipmanager>().isBigRed;
        bigBlue = GameObject.Find("Shipmanager").GetComponent<Shipmanager>().isBigBlue;

        if (bigRed == true)
        {
            Bigred.SetActive(true);
        }
        else
        {
            SmallRed.SetActive(true);
        }

        if (bigBlue == true)
        {
            Bigblue.SetActive(true);
        }
        else
        {
            SmallBlue.SetActive(true);
        }
    }
}