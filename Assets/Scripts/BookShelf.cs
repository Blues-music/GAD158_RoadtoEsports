using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShelf : MonoBehaviour {

    public GameObject player;

    ActivityBonus activity = new ActivityBonus();

	// Use this for initialization
	void Start () {

        //player = GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.anyKeyDown)
        {
            activity.ActivityAttributeBonus(1, 6);
        }
    }
}
