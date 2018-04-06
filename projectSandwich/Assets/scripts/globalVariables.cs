using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Use this: 'globalVariables.Instance.' to call variables from this script in other scripts

public class globalVariables : MonoBehaviour {
	//This script houses variables for various other scripts

	//The public static delcaire and the Awake function allows variables from this script to be called in other scripts
	public static globalVariables Instance;

	void Awake(){
		Instance = this;
	}

	// Variables stuff onfourth

	public bool OptionsMenuEnabled = false;
	public bool GameOn = false;
    public bool InSubMenu = false;
	public bool playerDead = false;
	//public bool optionsApplySettings = false;
}
