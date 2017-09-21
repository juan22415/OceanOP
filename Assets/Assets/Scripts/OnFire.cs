using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFire : MonoBehaviour {
    public GameObject firstState;
    public GameObject secondState;
    public GameObject finalState;
    public AudioSource _audioSource;
    public int counterState;

    public Light firstStateLight;
    public Light secondStateLight;
    public Light finalStateLight;
    [SerializeField]
    private float duration = 1.0F;
    private float targetIntensity=4f;

    private void OnCollisionEnter(Collision collision)
    {
      
        
                if (collision.gameObject.CompareTag("bullet"))
                {
                    counterState++;
                    if(counterState==1)
                    {
                        firstState.SetActive(true);
                        firstStateLight.intensity = Mathf.PingPong(Time.time, targetIntensity);
                        _audioSource.volume = 0.3f;
            }
                    if (counterState == 2)
                    {
                        secondState.SetActive(true);
                        secondStateLight.intensity = Mathf.PingPong(Time.time, targetIntensity);
                        _audioSource.volume = 0.7f;
            }
                    if (counterState == 3)
                    {
                        finalState.SetActive(true);
                        finalStateLight.intensity = Mathf.PingPong(Time.time, targetIntensity);
                        _audioSource.volume = 1;
            }
                }
        
    }
}
