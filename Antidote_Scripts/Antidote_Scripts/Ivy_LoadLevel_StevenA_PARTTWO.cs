using UnityEngine;
using System.Collections;


public class Ivy_LoadLevel_StevenA_PARTTWO : MonoBehaviour {

	private bool StartTimer;
	private float TimeBomb;

	public GameObject SP_SceneNode; 


	void OnTriggerEnter (Collider entity) 
	{
		StartTimer = true;
		if (entity.tag == "Player") 
		{ 
			print ("Player has left Steven Pickett's Area");

			//Application.LoadLevelAdditive ("Arroyo_Steven");

			Destroy (SP_SceneNode); 

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