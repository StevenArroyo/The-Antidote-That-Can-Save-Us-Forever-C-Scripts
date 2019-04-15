using UnityEngine;
using System.Collections;
using System;


public class YellowTile : DDRTesting
{

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (colorNow == "Yellow")
        {
            print("colorNow Yellow change works.");
        }

        if (yellowOn == true)
        {
            YellowSwap();
        }

        if (yellowOn == false)
        {
            YellowRevert();
        }
    }

    void YellowSwap()
    {
        YellowSignal.transform.position = new Vector3(-14.88f, -16.25f, 66.5f);
        //print(transform.position.x);
    }

    void YellowRevert()
    {
        YellowSignal.transform.position = new Vector3(-15.13f, -16.25f, 66.5f);
        //print(transform.position.x);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Enter Yellow");
            yellowOn = true;

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Exit Yellow");
            yellowOn = false;
        }
    }
}
