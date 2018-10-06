
using UnityEngine;

public class Target : MonoBehaviour {
public float health = 10f;
public GameObject distructableditem;
public float impactForce = 30f;

	// Use this for initialization
	private void Update() {
		for(int x=0; x<16;x++){
			
			
		}
	}
	public void TakeDamage(float amount){
		health -= amount;
		if(health <= 0){
			Die();
		}
	}
	void Die(){
		Destroy(gameObject);
		ShowPoints();
		Instantiate(distructableditem, transform.position, transform.rotation);
	
		//Destroy(distructableditem,5f);
	}

	void ShowPoints(){
		
		int marks = Points.getMarks();
		Debug.Log(marks);
	}
}
