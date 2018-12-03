using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEngine : MonoBehaviour {

    // Value to expand and contract 
    float time;

    // Variables to dismiss circle after time
    float lifeTime;
    bool killReady;

    // Value to alter size of target
    public float targetSize;

    //Audio
    public AudioSource FatClap;

    // Use this for initialization
    void Start () {
         
        // Starting scale of target
        transform.localScale = new Vector3(0f, 0f, 0);
       
        transform.localScale = new Vector3(0.1f, 0.1f, 0);
        FatClap = GameObject.Find("fat-clap").GetComponent<AudioSource>();

        if  (PlayerScript.dex > 20)
        {
            targetSize = 0.03f;
        }
        else if (PlayerScript.dex > 10)
        {
            targetSize = 0.02f;
        }
        else
        {
            targetSize = 0.005f;
        }
    }
	
	// Update is called once per frame
	void Update () {

        time = time + Time.deltaTime;
        lifeTime = lifeTime + Time.deltaTime;

        // Expands then contracts targets. Based on "modulo" (the % sign). Essentially expands for a second then contracts for a second.
        // Vector3 here changes size of oscillation
        if (time % 2 > 1)
        {
            transform.localScale -= new Vector3(targetSize, targetSize, 0);
            killReady = true;
        }
        else if (time % 2 < 1)
        {
            transform.localScale += new Vector3(targetSize, targetSize, 0);
        }

        // Destroys targets after set time
        if (lifeTime >= 2 && killReady == true)
        {
            Destroy(gameObject);
        }

        // Destroys targets left over after victory
        if (Time.timeScale == 0)
        {
            Destroy(gameObject);
        }

        
    }

    public void OnMouseDown()
    {
        Destroy(gameObject);
        // Using from "Score" script
        Score.scoreValue += 1;
        FatClap.Play();
    }
}
