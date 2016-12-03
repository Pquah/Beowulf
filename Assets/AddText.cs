
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class AddText : MonoBehaviour
{
	public Button Button_HO;
	public InputField InputField;
	public Text TextInput;


	// Use this for initialization


	void Start ()
	{

	}

	public void TaskOnClick ()
	{
		Debug.Log ("You have clicked the button!");
		InputField.text += TextInput.text;
		//SceneManager.LoadScene (2, LoadSceneMode.Additive);



	}

	
	// Update is called once per frame
	void Update ()
	{


	
	}
}
