using UnityEngine;
using System.Collections;

public class BridgeBreak : MonoBehaviour {

    private bool breakIt;

    private Animator bridgeBreak;

    public GameObject Bridge;


	// Use this for initialization
	void Start () {
       bridgeBreak = Bridge.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {
        breakIt = bridgeBreak.GetBool("Break");

    }

    void OnTriggerExit (Collider entity)
    {
        if (entity.tag == "Player")
        {
            bridgeBreak.SetBool("Break", true);
        }
    }
}
