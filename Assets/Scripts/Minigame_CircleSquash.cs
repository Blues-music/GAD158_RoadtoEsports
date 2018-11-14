using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame_CircleSquash : MonoBehaviour
{

    float time;
    public float maxpoints = 100;


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
            transform.localScale -= new Vector3(0.1f, 0.1f, 0);
        }
        else if (time % 2 < 1)
        {
            transform.localScale += new Vector3(0.1F, 0.1F, 0);

        }

    }



    public void OnMouseDown()
    {

        Debug.Log("destroyed");
     
        Destroy(gameObject);

    }
}
 
