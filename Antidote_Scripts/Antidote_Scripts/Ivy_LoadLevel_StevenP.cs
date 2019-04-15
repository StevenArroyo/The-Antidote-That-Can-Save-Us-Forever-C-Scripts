using UnityEngine;
using System.Collections;


public class Ivy_LoadLevel_StevenP : MonoBehaviour {

	public GameObject Scene_Node_ZZ; 


	void OnTriggerEnter (Collider entity) 
	{
		
		if (entity.tag == "Player") 
		{ 
			print ("Player has enter Steven Pickett's Area");

			Application.LoadLevelAdditive ("PickettSteven");

			Destroy (Scene_Node_ZZ); 

		}
	} 
}
