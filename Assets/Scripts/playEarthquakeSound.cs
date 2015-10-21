using UnityEngine;
using System.Collections;

public class playEarthquakeSound : MonoBehaviour {

	public GameObject player;
	public float distanceReached;
	private float Distance;

	private bool played;

	private AudioSource earthquake;


	// Use this for initialization
	void Start () {

		AudioSource[] allMyAudioSources = GetComponents<AudioSource>();
		
		earthquake = allMyAudioSources[0];

		played = false;
	
	}
	
	// Update is called once per frame
	void Update () {

		Distance = Vector3.Distance (player.transform.position, this.transform.position);

		if (Distance < distanceReached && played == false)
		{
			earthquake.Play ();
			played = true;
			Debug.Log("Sound Play");
		}

	
	}
}
