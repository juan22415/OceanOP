using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateExplosion : MonoBehaviour {

    [SerializeField] GameObject explosion;
    Rigidbody _rigidbody;
    // Use this for initialization
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        explosion.SetActive(true);
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
        _rigidbody.freezeRotation = true;

    }
}
