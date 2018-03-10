using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuControlelr : MonoBehaviour {

	// Animation controller attached to the GameObject named "scrolltext"
    public Animator Anim;

    //GameObject 'OptionsMenu' which contains all objects for the options menu should have: optionsmenu assigned to it
	public GameObject OptionsMenu;

	// Use this for initialization
	void Start () {
        Anim.SetTrigger("menu_static");
    }
	
	// Update is called once per frame
	void Update () {

        if (globalVariables.Instance.GameOn == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (globalVariables.Instance.OptionsMenuEnabled == true)
        {
            OptionsMenu.SetActive(true);
        }
        else if (globalVariables.Instance.OptionsMenuEnabled == false)
        {
            OptionsMenu.SetActive(false);
        }

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Space)) && globalVariables.Instance.GameOn == false && globalVariables.Instance.InSubMenu == false)
        {
			globalVariables.Instance.GameOn = true;
            Anim.SetTrigger("menu_exit");
            Cursor.lockState = CursorLockMode.Locked;
        }

		if (Input.GetKey(KeyCode.LeftAlt) && globalVariables.Instance.GameOn == true && globalVariables.Instance.InSubMenu == false)
        {
			globalVariables.Instance.GameOn = false;
            Cursor.lockState = CursorLockMode.None;
            Anim.SetTrigger("menu_enter");
            Anim.SetTrigger("menu_static");
        }
	}
}
