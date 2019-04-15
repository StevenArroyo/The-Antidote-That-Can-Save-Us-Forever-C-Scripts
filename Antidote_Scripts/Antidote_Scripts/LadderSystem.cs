using UnityEngine;
using System.Collections;

public class LadderSystem : MonoBehaviour {

	private MessageSystem msg; 

	public string msgFrom;
	public string msgBody;
	public float msgTime;

	public LadderTrigger enter;
	public LadderTrigger exit;

	public GameObject ladderCamera;
	private Animator climbAnim;
	private Vector3 startPos;

	private GameObject playerCamera;
	private Transform player;

	public Transform exitPos;

	private bool climb = false;

	// Use this for initialization
	void Start () {
		msg = GameObject.FindObjectOfType<MessageSystem> ();

		startPos = ladderCamera.transform.position;

		climbAnim = ladderCamera.GetComponent<Animator> ();

		ladderCamera.SetActive (false);

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
					climb = true;
				}
		

				if (climb != true) {
					msg.NewMessage (msgFrom, msgBody, msgTime);
				}
			}
		

			if (climb == true) {
				if (playerCamera.activeSelf != false) {
					playerCamera.SetActive (false);
					ladderCamera.SetActive (true);
				}

		

				if (Input.GetKey (KeyCode.W)) {
					ladderCamera.transform.parent.transform.Translate (Vector3.up * Time.deltaTime);
					climbAnim.speed = 1;
				} else {
					climbAnim.speed = 0; 
				}
		

				if (exit.isPlayerHere == true) {
					player.position = exitPos.position;
					playerCamera.transform.position = exitPos.position;

					if (playerCamera.activeSelf != true) {
						ladderCamera.transform.parent.transform.position = startPos;
						playerCamera.SetActive (true);
						ladderCamera.SetActive (false);
						enter.isPlayerHere = false;
						exit.isPlayerHere = false;
					}

					climb = false;
				}
			}
		}
	}
}
