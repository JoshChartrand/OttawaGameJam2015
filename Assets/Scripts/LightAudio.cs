using UnityEngine;
using System.Collections;

public class LightAudio : MonoBehaviour {

	private float amp;
	private float[] smooth = new float[2];

	// Use this for initialization
	void Start () {
		// initalising the filter
		for (int i = 0; i < 2; i++) {
			smooth [i] = 0.0f;	
		}
	}
	
	// Update is called once per frame
	void Update () {
		//intensity of light, controlled by the amplitude of the sound
		GetComponent<Light>().intensity = amp;
		GetComponent<Light>().range = amp;
	}

	void OnAudioFilterRead (float[] data, int channels)
	{		
		for (var i = 0; i < data.Length; i = i + channels) {
			// the absolute value of every sample
			float absInput = Mathf.Abs(data[i]);
			// smoothening filter doing its thing
			smooth[0] = ((0.02f * absInput) + (0.98f * smooth[1]));
			// exaggerating the amplitude
			amp = smooth[0]*25;
			// it is a recursive filter, so it is doing its recursive thing
			smooth[1] = smooth[0];
		}
	}
}
