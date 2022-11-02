using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungionGate : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Action();
        }
    }

    void Action()
    {
        
    }
}
