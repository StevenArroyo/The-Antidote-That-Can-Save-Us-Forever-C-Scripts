using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class OneWayDoor : MonoBehaviour {

    public GameObject oDoorGoUp;
    public GameObject oDoorLight;

    private AudioSource ThatsMyJam;


    private bool oLight;
    private bool oDoorOpen;

    private AudioSource oDoorSound;

    private Animator oDoorAnim;


	// Use this for initialization
	void Start () {
        oDoorAnim = GetComponent<Animator>();
        oDoorLight.GetComponent<Renderer>().material.color = Color.red;
        ThatsMyJam = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update () {
        oDoorOpen = oDoorAnim.GetBool("OpenSaysMe");
    }

    void OnTriggerEnter(Collider entity)
    {
        if (entity.tag == "Player")
        {
            print("The player has entered the trigger");
        }
    }

    void OnTriggerStay(Collider entity)
    {
        if (entity.tag == "Player")
        {
            if ((Input.GetKeyDown(KeyCode.E) && oDoorOpen == false))
            {
                oDoorAnim.SetBool("OpenSaysMe", true);
                oDoorLight.GetComponent<Renderer>().material.color = Color.green;
                ThatsMyJam.Play();


            }
        }
    }
    
    void OnTriggerExit (Collider entity)
    {
        if (oDoorOpen == true)
        {
            oDoorAnim.SetBool("OpenSaysMe", false);
            oDoorLight.GetComponent<Renderer>().material.color = Color.red;
        }

    }

}
