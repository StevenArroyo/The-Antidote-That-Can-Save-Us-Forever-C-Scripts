using UnityEngine;
using System.Collections;


public class SA_ObjectiveSix : MonoBehaviour
{


    private ObjectiveList ninja;


    // Use this for initialization
    void Start()
    {


        ninja = GameObject.FindObjectOfType<ObjectiveList>();


    }


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            ninja.CreateObjective("Num7", "Ride on the cart.");
            ninja.CompleteObjective("Num6");

            Destroy(this.gameObject);
        }
    }
}
