using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour {

    public Transform firepoint;
    public GameObject cannonballPrefab;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
	}

    void Shoot()
    {
        Instantiate(cannonballPrefab, firepoint.position, firepoint.rotation);
    }




}
