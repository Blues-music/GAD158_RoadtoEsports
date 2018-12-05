using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    /* 
    Animation and movement components in this script learnt from:
    https://www.youtube.com/playlist?list=PLiyfvmtjWC_X6e0EYLPczO9tNCkm2dzkm
    */

    // Character's move speed value
    public float moveSpeed;
    // Animation: Bool to transition from idle to moving
    private bool playerMoving;
    // Animation: Variable which dictates to animator what the idle state is 
    private Vector2 lastMove;

    // Bool to only allow 4 directional movement
    bool moveX;
    bool moveY;

    // To allow player to move
    public static bool playerCanMove = true;

    // Declaring animator
    private Animator animator;


    // Use this for initialization
    void Start () {

        moveSpeed = 4;

        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        playerMoving = false;

        // Code that allows player to move character
        // Works by manipulating a virtual scale, which ranges from -1 to 1.
        // TO DO: Disallow diagonal movement
        if (playerCanMove == true)
        {
            if (Input.GetAxisRaw("Horizontal") > 0.2f || Input.GetAxisRaw("Horizontal") < -0.2f)
            {
                transform.Translate(new Vector3((Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime), 0f, 0f));
                playerMoving = true;
                lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            }

            if (Input.GetAxisRaw("Vertical") > 0.2f || Input.GetAxisRaw("Vertical") < -0.2f)
            {
                transform.Translate(new Vector3(0f, (Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime), 0f));
                playerMoving = true;
                lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            }
        }
        

        // Values in animator set here
        animator.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        animator.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        animator.SetBool("PlayerMoving", playerMoving);
        animator.SetFloat("LastMoveX", lastMove.x);
        animator.SetFloat("LastMoveY", lastMove.y);
    }
}
