using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
   
    // Daclaring attributes
    static public int str;
    static public int agi;
    static public int dex;
    static public int iq;

    public int originalIq;

    // Use this for initialization
    void Start()
    {
        iq = 0;
        dex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (iq)


        iq = originalIq + iq;
    }

    
}
