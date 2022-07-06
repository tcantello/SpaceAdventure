using UnityEngine;

public class FallingRock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D gameObject)
    {
        if (GameManager.instance.health > 0)
        {
            if (gameObject.CompareTag("Player"))
            {
                GameManager.instance.health -= 5;
            }
        }
    }
}