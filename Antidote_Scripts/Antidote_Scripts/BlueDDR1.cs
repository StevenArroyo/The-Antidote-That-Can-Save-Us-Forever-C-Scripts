using UnityEngine;
using System.Collections;

public class BlueDDR1 : DDR1Overlord {

    public GameObject BlueSignal;
    public GameObject BlueLight;

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
            BlueSignal.transform.localPosition = new Vector3(-2.88f, 2.5f, 1.75f);
            BlueLight.transform.localPosition = new Vector3(0.7f, 0.5f, 0.75f);

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            BlueSignal.transform.localPosition = new Vector3(-3.13f, 2.5f, 1.75f);
            BlueLight.transform.localPosition = new Vector3(0.7f, 0.25f, 0.75f);
        }
    }

    void OnTriggerStay(Collider col)
    {

    }

}
