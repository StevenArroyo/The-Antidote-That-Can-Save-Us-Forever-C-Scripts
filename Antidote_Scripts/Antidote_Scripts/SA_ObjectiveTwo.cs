using UnityEngine;
using System.Collections;


public class SA_ObjectiveTwo : MonoBehaviour
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
            ninja.CreateObjective("Num3", "Explore the hospital.");
            ninja.CompleteObjective("Num2");

            Destroy(this.gameObject);
        }
    }
}
