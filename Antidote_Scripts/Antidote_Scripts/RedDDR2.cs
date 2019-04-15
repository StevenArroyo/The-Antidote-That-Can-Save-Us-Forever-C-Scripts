using UnityEngine;
using System.Collections;

public class RedDDR2 : DDR2Overlord {

    public GameObject RedSignal;
    public GameObject RedLight;

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
            RedSignal.transform.localPosition = new Vector3(0.12f, 6.0f, 1.75f);
            RedLight.transform.localPosition = new Vector3(2.25f, 0.75f, 0.75f);

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            RedSignal.transform.localPosition = new Vector3(-0.13f, 6.0f, 1.75f);
            RedLight.transform.localPosition = new Vector3(2.25f, 0.25f, 0.75f);
        }
    }

    void OnTriggerStay(Collider col)
    {

    }
}
