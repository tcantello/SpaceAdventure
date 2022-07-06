using UnityEngine;

public class Chest : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.score += 50;
        SoundManager.instance.PlaySound(0);
        Destroy(gameObject);
    }
}
