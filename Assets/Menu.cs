using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public GameObject bigblue;
    public GameObject smallblue;

    public GameObject bigred;
    public GameObject smallred;


    // public bool isBig;

    private void Start()
    {
        bigblue = GameObject.Find("Bigblue");
        smallblue = GameObject.Find("Smallblue");
    }
    //private void OnMouseOver()
    public void Boatswitchblue(bool isBig)
    {
        if (isBig == true)
        {
            smallblue.SetActive(false);
            bigblue.SetActive(true);
        }
        else
        {
            bigblue.SetActive(false);
            smallblue.SetActive(true);
        }

    }

    public void Boatswitchred(bool isBig)
    {
        if (isBig == true)
        {
            smallred.SetActive(false);
            bigred.SetActive(true);
        }
        else
        {
            bigred.SetActive(false);
            smallred.SetActive(true);
        }

    }
    public void Loadlevel()
    {
        SceneManager.LoadScene("Level_1");
    }

}
