using UnityEngine;
using System.Collections;

public class YellowDDR1 : DDR1Overlord {

    public GameObject YellowSignal;
    public GameObject YellowLight;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            //        RedSignal.transform.position = new Vector3(-14.88f, -16.25f, 66.5f);
            YellowSignal.transform.localPosition = new Vector3(-2.88f, 2.5f, -0.25f);
            YellowLight.transform.localPosition = new Vector3(2.25f, 0.75f, 2.25f);

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            YellowSignal.transform.localPosition = new Vector3(-3.13f, 2.5f, -0.25f);
            YellowLight.transform.localPosition = new Vector3(2.25f, 0.25f, 2.25f);
        }
    }

    void OnTriggerStay(Collider col)
    {

    }


}
