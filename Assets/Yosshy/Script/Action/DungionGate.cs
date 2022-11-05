using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DungionGate : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
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
        GameObject.FindGameObjectWithTag("Player").transform.position += new Vector3(35,0,35);
    }
}
