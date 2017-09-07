using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotation : MonoBehaviour {

    [SerializeField]
    private GameObject Scope;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(Scope.transform.position);
	}
}
