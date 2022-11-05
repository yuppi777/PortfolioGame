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
            Action();
        }
    }

    void Action()
    {
        var pos = Camera.main.transform.position;
        pos.x += 48;
        pos.z += 48;

        Camera.main.transform.DOMove(pos,2);
        GameObject.FindGameObjectWithTag("Player").transform.position += new Vector3(37,0,37);
    }
}
