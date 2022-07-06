using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;

    // Update is called once per frame
    public void Update()
    {
       score.text = "Score:  " + GameManager.instance.score;
    }

}
