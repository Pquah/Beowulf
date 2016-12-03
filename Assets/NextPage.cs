//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class NextPage : MonoBehaviour {
//	void Start () {
//		// Only specifying the sceneName or sceneBuildIndex will load the scene with the Single mode

//	}
//
//	void OnMouseUpAsButton() {
//		SceneManager.LoadScene (2, LoadSceneMode.Additive);
//	}
//}


using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextPage : MonoBehaviour
{
	public Button NextPageButton;

	void Start ()
	{
		Button btn = NextPageButton.GetComponent<Button> ();
		btn.onClick.AddListener (TaskOnClick);
	}

	void TaskOnClick ()
	{
		Debug.Log ("You have clicked the button!");
		Application.CaptureScreenshot ("TestScreenshot.png");


		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}