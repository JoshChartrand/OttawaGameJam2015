using UnityEngine;
using System.Collections;

public class paintingVanish : MonoBehaviour {
	
	public bool glassesOn;
	public bool buttonUp;

	// Use this for initialization
	void Start () {

		glassesOn = false;
		buttonUp = true;
	
	
	}
	
	// Update is called once per frame
	void Update () {



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
			if (Input.GetButton ("Submit")){
				
			}
			else
				buttonUp = true;
		}
		
		
		
		if (glassesOn == true) {

		}
		if (glassesOn == false) {
			MeshRenderer MeshComponent = gameObject.GetComponent<MeshRenderer>();
			GetComponent<Renderer>().enabled = true;
			BoxCollider BoxComponent = gameObject.GetComponent<BoxCollider>();
			GetComponent<BoxCollider>().enabled = true;
		}
	
	}
}
