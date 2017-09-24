using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampRotation : MonoBehaviour {

    public float xrotation;

	void Update () {

        xrotation = transform.localRotation.eulerAngles.x;

        if (transform.localRotation.eulerAngles.x > 0 && transform.localRotation.eulerAngles.x < 5)

            FixXrotations(0, 5, transform.localRotation.eulerAngles);
        
        if (transform.localRotation.eulerAngles.x > 345 && transform.localRotation.eulerAngles.x < 360)
        
            FixXrotations(345, 360, transform.localRotation.eulerAngles);


        if (transform.localRotation.eulerAngles.y > 180)
            FixYrotations(180, 220, transform.localRotation.eulerAngles);
        if (transform.localRotation.eulerAngles.y < 180)
            FixYrotations(140, 180, transform.localRotation.eulerAngles);
    }
    void FixYrotations(float min, float max,Vector3 currentRotation)
    {

            currentRotation.y = Mathf.Clamp(currentRotation.y, min, max);
            transform.localRotation = Quaternion.Euler(currentRotation);
    }

    void FixXrotations(float min, float max, Vector3 currentRotation)
    {

        currentRotation.x = Mathf.Clamp(currentRotation.x, min, max);
        transform.localRotation = Quaternion.Euler(currentRotation);
    }
}
