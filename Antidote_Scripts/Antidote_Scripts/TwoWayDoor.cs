using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TwoWayDoor : MonoBehaviour
{

    public GameObject DoorPhyF;
    public GameObject DoorLight;

    private AudioSource ThatsMyJam;


    private bool open;
    private bool doorLight;

    private AudioSource openSound;
    private AudioSource closeSound;

    private Animator doorAnim;

   // public List<Color> Colors1 = new List<Color>();


    // Use this for initialization
    void Start()
    {
        doorAnim = DoorPhyF.GetComponent<Animator>();
     //   gameObject.renderer.material.color = Color.white;
        DoorLight.GetComponent<Renderer>().material.color = Color.red;
        ThatsMyJam = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        open = doorAnim.GetBool("open");

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
            if ((Input.GetKeyDown(KeyCode.E) && open == false))
            {
                doorAnim.SetBool("open", true);
                DoorLight.GetComponent<Renderer>().material.color = Color.green;
                ThatsMyJam.Play();


            }

            if ((Input.GetKeyDown(KeyCode.E) && open == true))
            {
                doorAnim.SetBool("open", false);
                DoorLight.GetComponent<Renderer>().material.color = Color.red;
                ThatsMyJam.Play();

            }

        }
    }
}
