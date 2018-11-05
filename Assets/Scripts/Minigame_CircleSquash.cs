using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_CircleSquash : MonoBehaviour {

    float time;
    bool killCircle = false;

	// Use this for initialization
	void Start () {
        transform.localScale = new Vector3(0, 0, 0);

	}
	
	// Update is called once per frame
	void Update () {

        time = time + Time.deltaTime;
        
        Debug.Log((int)time);

        if (time > 1)
        {
            transform.localScale -= new Vector3(0.1f, 0.1f, 0);
        }
        else if (time > 0)
        {
            transform.localScale += new Vector3(0.1F, 0.1F, 0);
            killCircle = true;
        }
        else if (killCircle == true)
        {
            //DestroyObject();
        }
	}
}
