using UnityEngine;
using System.Collections;

public class YellowDDR2 : DDR2Overlord {

    public GameObject YellowSignal;
    public GameObject YellowLight;


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
            YellowSignal.transform.localPosition = new Vector3(0.12f, 6.0f, -0.25f);
            YellowLight.transform.localPosition = new Vector3(2.25f, 0.75f, 2.25f);

        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
        {
            YellowSignal.transform.localPosition = new Vector3(-0.13f, 6.0f, -0.25f);
            YellowLight.transform.localPosition = new Vector3(2.25f, 0.25f, 2.25f);
        }
    }

    void OnTriggerStay(Collider col)
    {

    }

}
