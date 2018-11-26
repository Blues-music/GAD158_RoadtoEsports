using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEngine : MonoBehaviour {

    // Value to expand and contract 
    float time;

    // Value to alter size of target
    public float targetSize;

    // Use this for initialization
    void Start () {

        transform.localScale = new Vector3(0.1f, 0.1f, 0);

    }
	
	// Update is called once per frame
	void Update () {

        time = time + Time.deltaTime;

        if (time % 2 > 1)
        {
            transform.localScale -= new Vector3(0.01f, 0.01f, 0);
        }
        else if (time % 2 < 1)
        {
            transform.localScale += new Vector3(0.01F, 0.01F, 0);
        }

    }

    public void OnMouseDown()
    {
        Destroy(gameObject);
        // Using from "Score" script
        Score.scoreValue += 1;
    }
}
