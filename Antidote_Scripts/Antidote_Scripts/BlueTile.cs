using UnityEngine;
using System.Collections;
using System;


public class BlueTile : DDRTesting
{

	// Use this for initialization
	void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (colorNow == "Blue")
        {
            print("colorNow Blue change works.");
        }

        if (blueOn == true)
        {
            BlueSwap();
        }

        if (blueOn == false)
        {
            BlueRevert();
        }
    }

    void BlueSwap()
    {
        BlueSignal.transform.position = new Vector3(-14.88f, -16.25f, 66.5f);
        //print(transform.position.x);
    }

    void BlueRevert()
    {
        BlueSignal.transform.position = new Vector3(-15.13f, -16.25f, 66.5f);
        //print(transform.position.x);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Enter Blue");
            blueOn = true;

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Exit Blue");
            blueOn = false;
        }
    }
}
