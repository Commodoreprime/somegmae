using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera_movement : MonoBehaviour {

    public GameObject XRotator;
	public Text rotText;
    private GameObject globalVariable;

    public float speed;
    public float ScrollSpeed;
    public float multiplier;
    public float YrotationAmmount;

	public int numberOfDegrees;

    private Rigidbody rb;
    private Vector3 rotation;
    private float YRotation;

    private float YInput;
    private float XInput;
    public float smoothness;
    public float friction;

	public float rotation_X;
	public float rotation_Y;
	public float rotation_Z;

    private Quaternion PrevRotation;
    private Quaternion NextRotation;

	// Use this for initialization
	void Start ()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        transform.rotation = transform.rotation;
		numberOfDegrees = 0;
    }

    private void Update()
    {
		rotation_X = transform.rotation.x;
		rotation_Y = transform.rotation.y;
		rotation_Z = transform.rotation.z;
		rotText.text = "Rot: X: " + rotation_X + " Y: " + rotation_Y + " Z: " + rotation_Z;

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
			numberOfDegrees += 1;
		} 
		else if (Input.GetAxis ("Mouse ScrollWheel") < 0f) {
			numberOfDegrees += -1;
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

		if (numberOfDegrees == 0) {
			transform.rotation.x = 35.0f;

		} else if (numberOfDegrees == 1) {


		} else if (numberOfDegrees == 2) {


		} else if (numberOfDegrees == 3) {


		} else if (numberOfDegrees == 4) {


		}
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
