using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wicket : MonoBehaviour {
	public WicketCollider wiC;
	private Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(wiC.wicketed == true){
			anim.SetBool("Wicketed", true);
		}else{
			anim.SetBool("Wicketed", false);
		}
	}
}
