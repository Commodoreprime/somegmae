using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyButton : MonoBehaviour {

    [Header("Color picker settings")]
	public Camera cam;
	public Slider RControl;
	public Slider GControl;
	public Slider BControl;
    private float rChannel;
    private float gChannel;
    private float bChannel;


    void Start () 
	{
		cam = cam.GetComponent<Camera> ();
		RControl = RControl.GetComponent<Slider> ();
		GControl = GControl.GetComponent<Slider> ();
		BControl = BControl.GetComponent<Slider> ();
        Button apply = gameObject.GetComponent<Button>();
        apply.onClick.AddListener(ApplyEvent);
	}

	void ApplyEvent()
	{
        Debug.Log("Apply!");
		Color newColor = new Color (RControl.value, GControl.value, BControl.value, 1);
		cam.backgroundColor = newColor;
		Debug.Log ("Setting background color to R: "+ RControl.value * 255 +", G: "+ GControl.value * 255 +", B: "+ BControl.value * 255);

		//globalVariables.Instance.optionsApplySettings = false;
	}
}
