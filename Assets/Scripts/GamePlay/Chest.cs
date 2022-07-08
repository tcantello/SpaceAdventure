using UnityEngine;


public class Chest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.instance.score += 50;
            SoundManager.instance.PlaySound(0);
            Destroy(gameObject);
        } 
    }
}
