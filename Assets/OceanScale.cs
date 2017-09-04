using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanScale : MonoBehaviour {

    [SerializeField]
    private float scale;
	// Use this for initialization
	void Start () {
        //transform.localScale *= scale;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.localScale.x!=scale)
            transform.localScale = new Vector3(scale, scale, scale);
	}
}
