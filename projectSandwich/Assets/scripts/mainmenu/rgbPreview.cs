using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rgbPreview : MonoBehaviour {

    public Slider RControl;
    public Slider GControl;
    public Slider BControl;
    private Image viewer;

    void Start()
    {
        viewer = gameObject.GetComponent<Image>();
        RControl = RControl.GetComponent<Slider>();
        GControl = GControl.GetComponent<Slider>();
        BControl = BControl.GetComponent<Slider>();
    }

    void Update()
    {
        Color newColor = new Color(RControl.value, GControl.value, BControl.value, 1);

        viewer.color = newColor;
    }
}
