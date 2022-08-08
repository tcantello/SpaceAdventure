/*

Created by Toby Cantello
Created 8/8/22
Updated 8/8/22

*/

using UnityEngine;
using UnityEngine.SceneManagement;

public class Lever : MonoBehaviour
{
    public string sceneName;

    public void GoToNewScene()
    {
        SceneManager.LoadScene(sceneName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GoToNewScene();
    }
}