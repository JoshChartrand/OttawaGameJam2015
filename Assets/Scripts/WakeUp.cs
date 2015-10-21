using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class WakeUp : MonoBehaviour {
	
	public float timer;
	public float timer2;
	private AudioSource wakeUp;
	private bool timer1done;
	private bool timer2done;
	private bool soundplayed;

	public GameObject player;

	public GameObject door;

	// Use this for initialization
	void Start () {
		AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
		
		wakeUp = allMyAudioSources[1];
		timer1done = false;
		timer2done = false;
		soundplayed = false;

		player.GetComponent<OVRPlayerController>().enabled = false;
		//player.GetComponent<FirstPersonController> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (timer > 1) {
			timer -= Time.deltaTime;



		} else if (timer <= 1 && soundplayed == false) {
			wakeUp.Play ();
			soundplayed = true;
		} else if (timer2 > 1 && timer2done == false) {
			timer2 -= Time.deltaTime;
		} else {

			player.GetComponent<OVRPlayerController>().enabled = true;
			//player.GetComponent<FirstPersonController> ().enabled = true;

			GetComponent<WakeUp>().enabled = false;
			GetComponent<AI>().enabled = true;
			door.GetComponent<openDoor>().enabled = true;

		}
			
	}

}

