using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCToAccessMinigame : MonoBehaviour {

    public GameObject text;

    bool playerEntered;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Allows interaction when in range
		if (playerEntered == true && Input.GetButtonDown("Interact"))
        {
            SceneManager.LoadScene("Mini-Game");
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
}
