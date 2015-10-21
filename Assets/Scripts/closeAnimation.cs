using UnityEngine;
using System.Collections;



public class closeAnimation : MonoBehaviour {
	
	
	//public AnimationClip clipname;
	private float Distance;
	public GameObject player;
	public float distanceReached;
	private bool played;

	
	// Use this for initialization
	void Start () {

		played = false;

		
	}
	
	// Update is called once per frame
	void Update () {
		
		Distance = Vector3.Distance (player.transform.position, this.transform.position);
		if ((Distance < distanceReached) && played == false) {

			GetComponent<Animation>().Play();
			played = true;
		}
		
	}
}