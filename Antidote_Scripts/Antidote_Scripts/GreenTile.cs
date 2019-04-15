using UnityEngine;
using System.Collections;
using System;

public class GreenTile : DDRTesting
{

    
    //public GameObject GreenSignal;


    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (colorNow == "Green")
        {
            print("colorNow Green change works.");
        }

        if (greenOn == true)
        {
            GreenSwap();
        }

        if (greenOn == false)
        {
            GreenRevert();
        }
    }

    void GreenSwap()
    {
        GreenSignal.transform.position = new Vector3(-14.88f, -16.25f, 66.5f);
        //print(transform.position.x);
    }

    void GreenRevert()
    {
        GreenSignal.transform.position = new Vector3(-15.13f, -16.25f, 66.5f);
        //print(transform.position.x);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Enter Green");
            greenOn = true;

        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            print("Exit Green");
            greenOn = false;
        }
    }

}
