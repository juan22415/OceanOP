using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimarkFollow : MonoBehaviour {

    [SerializeField] private GameObject Playertofollow;


	void Update () {

        gameObject.transform.position = new Vector3(Playertofollow.transform.position.x,
                                                    300,
                                                    Playertofollow.transform.position.z);

        Quaternion rotation=  new Quaternion(   0,
                                                Playertofollow.transform.localRotation.y,
                                                0,
                                                Playertofollow.transform.localRotation.w);

        gameObject.transform.localRotation = rotation;
	}
}
