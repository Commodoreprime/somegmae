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

	public bool OptionsMenuEnable = false;
	public bool GameOn = false;

	// Use this for initialization
	void Start () {
		
	}
}
