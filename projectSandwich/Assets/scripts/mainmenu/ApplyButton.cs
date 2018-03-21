using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyButton : MonoBehaviour {

	private float rChannel;
	private float gChannel;
	private float bChannel;

	public Camera cam;
	public Slider RControl;
	public Slider GControl;
	public Slider BControl;

	// Use this for initialization
	void Start () 
	{
		cam = cam.GetComponent<Camera> ();
		RControl = RControl.GetComponent<Slider> ();
		GControl = GControl.GetComponent<Slider> ();
		BControl = BControl.GetComponent<Slider> ();
	}

	void OnMouseDown()
	{
		Color newColor = new Color (RControl.value, GControl.value, BControl.value, 1);

		if (globalVariables.Instance.optionsApplySettings == true) {
			cam.backgroundColor = newColor;
			globalVariables.Instance.optionsApplySettings = false;
		}
	}
}
