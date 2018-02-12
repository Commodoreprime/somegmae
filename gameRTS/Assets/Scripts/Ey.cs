using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Ey : MonoBehaviour
{
	public Button Button;
	public Text Text;

	void Start()
	{
		Button btn = Button.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		Button.GetComponentInChildren<Text>().cachedTextGenerator;

	}
}