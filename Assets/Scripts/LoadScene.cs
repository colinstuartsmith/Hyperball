using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    // Allows us to specify which scene to load.
    public string SceneToLoad = "";

    // Allows us to specify a delay before we load the scene.
    public float Delay = 0;

    // This Unity method is called once after the Awake method and before the game loop starts.
    void Start()
    {
        // Start the coroutine which is used to implement the delay and then load the scene.
        StartCoroutine(delayThenLoadScene());
    }

    // This coroutine implements a delay and then loads the scene.
    IEnumerator delayThenLoadScene()
    {
        // Implement the specified delay.
        yield return new WaitForSeconds(Delay);

        // Load the scene.
        SceneManager.LoadScene(SceneToLoad);
    }
}