using UnityEngine;
using System.Collections;

public class aniOpenSpeed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Animation>()["openGlass"].speed = 0.5f;
	
	}
}
