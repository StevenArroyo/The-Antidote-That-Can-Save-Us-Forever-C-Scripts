using UnityEngine;
using System.Collections;

public class SA_Door : MonoBehaviour
{


    public GameObject Door;

    private Animator doorAnim;

    private bool toggleOpen;

    private AudioSource controlAudio;





    // Use this for initialization
    void Start()
    {
        doorAnim = Door.GetComponent<Animator>();
        controlAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        toggleOpen = doorAnim.GetBool("toggleOpen");

    }

    void OnTriggerEnter(Collider entity)
    {
        if (entity.tag == "Player")
        {
            print("The Player has entered the Control Trigger!");
        }
    }

    void OnTriggerStay(Collider entity)
    {
        if (entity.tag == "Player")
        {
            if (Input.GetKeyUp(KeyCode.E) && toggleOpen == false)
            {
                doorAnim.SetBool("toggleOpen", true);
                print("The Player has activated the Door!");
                controlAudio.Play();
            }
            if (Input.GetKeyUp(KeyCode.E) && toggleOpen == true)
            {
                doorAnim.SetBool("toggleOpen", false);
                print("The Player has deactivated the Door!");
                /* controlAudio.Play ();
				pivotAudio.Play ();
				*/
            }
        }
    }

    void OnTriggerExit(Collider entity)
    {
        if (entity.tag == "Player")
        {
            print("The Player has left the Control Trigger!");
        }
    }
}
