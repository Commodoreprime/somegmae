using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class optionsButtonClick : MonoBehaviour {

	public Button button;

	// Use this for initialization
	void Start () {
		Button btn = button.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick(){
		
		Debug.Log ("The 'Options' button has been clicked!");
	}
}
