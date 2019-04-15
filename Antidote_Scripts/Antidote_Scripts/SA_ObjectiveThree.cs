using UnityEngine;
using System.Collections;


public class SA_ObjectiveThree : MonoBehaviour
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
            ninja.CreateObjective("Num4", "Get across the acid water.");
            ninja.CompleteObjective("Num1");
            ninja.CompleteObjective("Num3");


            Destroy(this.gameObject);
        }
    }
}

