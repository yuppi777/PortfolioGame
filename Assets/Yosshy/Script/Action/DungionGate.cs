using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DungionGate : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Action(48,48);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Action(-48,-48);
        }
    }

    void Action(float x,float z)
    {
        var pos = Camera.main.transform.position;
        pos.x += x;
        pos.z += z;
        Camera.main.transform.DOMove(pos,2);
    }
}
