using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {

public float damage = 10f;
public float range = 100f;
public ParticleSystem muzzleflash;
public GameObject impactsmoke;
public Camera fpsCam;
public float impactForce = 30f;

	// Update is called once per frame
	void Update () {
	if(Input.GetButtonDown("Fire1")){
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
			target.TakeDamage(damage);
		}

		if(hit.rigidbody != null){
				hit.rigidbody.AddForce(hit.normal * impactForce);
		}
		GameObject impactGO = Instantiate(impactsmoke, hit.point, Quaternion.LookRotation(hit.normal));
		Destroy(impactGO , 1f);
	}	
	}
}
