
using UnityEngine;

public class Target : MonoBehaviour {
public float health = 10f;
//public GameObject distructableditem;
public float impactForce = 30f;
public float delay = 2f;
public float marks = 10f;
public gun gunScript;


	// Use this for initialization
	private void Start() {
		gunScript = GetComponent<gun>();
		
		
	}
	
	private void Update() {
		
	}
	public void TakeDamage(){
		//health -= amount;
		
		
		Points.coinCollect(marks);
		ShowPoints();
		// if(health <= 0){
		// 	Die();
		// }
	}
	void Die(){
		// Destroy(gameObject);
		// ShowPoints();
		//Instantiate(distructableditem, transform.position, transform.rotation);
	
		//Destroy(distructableditem,5f);
	}

	void ShowPoints(){
		
		float x =	Points.display();
		Debug.Log(x);
		
	}

	public void checkshoot(){
		//Destroy(gameObject,2f);
		//Destroy(distructableditem,2f);
	}


}
