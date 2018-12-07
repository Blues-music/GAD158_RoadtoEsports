using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetClick : MonoBehaviour {

    // timer for expanding the target
    float timer;
    // value to reset to fow spawning
    float spawnTime = 0f;
    // values to spawn a new target somewhere random
    float minY = -4f;
    float maxY = 3.5f;
    float minX = -4f;
    float maxX = 4f;

    //victory audio
   /* public AudioClip VictoryA;
    AudioSource audio;
    public bool alreadyplayed = false;
    */

    // value to get current iq
    float currentIQ;

    // Referencing the target
    public GameObject circle1;

    // Referecning UI components
    public GameObject EndGame;

    // To finalise the player's score for skillbar
    float finalScore;

    // To stop game updating win actions on update
    bool gameOver = false;

	// Use this for initialization
	void Start () {
        
        timer = spawnTime;
        // This equation takes the player's attribute value and turns it into a 
        spawnTime = spawnTime + ((PlayerScript.iq * -0.01f) + 1f);
        //Victory Audio
       //audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        timer = timer - Time.deltaTime;

        // Spawns target when 0 is reached from spawnTime
        if (timer <= 0f)
        {
            SpawnTarget();
            timer = spawnTime;
        }
        
        // Ends game when score is reached
        if (Score.scoreValue == 20 && gameOver == false)
        {
            gameOver = true;
            finalScore = Score.scoreValue;
            Time.timeScale = 0;
            SkillBar.totalScore = SkillBar.totalScore + finalScore;
            Debug.Log("Current score: " + SkillBar.totalScore);
            EndGame.SetActive(true);
            PlayerMovement.playerCanMove = true;

			if (Timer.timeRemaining >= 0 && gameOver == false) 
		{
			gameOver = true;
			Time.timeScale = 0;
			SkillBar.totalScore = SkillBar.totalScore + finalScore;
			Debug.Log("Current score: " + SkillBar.totalScore);
			EndGame.SetActive(true);
			PlayerMovement.playerCanMove = true;
		}
       }
    }

    void SpawnTarget()
    {
        Vector2 spawnLocation = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Instantiate(circle1, spawnLocation, Quaternion.identity);
    }

    // Scene unloads and room scene is back
    public void ExitToRoomScene()
    {
        SceneManager.UnloadSceneAsync("Minigame_2");
        Time.timeScale = 1;

    }
}
