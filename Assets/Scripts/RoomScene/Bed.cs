using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bed : MonoBehaviour {

    ActivityBonus activity = new ActivityBonus();

    public GameObject text;
    public Text textField;

    public SpriteRenderer bedSprite;
    public Sprite bedEmpty;
    public Sprite bedCharSleeping;

    public GameObject Player;

    int dex;

    // Bool used to register if player is within collision trigger
    bool playerEntered;
    // Used to stop player from stacking actions
    bool activityReady = true;


    // Use this for initialization
    void Start()
    {   
        // Use "get" to access static public variables in other scripts
        int getdex = PlayerScript.dex;

        bedSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        // Allows interaction when in range
        // Changes text when interacted
        if (playerEntered == true && Input.GetButtonDown("Interact") && activityReady == true)
        {
            textField.text = "     zzzZZZ";
            StartCoroutine(DexBonus(4f));
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
    IEnumerator DexBonus(float time)
    {
        bedSprite.sprite = bedCharSleeping;
        Player.SetActive(false);
        activityReady = false;
        yield return new WaitForSeconds(4f);

        bedSprite.sprite = bedEmpty;
        Player.SetActive(true);
        textField.text = "Refreshed and Ready!";
        activityReady = true;

    }
}
