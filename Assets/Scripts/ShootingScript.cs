using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{

    public Transform firepoint;
    public GameObject cannonballPrefab;
    public AudioClip shootClip;

    public int numberOfBullets = 1;
    public int recoil = 100;
    [Range(0.1f, 3f)]
    public float reloadTime = 2;
    private float counter = 0f;

    public string fireButton;
    private string fireKey;

    private void Awake()
    {
        if (fireButton == "P1Fire")
            fireKey = "Fire1";
        else
            fireKey = "Fire2";
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime;

        if (Input.GetAxisRaw(fireButton) == 1 || Input.GetButtonDown(fireKey))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (counter > reloadTime)
        {
            if (shootClip != null)
            {
                gameObject.AddComponent<AudioSource>().Play(0);
            }

            GetComponent<Rigidbody2D>().AddForce(-transform.up * recoil);
            counter = 0;
            SpawnBullet(numberOfBullets);
        }
    }

    protected virtual void SpawnBullet(int bullets)
    {
        for (int i = 0; i < bullets; i++)
        {
            Instantiate(cannonballPrefab, firepoint.position, firepoint.rotation);
        }
    }
}