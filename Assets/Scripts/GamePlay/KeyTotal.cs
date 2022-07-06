using UnityEngine;
using UnityEngine.UI;

public class KeyTotal : MonoBehaviour
{
    public Text keysTotal;

    // Update is called once per frame
    void Update()
    {
        keysTotal.text = "Keys: " + GameManager.instance.keys;
    }
}
