using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateX_movement : MonoBehaviour {

    public GameObject mainCamera;

    public float XrotationAmmount;

    private Vector3 rotation;

    private void Start()
    {
        rotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
    }

    // Update is called once per frame
    void LateUpdate ()
    {
        transform.position = mainCamera.transform.position;
    }

    private void Update()
    {
        if (Input.GetButton("Fire3") && (Input.GetAxis("Mouse X") > 0f))
        {
            transform.rotation *= Quaternion.Euler(0, rotation.y * Time.deltaTime, 0);
            rotation.y += XrotationAmmount;
        }
        else if (Input.GetButton("Fire3") && (Input.GetAxis("Mouse X") < 0f))
        {
            transform.rotation *= Quaternion.Euler(0, -rotation.y * Time.deltaTime, 0);
            rotation.y += XrotationAmmount;
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
