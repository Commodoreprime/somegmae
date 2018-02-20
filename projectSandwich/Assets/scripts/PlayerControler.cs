﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
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
<<<<<<< HEAD:projectSandwich/Assets/scripts/PlayerControler.cs
=======

>>>>>>> parent of e696a74... Improvment on multiple things:projectSandwich/Assets/scripts/PlayerControler.cs
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
