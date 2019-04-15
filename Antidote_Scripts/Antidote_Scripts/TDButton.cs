using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TDButton : TDOverlord {

    public GameObject Button;
    public GameObject TriggerCube;

	// Use this for initialization
	void Start () {
        Button.GetComponent<Renderer>().material.color = Color.red;

    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.E) && col.tag == "Player")
        {
            Button.GetComponent<Renderer>().material.color = Color.green;
            ButtonPush = true;
            //(-13.15f/-12.9f, 24.55f, 51.25f)
            //TriggerCube.transform.position = new Vector3(-12.9f, 24.55f, 51.25f);
            //(0.75f, -3.0f, 47.25f)
            TriggerCube.transform.localPosition = new Vector3(-45.287f, -3f, 107.4908f);

            TriggerCube.GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
