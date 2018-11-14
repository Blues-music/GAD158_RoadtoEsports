using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShelf : MonoBehaviour {

    ActivityBonus activity = new ActivityBonus();
    public GameObject text;

    int dex;

    bool activityReady = true;

	// Use this for initialization
	void Start () {

        // Use "getX" to access static public variables in other scripts
        int getdex = PlayerScript.dex;
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    
    // Enabling the use of the activity via an input
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player") && Input.GetButtonDown("Interact") && activityReady == true)
        {
            Debug.Log("Working");
            StartCoroutine(DexBonus(4f));
        }
    }

    // Functions for allowing text to appear and dissapear
    private void OnTriggerEnter2D(Collider2D collision)
    {
        text.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.SetActive(false);
    }

    // Using this coroutine is a solution to invoking the function after a delay
    IEnumerator DexBonus(float time)
    {
        activityReady = false;
        yield return new WaitForSeconds(4f);

        activity.DexBonus(PlayerScript.dex, 6);
        activityReady = true;
    }
}
