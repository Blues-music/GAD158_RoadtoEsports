﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        Score.scoreValue -= 1;
        Debug.Log(Score.scoreValue);
    }
}