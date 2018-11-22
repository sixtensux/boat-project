using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAnim : MonoBehaviour
{
    public AudioClip boom;

    private void Start()
    {
        /*if (boom != null)
        {
            gameObject.AddComponent<AudioSource>().clip = boom;
            gameObject.GetComponent<AudioSource>().Play(0);
        }*/
        Destroy(gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }
}
