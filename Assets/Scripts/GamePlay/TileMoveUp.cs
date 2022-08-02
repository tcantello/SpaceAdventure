/*

Created by Toby Cantello
Created 8/2/22
Updated 8/2/22

*/

using UnityEngine;

public class TileMoveUp : MonoBehaviour
{
    public Animator animator;
    bool toggle = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        toggle = !toggle;
        animator.SetBool("switch", toggle);
    }
}
