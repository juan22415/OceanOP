using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public int score;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Flag"))
        {
            score++;
            scoreText.text = score.ToString();
        }
    }
}
