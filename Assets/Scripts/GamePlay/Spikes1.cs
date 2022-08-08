/*

Created by Toby Cantello
Created 8/8/22
Updated 8/8/22

*/

using UnityEngine;

public class Spikes1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.instance.health > 0)
        {
            if (collision.tag == "Player")
            {
                GameManager.instance.health = GameManager.instance.health - 5;
            }
        }
    }
}