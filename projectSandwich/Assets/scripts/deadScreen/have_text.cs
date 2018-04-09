using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class have_text : MonoBehaviour {

	private AudioSource Audio;
	public AudioClip textThud;
	public float volume;

	private bool ComfirmThud;

	void Start () {
		Audio = gameObject.GetComponent<AudioSource> ();
		ComfirmThud = true;
	}

	void Update(){
		if (ComfirmThud) {
			Audio.PlayOneShot (textThud, volume);
			ComfirmThud = false;
		}

	}
}
