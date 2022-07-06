using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text health;

    // Update is called once per frame
    void Update()
    {
        health.text = "Health: " + GameManager.instance.health;
    }
}
