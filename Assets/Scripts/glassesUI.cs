using UnityEngine;
using System.Collections;

public class glassesUI : MonoBehaviour {

	public bool glassesOn;
	public bool buttonUp;

	public float distanceReached;
	private float Distance;

	public bool glassesPick;

	public GameObject glasses;
	public GameObject painting;
	public GameObject player;


	// Use this for initialization
	void Start () {

		glassesOn = false;
		buttonUp = true;
		glassesPick = false;
	
	}
	
	// Update is called once per frame
	void Update () {




		//change glasses alpha


		if (glassesPick == true) {
	
			if (buttonUp == true) {
				if (Input.GetButton ("Submit") && glassesOn == false) {
					glassesOn = true;
					buttonUp = false;
				} else if (Input.GetButton ("Submit") && glassesOn == true) {
					glassesOn = false;
					buttonUp = false;
				}
			}

			if (buttonUp == false) {
				if (Input.GetButton ("Submit")) {

				} else
					buttonUp = true;

			}



			if (glassesOn == false) {
				MeshRenderer MeshComponent = gameObject.GetComponent<MeshRenderer> ();
				GetComponent<Renderer> ().enabled = false;

				MeshRenderer MeshComponentPainting = painting.gameObject.GetComponent<MeshRenderer>();
				painting.gameObject.GetComponent<Renderer>().enabled = true;
				BoxCollider BoxComponentPainting =painting.gameObject.GetComponent<BoxCollider>();
				painting.gameObject.GetComponent<BoxCollider>().enabled = true;
			}
			if (glassesOn == true) {
				MeshRenderer MeshComponent = gameObject.GetComponent<MeshRenderer> ();
				GetComponent<Renderer> ().enabled = true;

				MeshRenderer MeshComponentPainting = painting.gameObject.GetComponent<MeshRenderer>();
				painting.gameObject.GetComponent<Renderer>().enabled = false;
				BoxCollider BoxComponentPainting = painting.gameObject.GetComponent<BoxCollider>();
				painting.gameObject.GetComponent<BoxCollider>().enabled = false;
			}
		} else if (glassesPick == false) {

		

			Distance = Vector3.Distance (glasses.transform.position, player.transform.position);

			if(Input.GetButton ("Submit2") && Distance < distanceReached){

				glassesPick = true;

				glassesOn = true;

				glasses.transform.position = new Vector3 (-1000.0f, -1000.0f, -1000.0f);


			}

		}
	
	
	}
}
