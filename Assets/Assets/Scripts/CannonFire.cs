using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour {


    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletOrigin;
    [SerializeField] private float bulletForce;
    [SerializeField] private int controlNumber;
    [SerializeField] AudioClip shootSound;
    private x360_Gamepad gamepad;
    AudioSource _audioSource;

    // Use this for initialization
    void Start () {

        gamepad = GamepadManager.Instance.GetGamepad(controlNumber);
        _audioSource = GetComponent<AudioSource>();
      


    }
	
	// Update is called once per frame
	void Update () {
        

        if (gamepad.GetButtonDown("LB"))
        {
            Shoot();
           
        }
    }

    public void Shoot()
    {
        GameObject bull = Instantiate(bullet, bulletOrigin.position,bulletOrigin.transform.rotation);
        bull.GetComponent<Rigidbody>().velocity = bulletOrigin.forward * bulletForce;
        _audioSource.clip = shootSound;
        _audioSource.Play();
    }

}
