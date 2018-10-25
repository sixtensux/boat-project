using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

    public Transform firepoint;
    public GameObject cannonballPrefab;
    public float delayTime = 2f;
    private float counter = 0f;
     float reloadTime;

	// Update is called once per frame
	void Update ()
    {
        counter += Time.deltaTime;

        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        if (counter > delayTime)
        {
            Instantiate(cannonballPrefab, firepoint.position, firepoint.rotation);
            counter = 0;
        }
    }

}
