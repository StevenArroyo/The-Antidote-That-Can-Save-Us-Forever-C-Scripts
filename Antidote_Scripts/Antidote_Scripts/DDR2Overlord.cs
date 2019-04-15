using UnityEngine;
using System.Collections;

public class DDR2Overlord : MonoBehaviour {

    public GameObject Screen;

    private bool greenOn = false;
    private bool redOn = false;
    private bool blueOn = false;
    private bool yellowOn = false;

    public bool DDR2Done = false;

    private string stepOnThis;

    private int stepNum;

    private int dummy = 0;
    private float dummy2 = 0f;
    private bool dummy3 = true;

    private ObjectiveList ninja;

    private AudioSource ThatsMyJam;



    //public GameObject Green;


    // if (stepOnThis == "<color>" && <color>On == true) { advance script/ thisStep++  }
    //Red, Green, Blue, Red, Yellow
    //Y,B,R,G,R2,Y2,B2,R3,B3,G2



    // Use this for initialization
    void Start()
    {

        ninja = GameObject.FindObjectOfType<ObjectiveList>();
        ThatsMyJam = GetComponent<AudioSource>();

        stepOnThis = "End";

    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("TileCollector").GetComponent<TileCollector>().AllCollected /*&& dummy == true*/)
        {
            dummy++;
            print("it went through");
        }

        if (dummy == 1)
        {
            stepOnThis = "Yellow";
            print("This one also went through");
            ninja.CreateObjective("DDR22", "Use the machine to open the exit");

        }
        //Changing the color of the screen

        if (stepOnThis == "Red" || stepOnThis == "Red2" || stepOnThis == "Red3") 
        {
            Screen.GetComponent<Renderer>().material.color = Color.red;

        }

        if (stepOnThis == "Green" || stepOnThis == "Green2")
        {
            Screen.GetComponent<Renderer>().material.color = Color.green;

        }

        if (stepOnThis == "Blue" || stepOnThis == "Blue2" || stepOnThis == "Blue3")
        {
            Screen.GetComponent<Renderer>().material.color = Color.blue;

        }

        if (stepOnThis == "Yellow" || stepOnThis == "Yellow2")
        {
            Screen.GetComponent<Renderer>().material.color = Color.yellow;

        }

        if (stepOnThis == "End")
        {
            Screen.GetComponent<Renderer>().material.color = Color.black;

        }



        //Checking what color to change to and what step you're on
        //R,G,B,R,Y
        //Y,B,R,G,R2,Y2,B2,R3,B3,G2

        if (stepOnThis == "Yellow" && yellowOn == true)
        {
            stepNum++;
            stepOnThis = "Blue";
            print(stepNum);
        }

        if (stepOnThis == "Blue" && blueOn == true)
        {
            stepNum++;
            stepOnThis = "Red";
            print(stepNum);

        }

        if (stepOnThis == "Red" && redOn == true)
        {
            stepNum++;
            stepOnThis = "Green";
            print(stepNum);

        }

        if (stepOnThis == "Green" && greenOn == true)
        {
            stepNum++;
            stepOnThis = "Red2";
            print(stepNum);

        }

        if (stepOnThis == "Red2" && redOn == true)
        {
            stepNum++;
            stepOnThis = "Yellow2";
            print(stepNum);

        }

        if (stepOnThis == "Yellow2" && yellowOn == true)
        {
            stepNum++;
            stepOnThis = "Blue2";
            print(stepNum);

        }

        if (stepOnThis == "Blue2" && blueOn == true)
        {
            stepNum++;
            stepOnThis = "Red3";
            print(stepNum);

        }

        if (stepOnThis == "Red3" && redOn == true)
        {
            stepNum++;
            stepOnThis = "Blue3";
            print(stepNum);

        }

        if (stepOnThis == "Blue3" && blueOn == true)
        {
            stepNum++;
            stepOnThis = "Green2";
            print(stepNum);

        }

        if (stepOnThis == "Green2" && greenOn == true)
        {
            stepNum++;
            stepOnThis = "End";
            print(stepNum);

        }

        if (stepOnThis == "End" && stepNum == 10)
        {
            DDR2Done = true;
            //print("End works");
            dummy2 += Time.deltaTime;
        }

        if (dummy2 == 1f)
        {
            ninja.CompleteObjective("DDR22");
            //dummy2 = 10f;
        }

        if (DDR2Done == true && dummy3 == true)
        {
            ThatsMyJam.Play();
            dummy3 = false;
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
