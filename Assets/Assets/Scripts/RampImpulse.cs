using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampImpulse : MonoBehaviour {

    [SerializeField]
    int force;
    public AudioSource a_Source;

    public void Start()
    {
        a_Source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

            a_Source.Play();
            other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.forward * force);
    }
}
