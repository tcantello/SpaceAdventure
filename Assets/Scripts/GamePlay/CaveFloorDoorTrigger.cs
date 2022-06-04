using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveFloorDoorTrigger : MonoBehaviour
{
    public Animator doorAnimator;
    public int hasKey = GameManager.instance.keys;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (hasKey == 0)
        {
            doorAnimator.GetInteger(hasKey);
        }
        else if (hasKey == 1)
        {
            doorAnimator.GetInteger(hasKey);
        }
        else
        {
            doorAnimator.GetInteger(hasKey);
        }
    }
}
