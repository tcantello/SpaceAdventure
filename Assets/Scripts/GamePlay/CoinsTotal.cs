using UnityEngine;
using UnityEngine.UI;

public class CoinsTotal : MonoBehaviour
{
    public Text coin;

    // Update is called once per frame
    void Update()
    {
        coin.text = "Coins: " + GameManager.instance.coins;
    }
}
