using UnityEngine;
using System.Collections;


public class SA_ObjectiveFive : MonoBehaviour
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
            ninja.CreateObjective("Num6", "Explore the subway.");
            ninja.CompleteObjective("Num5");

            Destroy(this.gameObject);
        }
    }
}
