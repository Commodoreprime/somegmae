using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viewmodelCamera_controller : MonoBehaviour {

    private Animator animator;

    public Camera mainCamera;
    private Vector3 offset;

	void Start ()
    {
        animator = GetComponent<Animator>();
        offset = transform.position - mainCamera.transform.position;
	}

	void Update ()
    {
        transform.position = mainCamera.transform.position + offset;
        transform.rotation = mainCamera.transform.rotation;

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("ToMoveForward");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("ToMoveLeft");
        }
        /*
        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("ToMoveBackward");
        }*/

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("ToMoveRight");
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetTrigger("ToStatic");
        }
    }
}
