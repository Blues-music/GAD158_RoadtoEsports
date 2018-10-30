using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ButtonExit()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void ButtonResume()
    {


    }
}
