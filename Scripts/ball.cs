using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
	private Animator anim;
	public shotcollider shotC;
	public ballercollide ballc;
	
	// Use this for initialization
	void Start () {
		Debug.Log("ball animation works");
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if(ballc.ballered == true){
		//	anim.Play("ball1");
			
			anim.SetBool("baller", true);
		}else{
			
			anim.SetBool("baller", false);
			
		}

		if(shotC.shotDefence == true){
			anim.Play("aniamtion4defence");
			Debug.Log("4 runs");
		}else if(shotC.shotRight == true){
			anim.Play("animation3right");
			Debug.Log("4 runs");
		}else if(shotC.shotLeft == true){
			anim.Play("leftshot");
			Debug.Log("4 runs");
		}else if(shotC.lossTheBale == true){
			anim.Play("LossTheBall 0");
			Debug.Log("1 wicket");
		}
	
	
	}

	
}
