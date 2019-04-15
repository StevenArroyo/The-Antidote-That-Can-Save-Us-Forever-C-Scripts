using UnityEngine;
using System.Collections;


public class SA_ObjectiveOne : MonoBehaviour
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
            ninja.CreateObjective("Num1", "Get the antidote.");
            ninja.CreateObjective("Num2", "Find the another way into the hospital.");

            Destroy(this.gameObject);
        }
    }
}
