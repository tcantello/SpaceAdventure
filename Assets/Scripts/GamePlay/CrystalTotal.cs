using UnityEngine;
using UnityEngine.UI;

public class CrystalTotal : MonoBehaviour
{
    public Text coin;

    // Update is called once per frame
    void Update()
    {
        coin.text = "Crystals: " + GameManager.instance.crystal;
    }
}
