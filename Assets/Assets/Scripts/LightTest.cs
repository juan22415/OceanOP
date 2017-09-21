using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTest : MonoBehaviour {
    public Light firstStateLight;

    private float targetIntensity = 6f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        firstStateLight.intensity = Mathf.PingPong(Time.time, targetIntensity);
    }
}
