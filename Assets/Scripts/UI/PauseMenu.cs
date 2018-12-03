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
    // Main Menu Button when clicked to change scene to 'Main Menu' Scene.
    public void ButtonExit()
    {
        SceneManager.LoadScene("Main Menu");
    }
    // Resume Button when clicked to resume the current scene.
    public void ButtonResume()
    {
        Time.timeScale = 1;
        Destroy(gameObject);


    }
}
