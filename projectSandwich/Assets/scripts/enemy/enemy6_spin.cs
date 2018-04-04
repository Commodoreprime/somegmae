using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy6_spin : MonoBehaviour {
	GameObject topTriangle;
	GameObject bottomTriangle;

	void Update(){
		Quaternion top_prevRotation = topTriangle.transform.rotation;
		Quaternion bottom_prevRotation = bottomTriangle.transform.rotation;

		Quaternion top_nextRotation = new Quaternion (0.0f, 0.0f, Random.Range (0.0f, 180.0f));
		Quaternion bottom_nextRotation = new Quaternion (0.0f, 0.0f, Random.Range (0.0f, 180.0f));
	}
}
