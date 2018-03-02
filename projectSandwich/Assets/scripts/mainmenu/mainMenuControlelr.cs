using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuControlelr : MonoBehaviour {

	// Animation controller attached to the GameObject named "scrolltext"
    public Animator Anim;

	// Use this for initialization
	void Start () {
        Anim.SetTrigger("menu_static");
    }
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Space)) && globalVariables.Instance.GameOn == false)
        {
			globalVariables.Instance.GameOn = true;
            Anim.SetTrigger("menu_exit");
            Cursor.lockState = CursorLockMode.Locked;
        }

		if (Input.GetKey(KeyCode.LeftAlt) && globalVariables.Instance.GameOn == true)
        {
			globalVariables.Instance.GameOn = false;
            Cursor.lockState = CursorLockMode.None;
            Anim.SetTrigger("menu_enter");
            Anim.SetTrigger("menu_static");
        }

		if (globalVariables.Instance.GameOn == true) {
			Cursor.lockState = CursorLockMode.Locked;
		}
	}
}
