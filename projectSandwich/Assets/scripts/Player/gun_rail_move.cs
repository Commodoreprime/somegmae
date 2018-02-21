using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun_rail_move : MonoBehaviour {

    //Float for changing gun rotation speed
    public float sensitivity = 5;

    // Float to store the X axis of mouse movement
	private float mouseX;

	void Start () {
        // Just locks the cursor to the center so its not so anoying, and apparently makes it invisible (on windows at least), Neat!
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	void Update () {
        // Gets mouse input on the X axis and inverts it (makes it negative)
		mouseX = -(Input.GetAxis ("Mouse X"));

        // Applies X axis times sensitivity float to rail's rotation
        transform.Rotate(0, 0, mouseX * sensitivity, Space.World);
	}
}
