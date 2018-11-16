using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    private float nxtspwntime;
    [SerializeField]
    public GameObject circle1;
    public Transform spwnposition1;
    public Transform spwnposition2;
    public Transform spwnposition3;
    public Transform spwnposition4;
    public Transform spwnposition5;
    public Transform spwnposition6;

    public int choosespwn;
    [SerializeField]
    private float spwndelay;

    public float timer;

	// Use this for initialization
	void Start () {

       // timer = 15; whats the point of a public float if it gets overwritten anyway? - Niall
     
    }
	
	// Update is called once per frame
	void Update () {
        choosespwn = Random.Range(1, 7);

        if (shouldspwn() && choosespwn == 1)
        {
            spawn1();
            timer -= 1;
        }
        else 
        if(shouldspwn() && choosespwn == 2)
        {
            spawn2();
            timer -= 1;
        }
        else
        if (shouldspwn() && choosespwn == 3)
        {
            spawn3();
            timer -= 1;
        }
        else
        if (shouldspwn() && choosespwn == 4)
        {
            spawn4();
            timer -= 1;
        }

        else
        if (shouldspwn() && choosespwn == 5)
        {
            spawn5();
            timer -= 1;
        }
        else
        if (shouldspwn() && choosespwn == 6)
        {
            spawn6();
            timer -= 1;
        }
        if(timer == 0)
        {
            timer = 0;
            
            Debug.Log("finished");
        }
        spwndelay = Random.Range(0, 4);

    }
    private bool shouldspwn()
    {
        return Time.time > nxtspwntime;
    }
    private void spawn1()
    {
        nxtspwntime = Time.time + spwndelay;
        Instantiate(circle1, spwnposition1.transform.position, transform.rotation);
        destroyaftertime();
    }
    private void spawn2()
    {
        nxtspwntime = Time.time + spwndelay;
        Instantiate(circle1, spwnposition2.transform.position, transform.rotation);
        destroyaftertime();
    }

    private void spawn3()
    {
        nxtspwntime = Time.time + spwndelay;
        Instantiate(circle1, spwnposition3.transform.position, transform.rotation);
        destroyaftertime();
    }
    private void spawn4()
    {
        nxtspwntime = Time.time + spwndelay;
        Instantiate(circle1, spwnposition4.transform.position, transform.rotation);
        destroyaftertime();
    }
    private void spawn5()
    {
        nxtspwntime = Time.time + spwndelay;
        Instantiate(circle1, spwnposition5.transform.position, transform.rotation);
        destroyaftertime();
    }
    private void spawn6()
    {
        nxtspwntime = Time.time + spwndelay;
        Instantiate(circle1, spwnposition6.transform.position, transform.rotation);
        destroyaftertime();
    }

    public void destroyaftertime()
    {
        
    }
}
