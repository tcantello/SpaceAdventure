/*

Created by Toby Cantello
Created  
Updated 7/28/22

*/

using UnityEngine;
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
        GameManager.instance.boxes = 0;
    }
}
