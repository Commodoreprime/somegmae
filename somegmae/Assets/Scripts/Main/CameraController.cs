using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Animator WeaponHolster;
    public Animator cardboard_sword;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            cardboard_sword.SetTrigger("ToSwingHold");
        }

        if (Input.GetButtonUp("Fire1"))
        {
            cardboard_sword.SetTrigger("ToSwing");
            cardboard_sword.SetTrigger("ToStatic");
        }

        if (Input.GetButtonDown("Fire2"))
        {
            cardboard_sword.SetTrigger("ToBlockStart");
            cardboard_sword.SetTrigger("ToBlockStatic");
        }

        if (Input.GetButtonUp("Fire2"))
        {
            cardboard_sword.SetTrigger("ToBlockEnd");
            cardboard_sword.SetTrigger("ToStatic");
        }
    }
}


