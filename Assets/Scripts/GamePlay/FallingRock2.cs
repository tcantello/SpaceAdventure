using UnityEngine;

public class FallingRock2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.instance.health > 0)
        {
            if (collision.tag == "Player")
            {
                GameManager.instance.health = GameManager.instance.health - 5;
                Destroy(gameObject);
            }
        }
    }
}