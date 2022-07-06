using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.coins++;
        SoundManager.instance.PlaySound(0);
        Destroy(gameObject);
    }
}