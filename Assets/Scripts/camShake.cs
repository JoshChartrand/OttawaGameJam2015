using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class camShake : MonoBehaviour {

	// Transform of the camera to shake. Grabs the gameObject's transform
	// if null.
	public Transform camTransform;
	
	// How long the object should shake for.
	public float shake;
	
	// Amplitude of the shake. A larger value shakes the camera harder.
	public float shakeAmount;
	public float decreaseFactor;

	private float Distance;
	public GameObject collider;
	public float distanceReached;
	private bool played;
	private bool start;
	
	Vector3 originalPos;
	
	void Awake()
	{
		if (camTransform == null)
		{
			camTransform = GetComponent(typeof(Transform)) as Transform;
		}
	}
	
	void OnEnable()
	{
		played = false;
		start = false;
	}
	
	void Update()
	{

		originalPos = camTransform.localPosition;

		Distance = Vector3.Distance (collider.transform.position, this.transform.position);

		if (Distance < distanceReached && start == false) {
			start = true;
		}

		if (start && played == false)
		{

			if (shake > 0) {

				GetComponent<OVRPlayerController>().enabled = false;
				//GetComponent<FirstPersonController> ().enabled = false;
				
				camTransform.localPosition = originalPos + Random.insideUnitSphere * shakeAmount;
				
				shake -= Time.deltaTime * decreaseFactor;
			} else {
				shake = 0f;
				camTransform.localPosition = originalPos;
				played = true;

				//GetComponent<FirstPersonController> ().enabled = true;
				GetComponent<OVRPlayerController>().enabled = true;


			}
		} 
		else if (played == true) {
			GetComponent<FirstPersonController> ().enabled = true;
		}
	}
	
}

