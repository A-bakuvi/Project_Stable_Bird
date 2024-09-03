using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // we have to use this for scene stuff

public class Button : MonoBehaviour
{

    //if we want to upload scene using index --> SceneManager.LoadScene(index);
    //if we want to upload scene using the levels name --> SceneManager.LoadScene(levelename);
    //if we want to restart scene --> SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    public void ResetScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
