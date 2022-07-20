using UnityEngine;

public class SmallCrystal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.crystal++;
        GameManager.instance.score += 10;
        SoundManager.instance.PlaySound(0);
        Destroy(gameObject);
    }
}