using UnityEngine;
using System.Collections;

public class ZiplineTrigger : MonoBehaviour {

	public bool isPlayerHere = false;

	public bool isExit = false;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player" && isExit == false) {
			isPlayerHere = true;
		}
	}

	void OnTriggerExit(Collider other)
	{

		if (other.name == "ziplineCamera" && isExit == true) 
		{
			isPlayerHere = true;
		}

		if (other.tag == "Player" && isExit == false) 
		{
			isPlayerHere = false;
		}
	}
		
}
