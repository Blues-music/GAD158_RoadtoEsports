using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
    public class ActivityBonus
    {

        // Function to grant increment to only 1 attribute
        public int IqBonus(int attribute, int bonus)
        {
            // Takes the player scripts dex and adds a bonus
            // Would like to add functionality to give diminishing returns
            PlayerScript.iq = attribute + bonus;
            Debug.Log(PlayerScript.iq);
            return PlayerScript.iq;
        }

       
    }

