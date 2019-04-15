using UnityEngine;
using System.Collections;

public class TileCollector : MonoBehaviour {

    private ObjectiveList ninja;

    public GameObject Blue;
    public GameObject Yellow;
    public GameObject Red;
    public GameObject Green;

    public GameObject bluePiece;
    public GameObject greenPiece;
    public GameObject yellowPiece;

    private float dummy = 0f;


    private bool GreenIn;
    //private bool RedIn;
    private bool BlueIn;
    private bool YellowIn;
    private bool OtherDummy = true;

    public bool AllCollected;


	// Use this for initialization
	void Start () {

        Blue.GetComponent<Renderer>().material.color = Color.black;
        Yellow.GetComponent<Renderer>().material.color = Color.black;
        Green.GetComponent<Renderer>().material.color = Color.black;
        //Red.GetComponent<Renderer>().material.color = Color.black;

        ninja = GameObject.FindObjectOfType<ObjectiveList>();


        /*
        Blue.GetComponent<Renderer>().material.color = Color.blue;
        Yellow.GetComponent<Renderer>().material.color = Color.yellow;
        Green.GetComponent<Renderer>().material.color = Color.green;
        Red.GetComponent<Renderer>().material.color = Color.red;
        */
    }

    // Update is called once per frame
    void Update () {

        if (AllCollected == true)
        {
            dummy += Time.deltaTime;
            print("THIS TIME RIGHT HERE");

        }

        if (GreenIn == true && YellowIn == true && BlueIn == true)
        {
            AllCollected = true;
            ninja.RemoveObjective("Green");
            ninja.RemoveObjective("Yellow");
            ninja.RemoveObjective("Blue");

        }

        if (dummy >= 1f && OtherDummy == true)
        {
            ninja.CompleteObjective("Num5");
            print("THIS THING RIGHT HERE");
            OtherDummy = false;

        }

    }

    void OnTriggerEnter (Collider col)
    {
        if (col.gameObject.name == "Green Tile")
        {
            Green.GetComponent<Renderer>().material.color = Color.green;
            GreenIn = true;
            ninja.CompleteObjective("Green");
            Destroy(greenPiece);

        }

        if (col.gameObject.name == "Blue Tile")
        {
            Blue.GetComponent<Renderer>().material.color = Color.blue;
            BlueIn = true;
            ninja.CompleteObjective("Blue");
            Destroy(bluePiece);


        }

        if (col.gameObject.name == "Yellow Tile")
        {
            Yellow.GetComponent<Renderer>().material.color = Color.yellow;
            YellowIn = true;
            ninja.CompleteObjective("Yellow");
            Destroy(yellowPiece);


        }

    }

    void OnTriggerStay(Collider col)
    {

    }

    void OnTriggerExit(Collider col)
    {

    }

}
