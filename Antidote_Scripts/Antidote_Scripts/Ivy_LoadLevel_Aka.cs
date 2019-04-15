using UnityEngine;
using System.Collections;


public class Ivy_LoadLevel_Aka : MonoBehaviour {

	public GameObject Arroyo_LevelNode; 


	void OnTriggerEnter (Collider entity) 
	{

		if (entity.tag == "Player") 
		{ 
			print ("Player has enter Aka's Area");

			Application.LoadLevelAdditive ("AkaSmith");

			Destroy (Arroyo_LevelNode); 

		}
	} 
}