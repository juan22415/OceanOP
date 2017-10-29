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
     

    }
}
