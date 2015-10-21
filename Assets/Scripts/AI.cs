using UnityEngine;
using System.Collections;
using BreadcrumbAi;

public class AI : MonoBehaviour {

	public GameObject[] waypoints;
	public int _activeWaypoint = 0;
	private Vector3 target;

	private GameObject waypoint;

	Ai ai;

	public float speed = 0.04f;

	// Use this for initialization
	void Start () {
		LookForFirst();
		ai = GetComponent<Ai>();

		waypoint = GameObject.Find("Waypoint 2");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards (transform.position, target, speed);
	}

	void LookForFirst(){
		target = waypoints[_activeWaypoint].transform.position;
		transform.LookAt(target);
	}

	public void NextWaypoint(){
		_activeWaypoint ++;
		if (_activeWaypoint >= waypoints.Length) {
			this.GetComponent<AI>().enabled = false;
			waypoint.GetComponent<Waypoint>().enabled = false;
			ai.enabled = true;


		}

		Debug.Log ("Hit");

			//_activeWaypoint = waypoints.Length;
		LookForFirst();
	}
}


/*
 * Ai ai;
//
// 	void Start()
//	{
//		ai = GetComponent<Ai>();
//	}
//
//	void Update()
//	{
//		if(ai.moveState == Ai.MOVEMENT_STATE.IsFollowingPlayer)
//		{
//			//Animation
//		}
//	}*/