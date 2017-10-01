using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateFlag : MonoBehaviour {

    [SerializeField] private GameObject[] flags;
    public int activeFlag;


    private void Start()
    {
        activeFlag = Random.Range(0, 5);
        flags[activeFlag].SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
