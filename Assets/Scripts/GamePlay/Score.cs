using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
       score.text = "Score:  " + GameManager.instance.score;
    }

}
