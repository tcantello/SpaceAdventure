/*

Created by Toby Cantello
Created 7/18/22
Updated 7/28/22

*/

using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int lives = 3;
    public int health = 100;
    public int score = 0;
    public int crystal;
    public int boxes;


    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
