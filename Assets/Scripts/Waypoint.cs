using UnityEngine;
using System.Collections;

public class Waypoint : MonoBehaviour {

	void OnTriggerEnter(Collider hit){
		if (hit.CompareTag ("Enemy")) {
			hit.GetComponent<AI>().NextWaypoint();
				}
	}
}
