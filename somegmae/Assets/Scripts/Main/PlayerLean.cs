using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLean : MonoBehaviour {

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			animator.SetTrigger ("LeanLeft");
		}

		if(Input.GetKeyDown(KeyCode.R)){
			animator.SetTrigger ("LeanRight");
		}

		if (Input.GetKeyUp (KeyCode.Q) || Input.GetKeyUp (KeyCode.R)) {
			animator.SetTrigger ("ToStatic");
		}
	}
}
