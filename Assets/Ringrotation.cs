using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ringrotation : MonoBehaviour {

    [SerializeField]
    int speed;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, speed * Time.deltaTime);
    }
}
