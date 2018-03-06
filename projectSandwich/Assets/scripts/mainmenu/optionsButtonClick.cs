using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionsButtonClick : MonoBehaviour {

	public Button OptionsMenu;
	public Button button;

	public Animator Anim;

	// Use this for initialization
	void Start () {
		Button btn0 = OptionsMenu.GetComponent<Button> ();
		btn0.onClick.AddListener (OptionsMainMenuButton);

		Button btn1 = button.GetComponent<Button> ();
		btn1.onClick.AddListener (GenericButtonEvent);
	}

	// Everything below is custom listeners for the butons in the options menu (including the options button itself on the main screen)

	void OptionsMainMenuButton(){
		
		globalVariables.Instance.OptionsMenuEnable = true;
	}

	void GenericButtonEvent(){
		
	}
}
