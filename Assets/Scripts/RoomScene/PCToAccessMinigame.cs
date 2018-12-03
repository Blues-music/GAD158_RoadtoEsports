using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PCToAccessMinigame : MonoBehaviour {

    public GameObject text;

    public GameObject Player;

    bool playerEntered;

	// Use this for initialization
	void Start () {
        Player.GetComponent<PlayerScript>();
	}
	
	// Update is called once per frame
	void Update () {

        // Allows interaction when in range
		if (playerEntered == true && Input.GetButtonDown("Interact"))
        {
            SceneManager.LoadScene("Minigame_2", LoadSceneMode.Additive);
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
        // PlayerScript.SetActive
    }
}
