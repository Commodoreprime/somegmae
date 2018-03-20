using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rbg_controller : MonoBehaviour {

	public int rChannel;
	public int gChannel;
	public int bChannel;
	public Color color;

	public Camera cam;
	public Slider RControl;
	public Slider GControl;
	public Slider BControl;
	public GameObject viewer;

	// Use this for initialization
	void Start () {
		cam = cam.GetComponent<Camera> ();
		viewer = viewer.GetComponent<Image> ();
		RControl = RControl.GetComponent<Slider> ();
		GControl = GControl.GetComponent<Slider> ();
		BControl = BControl.GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void Update () {
		color = (rChannel, gChannel, bChannel, 1);
	}
}
