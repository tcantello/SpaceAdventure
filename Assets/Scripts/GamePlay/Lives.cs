using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text lives;

    // Update is called once per frame
    void Update()
    {
        lives.text = "Lives: " + GameManager.instance.lives;
    }
}
