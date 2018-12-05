using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPopUp : MonoBehaviour {

    float time;
    
    // Referencing the object the text is on
    public GameObject iqUpText;

    // Referencing the text of the object
    public Text text;

    // To turn the object off and on
    float timeTillDisable;

	// Use this for initialization
	void Start () {
        timeTillDisable = 4;
	}
	
	// Update is called once per frame
	void Update () {

        time = time + Time.deltaTime;

		if (time % 1 < .5)
        {
            text.rectTransform.Translate(0f, 0.005f, 0f);
        }
        else if (time % 1 > .5)
        {
            text.rectTransform.Translate(0f, -0.005f, 0f);
        }


        timeTillDisable = timeTillDisable - Time.deltaTime;
        if (timeTillDisable <= 0)
        {
            iqUpText.SetActive(false);
            timeTillDisable = 4;
        }
    }
}
