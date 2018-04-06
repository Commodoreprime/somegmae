using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class have_text : MonoBehaviour {
	[HideInInspector]
	public AudioSource Audio;
	public AudioClip textThud;

	private bool ComfirmThud;

	void Start () {
		Audio = gameObject.GetComponent<AudioSource> ();
		ComfirmThud = true;
	}

	void Update(){
		if (ComfirmThud) {
			Audio.PlayOneShot (textThud, 0.7f);
			ComfirmThud = false;
		}

	}
}
