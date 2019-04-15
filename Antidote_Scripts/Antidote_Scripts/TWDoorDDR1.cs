using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TWDoorDDR1 : MonoBehaviour
{
    private ObjectiveList ninja;

    private AudioSource ThatsMyJam;


    public GameObject DoorPhyF;
    public GameObject DoorLight;

    public GameObject DDR1;

    private bool open;
    private bool doorLight;
    private bool dummy = true;

    private AudioSource openSound;
    private AudioSource closeSound;

    private Animator doorAnim;

    private bool Objective = false;
    private bool dummy2 = true;


    // public List<Color> Colors1 = new List<Color>();


    // Use this for initialization
    void Start()
    {
        doorAnim = DoorPhyF.GetComponent<Animator>();
        //   gameObject.renderer.material.color = Color.white;
        DoorLight.GetComponent<Renderer>().material.color = Color.black;
        //DDR1.GetComponent

        ninja = GameObject.FindObjectOfType<ObjectiveList>();
        ThatsMyJam = GetComponent<AudioSource>();



        /*

        if (GameObject.Find("name of the gameobject holding the script with the bool").GetComponent<name of the script holding the bool>().IsLightOn) //will check if true
 
        if (!GameObject.Find("name of the gameobject holding the script with the bool").GetComponent<name of the script holding the bool>().IsLightOn) //will check if false

        */
    }

    // Update is called once per frame
    void Update()
    {
        open = doorAnim.GetBool("open");

        if (Objective == true && dummy == true)
        {
            ninja.CompleteObjective("DDR1");
            //ninja.RemoveObjective("Climb");
            print("it did the thing");
            Objective = false;
            dummy = false;
            

        }

        if (dummy2 == true && GameObject.Find("DDR1").GetComponent<DDR1Overlord>().DDR1Done)
        {
            DoorLight.GetComponent<Renderer>().material.color = Color.red;
            dummy2 = false;
        }

        //print(Objective);

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
        if (entity.tag == "Player" && GameObject.Find("DDR1").GetComponent<DDR1Overlord>().DDR1Done)
        {
            if ((Input.GetKeyDown(KeyCode.E) && open == false))
            {
                doorAnim.SetBool("open", true);
                DoorLight.GetComponent<Renderer>().material.color = Color.green;
                Objective = true;//+= Time.deltaTime;
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

