using UnityEngine;

public class LargeCrystal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.crystal++;
        GameManager.instance.score += 25;
        SoundManager.instance.PlaySound(0);
        Destroy(gameObject);
    }
}