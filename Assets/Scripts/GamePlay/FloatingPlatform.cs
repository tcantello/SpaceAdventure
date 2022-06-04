using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloatingPlatform : MonoBehaviour
{ 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
