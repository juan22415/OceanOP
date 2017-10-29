using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampImpulse : MonoBehaviour {

    [SerializeField]
    int force;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

            other.gameObject.GetComponent<Rigidbody>().AddForce(other.gameObject.transform.forward * force);
    }
}
