using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //OLD//private Vector3 PositionOffset;
    //OLD//private float YRotationOffset;
    //OLD//public GameObject PlayerController;

    void Start()
    {
        //OLD//PositionOffset = transform.position - PlayerController.transform.position;

        // If this comment is seen, it's working
    }

    void Update ()
    {
        /* OLD
        Vector3 eulerRotation = new Vector3(transform.eulerAngles.x, PlayerController.transform.eulerAngles.y, transform.eulerAngles.z);

        transform.position = PlayerController.transform.position + PositionOffset;
        transform.rotation = Quaternion.Euler(eulerRotation);
        */


    }
}
