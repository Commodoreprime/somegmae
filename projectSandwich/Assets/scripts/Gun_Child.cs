using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Child : MonoBehaviour {
	private Vector3 offset;
	private Quaternion offsetRot;

	public GameObject parent;
	public GameObject rail;

<<<<<<< HEAD
	public float rotationAmmount = 1;

=======
>>>>>>> parent of e696a74... Improvment on multiple things
	private Quaternion rail_prevRotation;
	private Quaternion rail_nextRotation;

	// Use this for initialization
	void Start () {
<<<<<<< HEAD
		offsetRot = transform.rotation;
		offset = parent.transform.position - transform.position;
	}

	void LateUpdate () {
		transform.rotation = Quaternion.Lerp (transform.rotation, parent.transform.rotation * offsetRot, Time.deltaTime);
		transform.position = parent.transform.position + offset;
	}

	void Update(){
		if (Input.GetKey (KeyCode.Q)) {
			rail_prevRotation = rail.transform.rotation;
			rail.transform.rotation = Quaternion.Lerp (rail_prevRotation, rail_nextRotation, Time.deltaTime);
			rail_nextRotation.x = rail_nextRotation.x + rotationAmmount;
			rail_nextRotation.y = rail_nextRotation.y + rotationAmmount;
		}
	}
=======
		//offsetRot = Quaternion.Euler(rail.transform.rotation);
		offset = parent.transform.position - transform.position;
	}

	void FixedUpdate () {
		transform.rotation = rail.transform.rotation;
		transform.position = parent.transform.position + offset;
	}
>>>>>>> parent of e696a74... Improvment on multiple things
}
