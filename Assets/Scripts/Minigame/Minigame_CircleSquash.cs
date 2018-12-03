using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_CircleSquash : MonoBehaviour
{

    // Not sure where this script is attached

    float time;
    public float maxpoints = 100;

    // Initiating victory text for referencing 
    public GameObject victoryText;

    // Use this for initialization
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }
    // Update is called once per frame
    void Update()
    {

        time = time + Time.deltaTime;

        Debug.Log(time % 2);

        if (time % 2 > 1)
        {
            transform.localScale -= new Vector3(0.05f, 0.05f, 0);
        }
        else if (time % 2 < 1)
        {
            transform.localScale += new Vector3(0.05F, 0.05F, 0);

        }

        Destroy(gameObject, 2);

    }



    public void OnMouseDown()
    {

        Debug.Log("destroyed");
     
        Destroy(gameObject);
        // Using from "Score" script
        Score.scoreValue += 1;
    }

    
}
 
