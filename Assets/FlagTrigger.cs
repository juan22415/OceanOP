using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagTrigger : MonoBehaviour {

    public activateFlag flagManager;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            flagManager.SelectNewFlag();
            gameObject.SetActive(false);
        }
    }
}
