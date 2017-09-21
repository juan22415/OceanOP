using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateExplosion : MonoBehaviour {

    private bool lightFading;
    [SerializeField] GameObject explosion;
    Rigidbody _rigidbody;
    [SerializeField] AudioClip explosionSound;

    AudioSource _audioSource;


    // Use this for initialization
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
        
    }

    private void Update()
    {
        if (lightFading==true)
        {
            explosion.GetComponent<Light>().intensity -= 0.1f;
            _audioSource.volume -= 0.01f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<CapsuleCollider>().enabled = false;
        explosion.SetActive(true);
        _rigidbody.velocity = Vector3.zero;
        _rigidbody.angularVelocity = Vector3.zero;
        _rigidbody.freezeRotation = true;
        _audioSource.clip = explosionSound;
        _audioSource.Play();
        GetComponent<CapsuleCollider>().enabled = false;
        lightFading = true;
        Destroy(gameObject, 3);
    }

}
