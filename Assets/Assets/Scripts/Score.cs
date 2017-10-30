using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public Image colorimagen;
    //public Text scoreText;
    public Text winnerText;

    public int score;


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Flag"))
        {
            score++;
            colorimagen.fillAmount += 0.33f;
            //scoreText.text = score.ToString();
            CheckWinner(score);
        }
    }

    public void CheckWinner(int currentFlags)
    {
        if (currentFlags == 3)
        {
            winnerText.gameObject.SetActive(true);
            Debug.Log("winer");
            StartCoroutine(Timer());

        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }
}
