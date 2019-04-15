using UnityEngine;
using System.Collections;

public class ClosetOpener : MonoBehaviour {

    public GameObject Closet;

    private bool closetOpen;

    private Animator closetAnim;


    // Use this for initialization
    void Start () {
        closetAnim = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        closetOpen = closetAnim.GetBool("FeminismTrigger");
        //closetOpen = false;
	}

    void OnTriggerEnter(Collider entity)
    {
        if (entity.tag == "Player")
        {
            print("The player has entered the TRIGGER");
        }
    }

    void OnTriggerStay(Collider entity)
    {
        if (entity.tag == "Player")
        {
            if ((Input.GetKeyDown(KeyCode.E) && closetOpen == false))
            {
                closetAnim.SetBool("FeminismTrigger", true);
                print("Turn true works");

            }

            if ((Input.GetKeyDown(KeyCode.E) && closetOpen == true))
            {
                closetAnim.SetBool("FeminismTrigger", false);
                print("Turn false works");

            }

        }
    }

}
