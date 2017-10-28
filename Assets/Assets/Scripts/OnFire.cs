using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFire : MonoBehaviour {
    public GameObject firstState;
    public GameObject secondState;
    public GameObject finalState;
    public GameObject explosionBarco;
    public AudioSource _audioSource;
    public BoatController control;
    public int counterState=-1;
    public Rigidbody rb;
    

    public Light firstStateLight;
    public Light secondStateLight;
    public Light finalStateLight;
    [SerializeField]
    private float duration = 1.0F;
    private float targetIntensity=4f;
    private x360_Gamepad gamepad;

    private void Start()
    {
        control = GetComponent<BoatController>();
        gamepad = GamepadManager.Instance.GetGamepad(control.controlNumber);
    }
    private void Update()
    {
        if (counterState == 0)
        {
            rb.useGravity = true;
            control.enabled = true;
            firstState.SetActive(false);
            secondState.SetActive(false);
            finalState.SetActive(false);

            if (control.controlNumber == 1)
            {
                GameManager.Instance.player1flag = 0;
            }
            if (control.controlNumber == 2)
            {
                GameManager.Instance.player2flag = 0;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {       
                if (collision.gameObject.CompareTag("bullet"))
                {
                    gamepad.AddRumble(1, new Vector2(0.8f, 0.8f), 2);
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
                    if(counterState == 4)
                    {
                    
                     GameObject explosion= Instantiate(explosionBarco,transform.position,transform.rotation);
                     Destroy(explosion, 2f);
                     StartCoroutine(Example());
                     rb.useGravity = false;
                     control.enabled = false;

                    if (control.controlNumber == 1)
                    {
                        GameManager.Instance.player1flag = 1;
                    }
                    if (control.controlNumber == 2)
                    {
                        GameManager.Instance.player2flag = 1;
                    }
                         counterState=0;
                    }
                
                }
        
    }

    IEnumerator Example()
    {
       
        yield return new WaitForSeconds(10);
    
    }
}
