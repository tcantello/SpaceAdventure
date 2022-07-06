using UnityEngine;

public class FirstAid : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.health = 100;
        Destroy(gameObject);
    }
}
