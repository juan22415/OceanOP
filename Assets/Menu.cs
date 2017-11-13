using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Menu : MonoBehaviour {
    public int sceneToLoad;

    public void onClick()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
