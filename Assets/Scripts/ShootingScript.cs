using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{

	public Transform firepoint;
	public GameObject cannonballPrefab;
	public AudioClip shootClip;

	[Range(0.1f,3f)]
	public float reloadTime = 2;
	private float counter = 0f;

	public string fireButton;

	// Update is called once per frame
	void Update()
	{
		counter += Time.deltaTime;

		if (Input.GetButton(fireButton))
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

			GetComponent<Rigidbody2D>().AddForce(-transform.up * 100);
			Instantiate(cannonballPrefab, firepoint.position, firepoint.rotation);
			counter = 0;
		}
	}

}
