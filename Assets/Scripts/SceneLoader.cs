using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private static int StartSceneIndex = 0;
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex+1);
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene((StartSceneIndex));

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
