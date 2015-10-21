using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {

	private float objXPos;
	private float objYPos;
	private float objZPos;

	private float xLimite;

	public float xMove;


	// Use this for initialization
	void Start () {
		objXPos = this.transform.position.x;
		objYPos = this.transform.position.y;
		objZPos = this.transform.position.z;

		xLimite = objXPos - 7;
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position =  new Vector3 (objXPos, objYPos, objZPos);

		if (objXPos > xLimite) {
			objXPos = objXPos - xMove;
		}
	
	}
}
