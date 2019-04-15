using UnityEngine;
using System.Collections;

public class DDR1Overlord : MonoBehaviour {

    public GameObject Screen;

    private AudioSource ThatsMyJam;


    private bool greenOn = false;
    private bool redOn = false;
    private bool blueOn = false;
    private bool yellowOn = false;

    public bool DDR1Done = false;

    private string stepOnThis;

    private int stepNum;

    private bool dummy = true;

    //public GameObject Green;


    // if (stepOnThis == "<color>" && <color>On == true) { advance script/ thisStep++  }
    //Red, Green, Blue, Red, Yellow


    // Use this for initialization
    void Start () {

        stepOnThis = "Red";
        ThatsMyJam = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update () {

        //Changing the color of the screen

        if (stepOnThis == "Red" || stepOnThis == "Red2")
        {
            Screen.GetComponent<Renderer>().material.color = Color.red;

        }

        if (stepOnThis == "Green")
        {
            Screen.GetComponent<Renderer>().material.color = Color.green;

        }

        if (stepOnThis == "Blue")
        {
            Screen.GetComponent<Renderer>().material.color = Color.blue;

        }

        if (stepOnThis == "Yellow")
        {
            Screen.GetComponent<Renderer>().material.color = Color.yellow;

        }

        if (stepOnThis == "End")
        {
            Screen.GetComponent<Renderer>().material.color = Color.black;

        }



        //Checking what color to change to and what step you're on
        //R,G,B,R,Y

        if (stepOnThis == "Red" && redOn == true)
        {
            stepNum++;
            stepOnThis = "Green";
            print(stepNum);
            print("ninja sauce red done");
        }

        if (stepOnThis == "Green" && greenOn == true)
        {
            stepNum++;
            stepOnThis = "Blue";
            print(stepNum);
            print("ninja sauce green done");

        }

        if (stepOnThis == "Blue" && blueOn == true)
        {
            stepNum++;
            stepOnThis = "Red2";
            print(stepNum);

        }

        if (stepOnThis == "Red2" && redOn == true)
        {
            stepNum++;
            stepOnThis = "Yellow";
            print(stepNum);

        }

        if (stepOnThis == "Yellow" && yellowOn == true)
        {
            stepNum++;
            stepOnThis = "End";
            print(stepNum);

        }

        if (stepOnThis == "End" && stepNum == 5)
        {
            DDR1Done = true;

        }

        if (DDR1Done == true && dummy == true)
        {
            ThatsMyJam.Play();
            dummy = false;
        }


    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Green")
        {
            //Screen.GetComponent<Renderer>().material.color = Color.green;
            //print("Green hits");
            greenOn = true;

        }

        if (col.tag == "Red")
        {
            //Screen.GetComponent<Renderer>().material.color = Color.red;
            //print("Red hits");
            redOn = true;

        }

        if (col.tag == "Yellow")
        {
            //Screen.GetComponent<Renderer>().material.color = Color.yellow;
            //print("Yellow hits");
            yellowOn = true;

        }

        if (col.tag == "Blue")
        {
            //Screen.GetComponent<Renderer>().material.color = Color.blue;
            //print("Blue hits");
            blueOn = true;

        }

    }

    void OnTriggerExit(Collider col)
    {

        if (col.gameObject.tag == "Green")
        {
            //Screen.GetComponent<Renderer>().material.color = Color.green;
            //print("Green dies");
            greenOn = false;

        }

        if (col.tag == "Red")
        {
            //Screen.GetComponent<Renderer>().material.color = Color.red;
            //print("Red dies");
            redOn = false;

        }

        if (col.tag == "Yellow")
        {
            //Screen.GetComponent<Renderer>().material.color = Color.yellow;
            //print("Yellow dies");
            yellowOn = false;

        }

        if (col.tag == "Blue")
        {
            //Screen.GetComponent<Renderer>().material.color = Color.blue;
            //print("Blue dies");
            blueOn = false;

        }

    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "")
        {

        }

    }


    /*

    if (GameObject.Find("name of the gameobject holding the script with the bool").GetComponent<name of the script holding the bool>().IsLightOn) //will check if true
 
    if (!GameObject.Find("name of the gameobject holding the script with the bool").GetComponent<name of the script holding the bool>().IsLightOn) //will check if false

       //

     if (gameObject.GetComponent<name of the script holding the bool>().IsLightOn)//will check if true
 
    if (!gameObject.GetComponent<name of the script holding the bool>().IsLightOn)//will check if false
    */
}
