using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenuControlelr : MonoBehaviour {

    public Animator Anim;

	// Use this for initialization
	void Start () {
        Anim.SetTrigger("menu_static");

        // Just locks the cursor to the center so its not so anoying, and apparently makes it invisible (on windows at least), Neat!
        Cursor.lockState = CursorLockMode.Confined;
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Space)) && Anim.GetBool("Game") == false)
        {
            Anim.SetTrigger("menu_exit");
            Cursor.lockState = CursorLockMode.Locked;
            Anim.SetBool("Game", true);
        }

        if (Input.GetKey(KeyCode.LeftAlt) && Anim.GetBool("Game") == true)
        {
            Cursor.lockState = CursorLockMode.None;
            Anim.SetTrigger("menu_enter");
            Anim.SetTrigger("menu_static");
            Anim.SetBool("Game", false);
        }
	}
}
