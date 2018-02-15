using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Test : MonoBehaviour {


	// Use this for initialization
	void Start () {
		Transform tran = GetComponent<Transform> ();
		tran.Translate (Vector2.up * 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
