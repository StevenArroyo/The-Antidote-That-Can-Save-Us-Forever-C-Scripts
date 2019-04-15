using UnityEngine;
using System.Collections;

public class BreakingGlass: MonoBehaviour {

	void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Phys")
        {
            if(other.GetComponent<GravityGun>() == null)
            {
                GetComponent<Rigidbody>().isKinematic = false;
            }
        }
    }
}
