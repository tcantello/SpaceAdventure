using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveFloorDoorTrigger : MonoBehaviour
{
    public Animator FloorDoorAnimator;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (GameManager.instance.keys == 0)
        {
            FloorDoorAnimator.SetInteger("numberKeyCarrying", 0);
        }
        else if (GameManager.instance.keys == 1)
        {
            FloorDoorAnimator.SetInteger("numberKeyCarrying", 1);
            SoundManager.instance.PlaySound(2);
        }
    }
}
