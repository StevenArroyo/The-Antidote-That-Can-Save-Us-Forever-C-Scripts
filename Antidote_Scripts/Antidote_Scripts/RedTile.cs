using UnityEngine;
using System.Collections;
using System;


public class RedTile : DDRTesting
{

	// Use this for initialization
	void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (colorNow == "Red")
        {
            print("colorNow Red change works.");
        }

        if (redOn == true)
        {
            RedSwap();
        }

        if (redOn == false)
        {
            RedRevert();
        }
    }

    void RedSwap()
    {
        RedSignal.transform.position = new Vector3(-14.88f, -16.25f, 66.5f);
        //print(transform.position.x);
    }

    void RedRevert()
    {
        RedSignal.transform.position = new Vector3(-15.13f, -16.25f, 66.5f);
        //print(transform.position.x);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Enter Red");
            redOn = true;

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Exit Red");
            redOn = false;
        }
    }
}
