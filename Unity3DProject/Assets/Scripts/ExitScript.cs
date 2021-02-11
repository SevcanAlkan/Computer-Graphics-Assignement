using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitScript : MonoBehaviour
{
    public Button exitBtn;

    void Start ()
    {
        Button btn = exitBtn.GetComponent<Button>();
        btn.onClick.AddListener(ExitGame);
    }

    public void ExitGame(){
        Debug.Log("exitgame");
        Application.Quit();
    }
}
