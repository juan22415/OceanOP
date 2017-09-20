using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampImpulse : MonoBehaviour {



    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))

            collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.gameObject.transform.forward * 3,ForceMode.Impulse);

    }
}
