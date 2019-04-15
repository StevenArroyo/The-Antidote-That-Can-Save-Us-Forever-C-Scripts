using UnityEngine;
using System.Collections;

public class BigDoors : MonoBehaviour {

    public GameObject bDoors;

    private bool goGoPowerRangers;

    private Animator Megazord;

	// Use this for initialization
	void Start () {

        Megazord = bDoors.GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {

        goGoPowerRangers = Megazord.GetBool("DDR2Open");

        if (GameObject.Find("DDR2").GetComponent<DDR2Overlord>().DDR2Done)
        {
            Megazord.SetBool("DDR2Open", true);

        }
    }
}
