using UnityEngine;
using System.Collections;

public class ZiplineSystem : MonoBehaviour {

	private MessageSystem msg; 

	public string msgFrom;
	public string msgBody;
	public float msgTime;

	public ZiplineTrigger enter;
	public ZiplineTrigger exit;

	public GameObject ziplineCamera;
	private Animator zipAnim;
	private Vector3 startPos;

	private GameObject playerCamera;
	private Transform player;

	public Transform exitPos;

	private bool zip = false;

	// Use this for initialization
	void Start () {
		msg = GameObject.FindObjectOfType<MessageSystem> ();

		startPos = ziplineCamera.transform.position;

		zipAnim = ziplineCamera.GetComponent<Animator> ();

		ziplineCamera.SetActive (false);

		playerCamera = GameObject.FindWithTag ("MainCamera");

		player = GameObject.FindWithTag ("Player").transform;

	}

	// Update is called once per frame

	void OnTriggerEnter (Collider entity) {
		if (entity.tag == "Player") {
			print ("The Player has entered the Ladder Trigger!");
		}
	} 

	void OnTriggerStay (Collider entity)
	{
		if (entity.tag == "Player") {

			if (enter.isPlayerHere == true) {
				if (Input.GetKeyDown (KeyCode.E)) {
					zip = true;
				}


				if (zip != true) {
					msg.NewMessage (msgFrom, msgBody, msgTime);
				}
			}


			if (zip == true) {
				if (playerCamera.activeSelf != false) {
					playerCamera.SetActive (false);
					ziplineCamera.SetActive (true);
				}



				if (Input.GetKey (KeyCode.W)) {
					ziplineCamera.transform.parent.transform.Translate (Vector3.up * Time.deltaTime);
					zipAnim.speed = 2;
				} else {
					zipAnim.speed = 0; 
				}


				if (exit.isPlayerHere == true) {
					player.position = exitPos.position;
					playerCamera.transform.position = exitPos.position;

					if (playerCamera.activeSelf != true) {
						ziplineCamera.transform.parent.transform.position = startPos;
						playerCamera.SetActive (true);
						ziplineCamera.SetActive (false);
						enter.isPlayerHere = false;
						exit.isPlayerHere = false;
					}

					zip = false;
				}
			}
		}
	}
}
