using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Character's move speed value
    public float moveSpeed;
    // Bool to only allow 4 directional movement
    bool moveX;
    bool moveY;

    // Initialising animator
    private Animator animator;

    // Initialising attributes
    public int str;
    public int agi;
    public int dex;
    public int iq;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        // Code that allows player to move character
        if ( Input.GetAxisRaw("Horizontal") > 0.2f || Input.GetAxisRaw("Horizontal") < -0.2f)
        {
            transform.Translate(new Vector3((Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime), 0f, 0f));
        }

        if (Input.GetAxisRaw("Vertical") > 0.2f || Input.GetAxisRaw("Vertical") < -0.2f)
        {
            transform.Translate(new Vector3(0f, (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime), 0f));
        }

        animator.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
    }
}
