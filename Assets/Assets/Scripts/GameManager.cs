using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject player1;
    public GameObject player2;

    public static GameManager Instance { get; private set; }

    public float player1flag;
    public float player2flag;

    void Awake()
    {
         if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        if(player1flag==1)
        {
            player1.SetActive(false);
        }
        if (player2flag == 1)
        {
            player2.SetActive(false);
        }
        if (player1flag == 0)
        {
            player1.SetActive(true);
        }
        if (player2flag == 0)
        {
            player2.SetActive(true);
        }

    }
}
