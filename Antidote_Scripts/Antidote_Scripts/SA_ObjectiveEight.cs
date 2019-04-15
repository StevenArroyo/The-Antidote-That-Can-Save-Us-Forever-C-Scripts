using UnityEngine;
using System.Collections;


public class SA_ObjectiveEight : MonoBehaviour
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

            ninja.CompleteObjective("Num8");
            ninja.RemoveObjective("Num1");
            ninja.RemoveObjective("Num2");
            ninja.RemoveObjective("Num3");
            ninja.RemoveObjective("Num4");
            ninja.RemoveObjective("Num5");
            ninja.RemoveObjective("Num6");
            ninja.RemoveObjective("Num7");
            ninja.RemoveObjective("Num8");
            Destroy(this.gameObject);
        }
    }
}
