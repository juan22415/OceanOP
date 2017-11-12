using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class asyncload : MonoBehaviour {

    public int sceneToLoad;
    public float waitTime;

	// Use this for initialization
	void Start () {
        StartCoroutine(LoadNewScene());
    }

    

    IEnumerator LoadNewScene()
    {

        // This line waits for 3 seconds before executing the next line in the coroutine.
        // This line is only necessary for this demo. The scenes are so simple that they load too fast to read the "Loading..." text.
        yield return new WaitForSeconds(waitTime);

        // Start an asynchronous operation to load the scene that was passed to the LoadNewScene coroutine.
        AsyncOperation async = SceneManager.LoadSceneAsync(sceneToLoad);

        // While the asynchronous operation to load the new scene is not yet complete, continue waiting until it's done.
        while (!async.isDone)
        {
            yield return null;
        }

    }
}
