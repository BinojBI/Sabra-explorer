using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {

public float damage = 0f;
public float range = 100f;
public ParticleSystem muzzleflash;
public GameObject impactsmoke;
public Camera fpsCam;

public float impactForce = 30f;
public float fireRate = 15f;
public float nextTimeforFire=0f;


	// Update is called once per frame
	void Update () {
	if(Input.GetButtonDown("Fire1")&& Time.time >= nextTimeforFire)
	{
		nextTimeforFire = Time.time+ 1f /fireRate;
		Shoot();
	}
	
	
	}
	void Shoot(){
		muzzleflash.Play();
		RaycastHit hit;
	if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
	{
		Debug.Log(hit.transform.name);

		Target target = hit.transform.GetComponent<Target>();
		if (target != null )
		{
			target.TakeDamage();
		}

		if(hit.rigidbody != null){
				hit.rigidbody.AddForce(hit.normal * impactForce);
		}
		GameObject impactGO = Instantiate(impactsmoke, hit.point, Quaternion.LookRotation(hit.normal));
		Destroy(impactGO , 1f);
	}	
	}

	
    
}
