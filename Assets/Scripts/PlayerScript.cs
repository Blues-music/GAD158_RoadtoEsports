using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    // Character's move speed value
    public float moveSpeed;
    // Bool to only allow 4 directional movement
    bool moveX;
    bool moveY;

    // Initialising animator
    private Animator animator;

    // Initialising attributes
    static public int str;
    static public int agi;
    static public int dex;
    static  public int iq;

    // Use this for initialization
    void Start()
    {

        animator = GetComponent<Animator>();

        str = 0;
        agi = 0;
        dex = 0;
        iq = 0;
    }

    // Update is called once per frame
    void Update()
    {

        // Code that allows player to move character
        if (Input.GetAxisRaw("Horizontal") > 0.2f || Input.GetAxisRaw("Horizontal") < -0.2f)
        {
            transform.Translate(new Vector3((Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime), 0f, 0f));
        }

        if (Input.GetAxisRaw("Vertical") > 0.2f || Input.GetAxisRaw("Vertical") < -0.2f)
        {
            transform.Translate(new Vector3(0f, (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime), 0f));
        }

        // Code to set the animations
        animator.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }
}
