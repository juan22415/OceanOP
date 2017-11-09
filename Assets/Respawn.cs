using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    [SerializeField] private GameObject startingPos;
    [SerializeField] private GameObject blackscreen;

	// Update is called once per frame
	void Update () {
		
	}

    public void PrepareRespawn()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        blackscreen.SetActive(true);
        transform.position = startingPos.transform.position;
        transform.rotation = startingPos.transform.rotation;
        StartCoroutine(RespawningTimer());

    }

    public void Respawning()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        blackscreen.SetActive(false);
    }

    IEnumerator RespawningTimer()
    {

        yield return new WaitForSeconds(5);
        Respawning();

    }
}
