using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnFire : MonoBehaviour {
    public GameObject firstState;
    public GameObject secondState;
    public GameObject finalState;
    public int counterState;
    private bool isColliding;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        isColliding = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (isColliding) return;
        {
            isColliding = true;
        
                if (collision.gameObject.CompareTag("bullet"))
                {
                    counterState++;
                    if(counterState==1)
                    {
                        firstState.SetActive(true);
                    }
                    if (counterState == 2)
                    {
                        secondState.SetActive(true);
                    }
                    if (counterState == 3)
                    {
                        finalState.SetActive(true);
                    }
                }
        }
    }
}
