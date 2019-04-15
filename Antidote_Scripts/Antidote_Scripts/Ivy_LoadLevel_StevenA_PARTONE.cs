using UnityEngine;
using System.Collections;


public class Ivy_LoadLevel_StevenA_PARTONE : MonoBehaviour {

	//public GameObject Scene_Node_ZZ; 

	private bool StartTimer;
	private float TimeBomb;

	void OnTriggerEnter (Collider entity) 
	{
		StartTimer = true;

		if (entity.tag == "Player") 
		{ 
			print ("Player has enter Steven Arroyo's Area");

			Application.LoadLevelAdditive ("Arroyo_Steven");

			//Destroy (Scene_Node_ZZ); 

		}
	}

	void Update () {

		if (StartTimer == true)
		{
			TimeBomb += Time.deltaTime;
		}

		if (TimeBomb >= 2)
		{
			Destroy(this.gameObject);
		}
	}
}