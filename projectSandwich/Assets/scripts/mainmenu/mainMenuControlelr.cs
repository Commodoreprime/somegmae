using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class mainMenuControlelr : MonoBehaviour {

	// Animation controller attached to the GameObject named "scrolltext"
    public Animator Anim;

	[Header("Options Menu")]
    //GameObject 'OptionsMenu' which contains all objects for the options menu should have: optionsmenu assigned to it
	public GameObject OptionsMenu;

	//This is where the player death sequence variables are stored: includes GameObject slots for the parent GameObject, along with the three text fields
	[Header("Die text")]
	public GameObject playerDeathGroupObject;
	public GameObject youText;
	public GameObject haveText;
	public GameObject diedText;
	// Boolean to lock the key to make it so the player cannot enter the menu while the death screen text displays
	private bool deathKeyLock = false;

	// Use this for initialization
	void Start () {
		//Sets the menu animation to static on startup
        Anim.SetTrigger("menu_static");
		//Sets all player death screen components to false, just in case mostly
		playerDeathGroupObject.SetActive(false);
		youText.SetActive(false);
		haveText.SetActive(false);
		diedText.SetActive(false);
	}

	//Displays "YOU HAVE DIED" on the screen when the playerDead boolean is true
	IEnumerator PlayerDieScreen()
	{
		if (globalVariables.Instance.playerDead)
		{
			//Explained at bool creation point
			deathKeyLock = true;

			// This sequence is the meat of the coroutine, it debug Logs for debugging (which is quite useful!) and enables each of the text objects to True in an order
			Debug.Log("Starting sequence...");
			playerDeathGroupObject.SetActive(true);
			Debug.Log("Enable parent GroupObject: Success!");

			yield return new WaitForSeconds(1f);
			globalVariables.Instance.MainController_Audio.Play();
			youText.SetActive(true);
			Debug.Log("Enable 'you' text: Success!");

			yield return new WaitForSeconds(1.1f);
			globalVariables.Instance.MainController_Audio.Play();
			haveText.SetActive(true);
			Debug.Log("Enable 'have' text: Success!");

			yield return new WaitForSeconds(1.3f);
			globalVariables.Instance.MainController_Audio.Play();
			diedText.SetActive(true);
			Debug.Log("Enable 'died' text: Success!");
			Debug.Log("Sequence finished! Have a great day!");
		}
	}

	void Update () {
		//Starts the coroutine PlayerDieScreen. You might be saying, why not put it in the start function and just add a While(true) condition to it? Well I tried it, it instantly locked Unity up. This seems to work anyway
		StartCoroutine(PlayerDieScreen());

		//Locks the cursor while the GameOn Boolean is true, it will release the cursor if false
		if (globalVariables.Instance.GameOn)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

		//Enables or disables the OptionsMenu GameObject (this incudes all children) based on if OptionsMenuEnabled is true or false
        if (globalVariables.Instance.OptionsMenuEnabled)
        {
            OptionsMenu.SetActive(true);
        }
        else if (!globalVariables.Instance.OptionsMenuEnabled)
        {
            OptionsMenu.SetActive(false);
        }

		//This might look complicated but its not. 
	//It will only activate if the user presses any of the movement keys AND the GameOn Boolean is true AND the InSubMenu Boolean is False
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.Space)) && !globalVariables.Instance.GameOn && !globalVariables.Instance.InSubMenu)
        {
			globalVariables.Instance.GameOn = true;
            Anim.SetTrigger("menu_exit");
            Cursor.lockState = CursorLockMode.Locked;
        }

		//Much like the statement just before, it looks complicated at a glance but its not
	//It will activate if the user presses the assigned pause key (in this case, Left Alt) AND the GameOn Boolean is true AND the InSubMenu Boolean is False AND the deathKeyLock is False
		if (Input.GetKey(KeyCode.LeftAlt) && globalVariables.Instance.GameOn && !globalVariables.Instance.InSubMenu && !deathKeyLock)
        {
			globalVariables.Instance.GameOn = false;
            Cursor.lockState = CursorLockMode.None;
            Anim.SetTrigger("menu_enter");
            Anim.SetTrigger("menu_static");
        }
	}
}
