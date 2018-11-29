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
        if (GameObject.Find("Shipmanager").GetComponent<Shipmanager>().isBigRed == true)
        {
            Bigred.SetActive(true);
        }
        else
        {
            SmallRed.SetActive(true);
        }

        if (GameObject.Find("Shipmanager").GetComponent<Shipmanager>().isBigBlue == true)
        {
            Bigblue.SetActive(true);
        }
        else
        {
            SmallBlue.SetActive(true);
        }
    }
}