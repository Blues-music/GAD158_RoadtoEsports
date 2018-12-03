using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClick : MonoBehaviour {

    // timer for expanding the target
    float timer;
    // value to reset to fow spawning
    float spawnTime = 0f;
    // values to spawn a new target somewhere random
    float minY = -4f;
    float maxY = 4f;
    float minX = -4f;
    float maxX = 4f;

    // value to get current iq
    float currentIQ;

    // Referencing the target
    public GameObject circle1;

	// Use this for initialization
	void Start () {
        
        timer = spawnTime;
        spawnTime = spawnTime + ((PlayerScript.iq * -0.01f) + 1f);
    }
	
	// Update is called once per frame
	void Update () {

        timer = timer - Time.deltaTime;

        if (timer <= 0f)
        {
            SpawnTarget();
            timer = spawnTime;
        }  

        
    }

    void SpawnTarget()
    {
        Vector2 spawnLocation = new Vector2(Random.Range(minY, maxY), Random.Range(minX, maxX));
        Instantiate(circle1, spawnLocation, Quaternion.identity);
    }

    
}
