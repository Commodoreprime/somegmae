using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour {

    public GameObject XRotator;
    private GameObject globalVariable;

    public float speed;
    public float ScrollSpeed;
    public float multiplier;
    public float YrotationAmmount;

    private Rigidbody rb;
    private Vector3 rotation;
    private float YRotation;

    private float YInput;
    private float XInput;
    public float smoothness;
    public float friction;

    private Quaternion PrevRotation;
    private Quaternion NextRotation;

	// Use this for initialization
	void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        transform.rotation = transform.rotation;
    }

    private void Update()
    {
		/*
        if (Input.GetButton("Fire3"))
        {
            YInput += Input.GetAxis("Mouse Y") * speed * friction;
            XInput += Input.GetAxis("Mouse X") * speed * friction;
            PrevRotation = transform.rotation;
            NextRotation = Quaternion.Euler(-YInput, XInput, 0);

            transform.rotation = Quaternion.Lerp(PrevRotation, NextRotation, Time.deltaTime * smoothness);
        }
        */

		if (Input.GetAxis ("Mouse ScrollWheel") > 0f) {
			rb.AddForce(0.0f, 1.0f * ScrollSpeed, 0.0f);
			transform.rotation *= Quaternion.Euler(YInput, 0, 0);
			YInput += speed;
		} 
		else if (Input.GetAxis ("Mouse ScrollWheel") < 0f) {
			rb.AddForce(0.0f, -1.0f * ScrollSpeed, 0.0f);

		}
        
        /*
        if (Input.GetButton("Fire3") && (Input.GetAxis("Mouse Y") > 0f))
        {
            transform.rotation *= Quaternion.Euler(-rotation.x * Time.deltaTime, 0, 0);
            rotation.x += YrotationAmmount;
        }
        else if (Input.GetButton("Fire3") && (Input.GetAxis("Mouse Y") < 0f))
        {
            transform.rotation *= Quaternion.Euler(rotation.x * Time.deltaTime, 0, 0);
            rotation.x += YrotationAmmount;
        }
        else
        {
            transform.rotation *= Quaternion.Euler(0, 0, 0);
        }

        YRotation = XRotator.transform.rotation.y;
        //transform.rotation *= Quaternion.Euler(0, YRotation, 0);
        transform.localEulerAngles += new Vector3(0, YRotation, 0);
        */
    }

    // Update is called once per frame
    void FixedUpdate () {

        if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.AddForce(-1.0f * speed * multiplier, 0.0f, 0.0f);
            }

            rb.AddForce(-1.0f * speed, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.AddForce(1.0f * speed * multiplier, 0.0f, 0.0f);
            }

            rb.AddForce(1.0f * speed, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.AddForce(0.0f, 0.0f, -1.0f * speed * multiplier);
            }

            rb.AddForce(0.0f, 0.0f, -1.0f * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                rb.AddForce(0.0f, 0.0f, 1.0f * speed * multiplier);
            }

            rb.AddForce(0.0f, 0.0f, 1.0f * speed);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0.0f, 1.0f * ScrollSpeed, 0.0f);
        }
        else if (Input.GetKey(KeyCode.LeftControl))
        {
            rb.AddForce(0.0f, -1.0f * ScrollSpeed, 0.0f);
        }
    }
}
