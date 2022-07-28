/*

Created by Toby Cantello
Created 7/28/22
Updated 7/28/22

*/
using UnityEngine;
using UnityEngine.UI;

public class BoxTotal : MonoBehaviour
{
    public Text boxTotal;

    // Update is called once per frame
    void Update()
    {
        boxTotal.text = "Boxes: " + GameManager.instance.boxes;
    }
}
