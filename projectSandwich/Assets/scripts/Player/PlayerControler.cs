using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
	private CharacterController controller;
	public float speed = 6.0f;
    public KeyCode runKey = KeyCode.LeftShift;
    public float speedMultiplier = 2f;

	public float jumpSpeed = 8.0F;
	private Vector3 moveDirection = Vector3.zero;
	public float gravity = 20.0f;
	public string powerup = "";

	void Awake()
	{
		controller = GetComponent<CharacterController>();
	}

    void Update()
	{

        if(globalVariables.Instance.InSubMenu == false)
        {
            //Running mechanic (at the time of creation I don't know if its a good idea but whatever)
            if (Input.GetKeyDown(runKey))
            {
                speed = speed * speedMultiplier;
            }
            else if (Input.GetKeyUp(runKey))
            {
                speed = speed / speedMultiplier;
            }

            if (controller.isGrounded)
            {
                moveDirection = transform.right * Input.GetAxis("Horizontal") * speed;
                if (Input.GetButton("Jump"))
                {
                    moveDirection.y += jumpSpeed;
                }
            }
            controller.Move(moveDirection * Time.deltaTime);
            moveDirection.y -= gravity * Time.deltaTime;
        }
	}

	//Detects a collision
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "powerup"){
			powerup = col.gameObject.name;
		}

	}
}
