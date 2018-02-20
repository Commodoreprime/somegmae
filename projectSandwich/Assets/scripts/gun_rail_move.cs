using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_rail_move : MonoBehaviour {

	public GameObject gun;

	private float mouseX;
	private float mouseY;

	private Quaternion nextrot;
	private Quaternion prevrot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		mouseX = -(Input.GetAxis ("Mouse X"));
		/*
		mouseY = Input.GetAxis ("Mouse Y");

		nextrot = new Vector3 (mouseX, mouseY, 0);

		transform.Rotate(mouseX, mouseY, 0);
		*/
		transform.Rotate (0, 0, mouseX * 5, Space.World);
	}
}
