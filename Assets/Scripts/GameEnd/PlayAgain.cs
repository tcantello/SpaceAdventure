using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public string sceneName;

    public void GoToNewScene()
    {
        SceneManager.LoadScene(sceneName);
        GameManager.instance.lives = 3;
        GameManager.instance.health = 100;
        GameManager.instance.score = 0;
        GameManager.instance.crystal = 0;
        GameManager.instance.keys = 0;
    }
}
