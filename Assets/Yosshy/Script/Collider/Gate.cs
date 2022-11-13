using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : BaseCollider
{
    protected override void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.Space))Debug.Log("TOUCH");
    }
}
