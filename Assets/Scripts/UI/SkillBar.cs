﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillBar : MonoBehaviour {

    // Referencing the skill bar
    public Image Bar;

    // Value used to collect score from minigame
    public static float totalScore;

	// Use this for initialization
	void Start () {
        totalScore = 0;
	}
	
	// Update is called once per frame
	void Update () {

        Bar.fillAmount = (totalScore * 0.001f);

    }
}