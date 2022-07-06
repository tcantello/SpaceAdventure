using UnityEngine;

public class CaveCeilingDoorTrigger : MonoBehaviour
{
    public Animator CeilingDoorAnimator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.instance.keys == 0 || GameManager.instance.keys == 1)
        {
            CeilingDoorAnimator.SetInteger("numberKeyCarrying", 0);
        }
        else if (GameManager.instance.keys == 2)
        {
            CeilingDoorAnimator.SetInteger("numberKeyCarrying", 1);
            SoundManager.instance.PlaySound(2);
        }
    }
}
