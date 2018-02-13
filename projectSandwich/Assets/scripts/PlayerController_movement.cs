using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	private CharacterController controller;
	public float speed = 6.0f;
	public float jumpSpeed = 8.0F;
	private Vector3 moveDirection = Vector3.zero;
	public float gravity = 20.0f;

	void Awake()
	{
		controller = GetComponent<CharacterController>();
	}

	void Update()
	{
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
