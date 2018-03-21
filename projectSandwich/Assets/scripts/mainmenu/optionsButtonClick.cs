using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionsButtonClick : MonoBehaviour {

	public Button ApplyButton;
	public Button OptionsMenu;
	public Button ExitButton;

	// Use this for initialization
	void Start () {
		Button btn0 = OptionsMenu.GetComponent<Button> ();
		btn0.onClick.AddListener (OptionsMainMenuButton);

		Button btn1 = ExitButton.GetComponent<Button> ();
		btn1.onClick.AddListener (ExitButtonEvent);

		Button btn2 = ApplyButton.GetComponent<Button> ();
		btn2.onClick.AddListener (ApplyButtonEvent);
	}

	// Everything below are custom events for the buttons in the options menu (including the options button itself on the main screen)

	void OptionsMainMenuButton(){
		
		globalVariables.Instance.OptionsMenuEnabled = true;
        globalVariables.Instance.InSubMenu = true;
    }

	void ExitButtonEvent(){
        globalVariables.Instance.OptionsMenuEnabled = false;
        globalVariables.Instance.InSubMenu = false;
    }

	void ApplyButtonEvent(){
		globalVariables.Instance.optionsApplySettings = true;
	}
}
