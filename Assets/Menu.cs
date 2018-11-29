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

    private Vector3 smallScale;
    private Vector3 bigScale;
    private Vector3 scale = new Vector3(0.5f, 0.5f, 0.5f);

    public void Start()
    {
        smallScale = smallred.transform.localScale;
        bigScale = bigred.transform.localScale;
    }

    public void Boatswitchblue(bool isBig)
    {
        if (isBig == true)
        {
            SetSelected(bigblue, true, true);
            SetSelected(smallblue, false, false);
        }
        else
        {
            SetSelected(bigblue, true, false);
            SetSelected(smallblue, false, true);
        }

    }

    public void Boatswitchred(bool isBig)
    {
        if (isBig == true)
        {
            SetSelected(bigred, true, true);
            SetSelected(smallred, false, false);
        }
        else
        {
            SetSelected(bigred, true, false);
            SetSelected(smallred, false, true);
        }
    }

    public void Loadlevel()
    {
        SceneManager.LoadScene("Level_1");
        print("Clicked");
    }

    private void SetSelected(GameObject ship, bool big, bool bigger)
    {
        if (bigger && big && ship.transform.localScale.x < bigScale.x + scale.x)
            ship.transform.localScale += scale;
        else if (big)
            ship.transform.localScale = bigScale;

        if (bigger && !big && ship.transform.localScale.x < smallScale.x + scale.x)
            ship.transform.localScale += scale;
        else if (!big)
            ship.transform.localScale = smallScale;
    }
}
