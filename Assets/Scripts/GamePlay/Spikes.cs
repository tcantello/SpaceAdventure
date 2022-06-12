using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    private PlayerController player;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GoToNewScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.instance.lives > 0)
        {
            if (collision.CompareTag("Player"))
            {
                GameManager.instance.lives--;
                SoundManager.instance.PlaySound(3);
                player.transform.position = player.respawnPoint;
            }
        }
        else if (GameManager.instance.lives == 0)
        {
            GoToNewScene();
        }
    }
}