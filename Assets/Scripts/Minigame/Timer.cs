using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
    //Count down time start
	public static  float timeRemaining = 60;
    public Text timerText;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        timeRemaining -= Time.deltaTime;
	}

    
    void OnGUI()
    {
        if(timeRemaining > 0)
        {
            //The position of the timer
            //GUI.Label(new Rect(1300, 0, 200, 100), "Time: " + (int)timeRemaining);
            timerText.text = ("Time: " + (int)timeRemaining) ;
        }
        else
        {
            //When the time is 0, load scene(room)
            SceneManager.LoadScene(1);
        }
    }
}
