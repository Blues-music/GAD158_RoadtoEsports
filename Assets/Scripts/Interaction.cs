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
        public int ActivityAttributeBonus(int attribute, int bonus)
        {
            attribute = attribute + bonus;
            Debug.Log(attribute);
            return attribute;
        }
    }

