using UnityEngine;
using System.Collections;

public class Randmove : MonoBehaviour {

	private float xPosition;
	private float yPosition;
	private float objXPos;
	private float objYPos;
	private float objZPos;

	private float xPosLimite;
	private float yPosLimite;
	private float xNegLimite;
	private float yNegLimite;


	public float speed;
	public float xSetLimite;
	public float ySetLimite;


	private float maxSpeed;
	private float minSpeed;


	private float xPositionAdd;
	private float yPositionAdd;

	// Use this for initialization
	void Start () {
	
		objXPos = this.transform.position.x;
		objYPos = this.transform.position.y;

		xPosLimite = objXPos + xSetLimite;
		yPosLimite = objYPos + ySetLimite;
		xNegLimite = objXPos - xSetLimite;
		yNegLimite = objYPos - ySetLimite;

		minSpeed = speed * -1;
		maxSpeed = speed;

		xPositionAdd = Random.Range(minSpeed, maxSpeed) * 1f;
		yPositionAdd = Random.Range(minSpeed, maxSpeed) * 1f;

		if (xPositionAdd == 0 && yPositionAdd == 0) {
			xPositionAdd = Random.Range(-1, 1) * 1f;
			yPositionAdd = Random.Range(-1, 1) * 1f;

			do{
				xPositionAdd = Random.Range(minSpeed, maxSpeed) * 1f;
				yPositionAdd = Random.Range(minSpeed, maxSpeed) * 1f;

			}while(xPositionAdd == 0 && yPositionAdd == 0);
		}

	}
	
	// Update is called once per frame
	void Update () {


		objZPos = this.transform.position.z;


		objXPos = objXPos + xPositionAdd;
		objYPos = objYPos + yPositionAdd;

		if (objXPos > xPosLimite) {
			xPositionAdd = xPositionAdd *-1;

			if (yPositionAdd < 0)
				yPositionAdd = 0;
			else if (yPositionAdd == 0)
				yPositionAdd = maxSpeed;
			else
				yPositionAdd = minSpeed;
		}
		if (objYPos > yPosLimite) {
			yPositionAdd = yPositionAdd *-1;

			if (xPositionAdd < 0)
				xPositionAdd = 0;
			else if (xPositionAdd == 0)
				xPositionAdd = maxSpeed;
			else
				xPositionAdd = minSpeed;
		}
		if (objXPos < xNegLimite) {
			xPositionAdd = xPositionAdd *-1;

			if (yPositionAdd < 0)
				yPositionAdd = 0;
			else if (yPositionAdd == 0)
				yPositionAdd = maxSpeed;
			else
				yPositionAdd = minSpeed;

		}
		if (objYPos < yNegLimite) {
			yPositionAdd = yPositionAdd *-1;

			if (xPositionAdd < 0)
				xPositionAdd = 0;
			else if (xPositionAdd == 0)
				xPositionAdd = maxSpeed;
			else
				xPositionAdd = minSpeed;
		}

		transform.position =  new Vector3 (objXPos, objZPos, objYPos);
	
	}
}
