using UnityEngine;
using System.Collections;

public class AiCode : MonoBehaviour {
	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;

	private Transform myTransform;

	// Use this for initialization
	void Awake() {
		myTransform = transform;
	}

	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag("Player");

		target = go.transform;
	}

	// Update is called once per frame
	void Update () {    
		Vector3 dir = target.position - myTransform.position;
		dir.z = 0.0f; // Only needed if objects don't share 'z' value
		if (dir != Vector3.zero) {
			myTransform.rotation = Quaternion.Slerp (myTransform.rotation, 
				Quaternion.FromToRotation(Vector3.right, dir), rotationSpeed * Time.deltaTime);
		}

		//Move Towards Target
		myTransform.position += (target.position - myTransform.position).normalized * moveSpeed * Time.deltaTime;

	}

	void OnTriggerEnter(Collision col){
		if (col.gameObject.CompareTag("Bullet")) {
			Destroy (gameObject);
		}
	}
}