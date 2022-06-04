using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.health = 100;
        Destroy(gameObject);
    }
}
