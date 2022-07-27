using UnityEngine;


public class Box : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.instance.score += 100;
            SoundManager.instance.PlaySound(0);
            Destroy(gameObject);
        } 
    }
}
