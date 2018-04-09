using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class replay_button : MonoBehaviour {

	private AudioSource Audio;
	private Button button;
	public AudioClip textThud;
	public float volume;

	private bool ComfirmThud;

	void Start()
	{
		Audio = gameObject.GetComponent<AudioSource>();
		button = gameObject.GetComponent<Button>();
		ComfirmThud = true;
		button.onClick.AddListener(buttonClick);
	}

	void Update()
	{
		if (ComfirmThud)
		{
			Audio.PlayOneShot(textThud, volume);
			ComfirmThud = false;
		}
	}

	void buttonClick()
	{
		SceneManager.LoadScene("Main");
	}
}
