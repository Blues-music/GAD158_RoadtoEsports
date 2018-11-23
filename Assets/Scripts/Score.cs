using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    //score start with 0
    public static int scoreValue;
    Text score;

	// Use this for initialization
	void Start () {

        scoreValue = 0;
        score = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //Score adding
        score.text = "Score: " + scoreValue;
	}
}
