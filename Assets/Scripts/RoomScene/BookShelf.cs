using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookShelf : MonoBehaviour {

    ActivityBonus activity = new ActivityBonus();
    public GameObject text;
    public Text textField;

    int iq;

    // Bool used to register if player is within collision trigger
    bool playerEntered;
    // Used to stop player from stacking actions
    bool activityReady = true;


	// Use this for initialization
	void Start () {

        // Use "get" to access static public variables in other scripts
        int getiq = PlayerScript.iq;
        
    }
	
	// Update is called once per frame
	void Update () {

        // Allows interaction when in range
        // Changes text when interacted
        if (playerEntered == true && Input.GetButtonDown("Interact") && activityReady == true)
        {
            textField.text = "Reading...";
            StartCoroutine(IqBonus(4f));            
        }
    }

    // Functions for allowing text to appear and dissapear
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerEntered = true;
        text.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerEntered = false;
        text.SetActive(false);
    }

    // Using this coroutine is a solution to invoking the function after a delay
    IEnumerator IqBonus(float time)
    {
        activityReady = false;
        yield return new WaitForSeconds(4f);

        activity.IqBonus(PlayerScript.iq, 6);
        textField.text = "Good job! Another?";
        activityReady = true;
    }
}
