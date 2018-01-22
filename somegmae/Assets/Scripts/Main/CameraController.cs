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
            cardboard_sword.SetTrigger("swing");
            cardboard_sword.SetTrigger("ToStatic");
        }
    }
}


