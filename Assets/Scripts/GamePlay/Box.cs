/*

Created by Toby Cantello
Created 7/28/22
Updated 7/28/22

*/

using UnityEngine;

public class Box : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.instance.score += 100;
            GameManager.instance.boxes++;
            SoundManager.instance.PlaySound(0);
            Destroy(gameObject);
        } 
    }
}
