using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    // once  Play Button is clicked, load scene "1"
    public void Play ()
    {
        SceneManager.LoadScene(1);
    }
    // once clicked, quit the game/application.
    public void Quit()
    {
        Application.Quit();
    }
}
