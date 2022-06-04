using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyTotal : MonoBehaviour
{
    public Text keysTotal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        keysTotal.text = "Keys: " + GameManager.instance.keys;
    }
}
