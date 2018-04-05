using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy6_spin : MonoBehaviour {
	public float speed;
	public GameObject topTriangle;
	public GameObject bottomTriangle;

	void FixedUpdate(){

		Quaternion top_nextRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, Random.Range (0.0f, 360.0f)));
		Quaternion bottom_nextRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, Random.Range (0.0f, 360.0f)));

		topTriangle.transform.rotation = Quaternion.Lerp (topTriangle.transform.rotation, top_nextRotation, Time.fixedDeltaTime * speed);
		bottomTriangle.transform.rotation = Quaternion.Lerp (bottomTriangle.transform.rotation, bottom_nextRotation, Time.fixedDeltaTime * speed);
	}
}
