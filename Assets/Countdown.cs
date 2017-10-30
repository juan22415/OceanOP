using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{

    public GameObject count;
    public AudioSource GetReady;
    public AudioSource GoAudio;
    public Rigidbody player1rigidbody;
    public Rigidbody player2rigidbody;


    void Start()
    {
        StartCoroutine(CountStart());
    }


    IEnumerator CountStart()
    {
        
        yield return new WaitForSeconds(1f);
        count.GetComponent<TextMeshProUGUI>().text = "3";
        GetReady.Play();
        count.SetActive(true);
        yield return new WaitForSeconds(1);
        count.SetActive(false);
        count.GetComponent<TextMeshProUGUI>().text = "2";
        GetReady.Play();
        count.SetActive(true);
        yield return new WaitForSeconds(1);
        count.SetActive(false);
        count.GetComponent<TextMeshProUGUI>().text = "1";
        GetReady.Play();
        count.SetActive(true);
        yield return new WaitForSeconds(1);
        count.SetActive(false);
        GoAudio.Play();
        player1rigidbody.isKinematic = false;
        player2rigidbody.isKinematic = false;


    }


}