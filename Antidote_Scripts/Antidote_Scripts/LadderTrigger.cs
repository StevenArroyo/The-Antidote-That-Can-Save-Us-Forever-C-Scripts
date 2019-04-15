using UnityEngine;
using System.Collections;

public class LadderTrigger : MonoBehaviour {

	public bool isPlayerHere = false;

	public bool isExit = false;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && isExit == false) {
			isPlayerHere = true;
		}
	}

	void OnTriggerExit(Collider other){

		if (other.name == "LadderCamera" && isExit == true) {
			isPlayerHere = true;
		}

		if (other.tag == "Player" && isExit == true) {
			isPlayerHere = false;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
