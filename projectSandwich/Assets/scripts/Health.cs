using UnityEngine;

public class Health : MonoBehaviour 
{
	public int maxHealth;

	void Update(){
		
	}

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Bullet") {
			maxHealth -= 1;
		
		}
	}
}