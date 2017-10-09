using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateFlag : MonoBehaviour {

    [SerializeField] private GameObject[] flags;
    public int activeFlag;
    public int[] previosFlags;
    public int timesExecuted=0;


    private void Start()
    {
        SelectNewFlag();

       // Debug.Log(previosFlags[4]);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void ActivateNewFlag(int flag, int currentActive)
    {
        flags[flag].SetActive(true);
        previosFlags[currentActive] = activeFlag;
        timesExecuted++;
    }

    public void SelectNewFlag ()
    {
        if(timesExecuted == 0)
        {
            activeFlag = Random.Range(0, 5);
            ActivateNewFlag(activeFlag, 0);
        }

        else if (timesExecuted == 1)
        {
            activeFlag = Random.Range(0, 5);

            if (activeFlag == previosFlags[0])
            {
                SelectNewFlag();
            }
            else
            {
                ActivateNewFlag(activeFlag, 1);
            }
        }

        else if (timesExecuted == 2)
        {
            activeFlag = Random.Range(0, 5);

            if (activeFlag == previosFlags[0] || 
                activeFlag == previosFlags[1])
            {
                SelectNewFlag();
            }
            else
            {
                ActivateNewFlag(activeFlag, 2);
            }
        }

        else if (timesExecuted == 3)
        {
            activeFlag = Random.Range(0, 5);

            if (activeFlag == previosFlags[0] ||
                activeFlag == previosFlags[1] ||
                activeFlag == previosFlags[2])
            {
                SelectNewFlag();
            }
            else
            {
                ActivateNewFlag(activeFlag, 3);
            }
        }

        else
        {
            activeFlag = Random.Range(0, 5);

            if (activeFlag == previosFlags[0] ||
                activeFlag == previosFlags[1] ||
                activeFlag == previosFlags[2] ||
                activeFlag == previosFlags[3])
            {
                SelectNewFlag();
            }
            else
            {
                ActivateNewFlag(activeFlag, 4);
            }
        }


    }
}
