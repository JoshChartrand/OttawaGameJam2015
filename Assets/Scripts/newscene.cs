using UnityEngine;
using System.Collections;

public class newscene : MonoBehaviour {
	/*
	void OnTriggerEnter(Collider other) {
		Application.LoadLevel("Environment");
	}

	*/void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "Player") {
			Application.LoadLevel("Environment");
		}
	}

}
