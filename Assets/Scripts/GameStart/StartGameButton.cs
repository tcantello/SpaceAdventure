using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class StartGameButton : MonoBehaviour
{
    public string sceneName;

    public void GoToNewScene()
    {
        SceneManager.LoadScene(sceneName);
    } 
}
