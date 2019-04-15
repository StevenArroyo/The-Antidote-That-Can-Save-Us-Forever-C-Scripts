using UnityEngine;
using System.Collections;


public class Ivy_LoadLevel_Zach : MonoBehaviour {

	private bool StartTimer;
	private float TimeBomb;


	void OnTriggerEnter (Collider entity) 
	{
		StartTimer = true;

		if (entity.tag == "Player") 
		{
			print ("Player has enter Zach's Area");
		}

		if (entity.tag == "Player") 
		{ 
			Application.LoadLevelAdditive ("ZumTobel_Zachary"); 
			
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

	/* void OnTriggerExit (Collider entity)
	{
		if (entity.tag == "Player") 
		{ 
			Application.LoadLevelAdditive ("ZumTobel_Zachary") = false;
		}
	} */ 

}
