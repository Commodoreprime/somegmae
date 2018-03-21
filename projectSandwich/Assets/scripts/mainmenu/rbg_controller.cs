﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rbg_controller : MonoBehaviour {

	private float rChannel;
	private float gChannel;
	private float bChannel;

	public Camera cam;
	public Slider RControl;
	public Slider GControl;
	public Slider BControl;
	public Image viewer;

	public InputField RInputField;

	// Use this for initialization
	void Start () {
		cam = cam.GetComponent<Camera> ();
		viewer = viewer.GetComponent<Image> ();
		RControl = RControl.GetComponent<Slider> ();
		GControl = GControl.GetComponent<Slider> ();
		BControl = BControl.GetComponent<Slider> ();
		RInputField = RInputField.GetComponent<InputField> ();
	}
	
	// Update is called once per frame
	void Update () {
		Color newColor = new Color (RControl.value, GControl.value, BControl.value, 1);

		//RInputField = RControl.value * 255;

		viewer.color = newColor;
	}

	void OnMouseDown(){
		Color newColor = new Color (RControl.value, GControl.value, BControl.value, 1);

		if (globalVariables.Instance.optionsApplySettings == true) {
			cam.backgroundColor = newColor;
			globalVariables.Instance.optionsApplySettings = false;
		}
	}
}
