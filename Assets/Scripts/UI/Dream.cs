using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Dream : MonoBehaviour {

    public float interval;
    public GameObject SDream;
    public bool Activee;


    void Start()
    {
        StartCoroutine(Event());

    }

    // Update is called once per frame
    void Update () {
        if (Activee == true)
        {
            SDream.SetActive(true);

        }
        else
        {
            SDream.SetActive(false);

        }


	}
   IEnumerator Event()
    {
        yield return new WaitForSeconds (3);
        Debug.Log("Dream time");

        Activee = !Activee;


        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("Room");

    }
}
