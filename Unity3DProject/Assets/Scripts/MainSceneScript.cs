using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneScript : MonoBehaviour
{
	public Button firstSceneBtn, secondSeceneBtn;

	void Start ()
	{
		Button btn1 = firstSceneBtn.GetComponent<Button>();
		btn1.onClick.AddListener(LoadFirstScene);

		Button btn2 = secondSeceneBtn.GetComponent<Button>();
		btn2.onClick.AddListener(LoadSecondScene);
	}

    public void LoadFirstScene(){
		Debug.Log ("You have clicked the button1!");
		SceneManager.LoadScene("Scenes/FirstScene");
	}

    public void LoadSecondScene(){
		Debug.Log ("You have clicked the button2!");
		SceneManager.LoadScene("Scenes/SecondScene");
	}
}
