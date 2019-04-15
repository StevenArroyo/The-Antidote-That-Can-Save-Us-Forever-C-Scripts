using UnityEngine;
using System.Collections;

public class TDTrap : TDOverlord {

    private bool GinuForce;
    private bool ButtonDone;

    private Animator GreatMovie;

	// Use this for initialization
	void Start () {
	    GreatMovie = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        GinuForce = GreatMovie.GetBool("ActivateTrap");

    }

    void OnTriggerEnter(Collider entity)
    {
        if (entity.tag == "Player" && ButtonDone == true /*entity.tag == "Green" /||/ ButtonPush == true*/)
        {
            GinuForce = true;
            GreatMovie.SetBool("ActivateTrap", true);
            print("Over 9000!!!");
        }

        if (entity.tag == "Green" /*&& ButtonPush == true*/)
        {
            ButtonDone = true;
            print("ninja attack!");
        }

    }

}
