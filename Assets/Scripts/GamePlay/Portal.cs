using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private Transform destination;

    public bool isPortalEntry;
    public float distance = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        if (isPortalEntry == false)
        {
            destination = GameObject.FindGameObjectWithTag("Portal Entry").GetComponent<Transform>();
        }
        else
        {
            destination = GameObject.FindGameObjectWithTag("Portal Exit").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (Vector2.Distance(transform.position, other.transform.position) > distance)
        {
            other.transform.position = new Vector2(destination.position.x, destination.position.y);
        }
    }
}
