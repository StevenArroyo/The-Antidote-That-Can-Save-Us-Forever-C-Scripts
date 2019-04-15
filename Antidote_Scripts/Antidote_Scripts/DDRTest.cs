using UnityEngine;
using System.Collections;

public class DDRTesting : MonoBehaviour
{

    public string colorNow;
    public string colorLast;
    private string stepOnThis;

    public bool greenOn = false;
    public bool redOn = false;
    public bool blueOn = false;
    public bool yellowOn = false;

    //private int thisStep;

    public GameObject GreenSignal;
    public GameObject RedSignal;
    public GameObject BlueSignal;
    public GameObject YellowSignal;

    // if (stepOnThis == "<color>" && <color>On == true) { advance script/ thisStep++  }
    //Red, Green, Blue, Red, Yellow

    // Use this for initialization
    void Start()
    {

        //colorNow = "Start";
        colorNow = "Green";

    }

    // Update is called once per frame
    void Update()
    {
        if (colorNow != "")
        {
            //print(colorNow);
        }

        //print(stepOnThis);

        // print(colorNow + " is the color");
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Green" && colorNow == "Green")
        {
            print("Collision of Green is detected.");
            colorNow = "Blue";
            colorLast = "Green";
            GetComponent<Renderer>().material.color = Color.green;

        }

        if (col.gameObject.tag == "Blue" && colorNow == "Blue")
        {
            print("Collision of Blue is detected.");
            colorNow = "Yellow";
            colorLast = "Blue";
            GetComponent<Renderer>().material.color = Color.blue;

        }

        if (col.gameObject.tag == "Yellow" && colorNow == "Yellow")
        {
            print("Collision of Yellow is detected.");
            colorNow = "Red";
            colorLast = "YellowSignal";
            GetComponent<Renderer>().material.color = Color.yellow;

        }

        if (col.gameObject.tag == "Red" && colorNow == "Red")
        {
            print("Collision of Red is detected");
            colorNow = "Green";
            colorLast = "Red";
            GetComponent<Renderer>().material.color = Color.red;
        }

    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Green" || col.gameObject.tag == "Blue" || col.gameObject.tag == "Red" || col.gameObject.tag == "Yellow"/*&& colorNow == "Green"*/)
        {
            print("Outta here!");
            //stepOnThis = "Blue";
            //GetComponent<Renderer>().material.color = Color.gray;
        }
    }
}
