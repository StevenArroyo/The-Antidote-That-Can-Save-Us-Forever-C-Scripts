using UnityEngine;
using System.Collections;


public class SA_ObjectiveFour : MonoBehaviour
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
            ninja.CreateObjective("Num5", "Get to the cafeteria's janitor closet.");
            ninja.CompleteObjective("Num4");

            Destroy(this.gameObject);
        }
    }
}
