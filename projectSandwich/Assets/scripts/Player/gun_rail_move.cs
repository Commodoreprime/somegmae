using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_rail_move : MonoBehaviour {

    //Float for changing gun rotation speed
    public float sensitivity = 5;

    // Float to store the X axis of mouse movement
	private float mouseX;
	
	void Update () {

		if (globalVariables.Instance.GameOn) {
			// Gets mouse input on the X axis and inverts it (makes it negative)
			mouseX = -(Input.GetAxis ("Mouse X"));

			// Applies X axis times sensitivity float to rail's rotation
			transform.Rotate (0, 0, mouseX * sensitivity, Space.World);
		}
	}
}
