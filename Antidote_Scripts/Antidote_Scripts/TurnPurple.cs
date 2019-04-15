using UnityEngine;
using System.Collections;

public class TurnPurple : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if ((Input.GetKeyDown(KeyCode.E)))
        {
            GetComponent<Renderer>().material.color = Color.black;

        }

        if ((Input.GetKeyUp(KeyCode.E)))
        {
            GetComponent<Renderer>().material.color = Color.green;

        }


    }
}
