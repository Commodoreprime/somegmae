using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Child : MonoBehaviour {
	private Vector3 offset;
	private Vector3 offsetRot;

	public GameObject parent;
	public GameObject rail;

	public float rotationAmmount = 1;

	private Vector3 rail_prevRotation;
	private Vector3 rail_nextRotation;
	// Use this for initialization
	void Start () {
		offsetRot = Quaternion.Euler ();
		offset = parent.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.rotation = Quaternion.Lerp (transform.rotation, parent.transform.rotation + offsetRot, Time.deltaTime);
		transform.position = parent.transform.position + offset;
	}

	void Update(){
		if (Input.GetKey (KeyCode.Q)) {
			rail_prevRotation = rail.transform.position;
			rail.transform.rotation = Quaternion.Lerp (rail_prevRotation, rail_nextRotation, Time.deltaTime);
			rail_nextRotation = rail_nextRotation + rotationAmmount;
		}
	}
}
