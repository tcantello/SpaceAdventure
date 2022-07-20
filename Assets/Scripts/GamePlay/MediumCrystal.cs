using UnityEngine;

public class MediumCrystal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.crystal++;
        GameManager.instance.score += 15;
        SoundManager.instance.PlaySound(0);
        Destroy(gameObject);
    }
}