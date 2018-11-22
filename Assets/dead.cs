using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    public bool deado = false;

    private void Update()
    {
        if (deado = true && Input.anyKey)
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
