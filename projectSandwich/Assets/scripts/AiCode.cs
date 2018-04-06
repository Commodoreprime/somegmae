using UnityEngine;
using System.Collections;

public class AiCode : MonoBehaviour {

	private Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransform;

	// Use this for initialization
	void Awake() {
		myTransform = transform;
	}

	void Start () {
		target = GameObject.FindGameObjectWithTag("Player").transform;
	}

	// Update is called once per frame
	void Update () {
		if (globalVariables.Instance.GameOn == true) {
			Vector3 dir = target.position - myTransform.position;
			dir.z = 0.0f; // Only needed if objects don't share 'z' value
			if (dir != Vector3.zero) {
				myTransform.rotation = Quaternion.Slerp (myTransform.rotation, 
					Quaternion.FromToRotation(Vector3.right, dir), rotationSpeed * Time.deltaTime);
			}

			//Move Towards Target
			myTransform.position += (target.position - myTransform.position).normalized * moveSpeed * Time.deltaTime;
		}
	}

	private void OnTriggerEnter(Collider col)
	{
		if(col.CompareTag("Bullet")){
			//Both destroys the collided with gameobject and itself
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
	}
}