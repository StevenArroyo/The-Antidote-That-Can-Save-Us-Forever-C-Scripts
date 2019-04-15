using UnityEngine;
using System.Collections;

public class BlueDDR2 : DDR2Overlord {

    public GameObject BlueSignal;
    public GameObject BlueLight;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && GameObject.Find("TileCollector").GetComponent<TileCollector>().AllCollected)
        {
            //        RedSignal.transform.position = new Vector3(-14.88f, -16.25f, 66.5f);
            BlueSignal.transform.localPosition = new Vector3(0.12f, 6.0f, 0.75f);
            BlueLight.transform.localPosition = new Vector3(0.7f, 0.75f, 0.75f);

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            BlueSignal.transform.localPosition = new Vector3(-0.13f, 6.0f, 0.75f);
            BlueLight.transform.localPosition = new Vector3(0.7f, 0.25f, 0.75f);
        }
    }

    void OnTriggerStay(Collider col)
    {

    }
}
