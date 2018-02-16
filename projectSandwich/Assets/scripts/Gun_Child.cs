using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Child : MonoBehaviour {
	private Vector3 offset;
	private Quaternion offsetRot;

	public GameObject parent;
	public GameObject rail;

	private Quaternion rail_prevRotation;
	private Quaternion rail_nextRotation;

	// Use this for initialization
	void Start () {
		//offsetRot = Quaternion.Euler(rail.transform.rotation);
		offset = parent.transform.position - transform.position;
	}

	void FixedUpdate () {
		transform.rotation = rail.transform.rotation;
		transform.position = parent.transform.position + offset;
	}
}
