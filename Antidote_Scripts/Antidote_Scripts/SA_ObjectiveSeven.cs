using UnityEngine;
using System.Collections;


public class SA_ObjectiveSeven : MonoBehaviour
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
            ninja.CreateObjective("Num8", "Climb the rocks.");
            ninja.CompleteObjective("Num7");

            Destroy(this.gameObject);
        }
    }
}
