using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int lives = 3;
    public int health = 100;
    public int score = 0;
    public int coins;
    public int keys;


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
