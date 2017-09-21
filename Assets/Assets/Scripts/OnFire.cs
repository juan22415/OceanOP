using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFire : MonoBehaviour {
    public GameObject firstState;
    public GameObject secondState;
    public GameObject finalState;

    public Light firstStateLight;
    public Light secondStateLight;
    public Light finalStateLight;
    public float duration = 1.0F;
    public int counterState;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
      
        
                if (collision.gameObject.CompareTag("bullet"))
                {
                    counterState++;
                    if(counterState==1)
                    {
                        firstState.SetActive(true);
                        float phi = Time.time / duration* 2 * Mathf.PI;
                        float amplitude = Mathf.Cos(phi) * 0.5F + 0.5F;
                        finalStateLight.intensity = amplitude;
            }
                    if (counterState == 2)
                    {
                        secondState.SetActive(true);
                    }
                    if (counterState == 3)
                    {
                        finalState.SetActive(true);
                    }
                }
        
    }
}
