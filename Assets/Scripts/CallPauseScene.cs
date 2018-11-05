using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CallPauseScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// When the Escape Key is pressed. open up scene 'Pause menu' Over the top of current scene.
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("Pause Menu", LoadSceneMode.Additive);


        }
	}
}
