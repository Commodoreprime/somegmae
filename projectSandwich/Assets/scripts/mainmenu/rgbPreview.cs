using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rgbPreview : MonoBehaviour {

    public Slider RControl;
	public InputField R_textField;

    public Slider GControl;
	public InputField G_textField;

	public Slider BControl;
	public InputField B_textField;

    private Image viewer;

    void Start()
    {
        viewer = gameObject.GetComponent<Image>();
        RControl = RControl.GetComponent<Slider>();
        GControl = GControl.GetComponent<Slider>();
        BControl = BControl.GetComponent<Slider>();

		R_textField = R_textField.GetComponent<Text> ();
		G_textField = G_textField.GetComponent<Text> ();
		B_textField = B_textField.GetComponent<Text> ();
    }

    void Update()
    {
        Color newColor = new Color(RControl.value, GControl.value, BControl.value, 1);
        viewer.color = newColor;

		Text RnewText = new Text (RControl.value * 255);
		R_textField.text = RnewText;
    }
}
