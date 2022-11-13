using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : BasePlayer
{
    BaseCollider Base;
    bool StayState = false;
    bool ExitState = false;

    protected override void OnInitialize()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        var basecol = other.gameObject.GetComponent<BaseCollider>();
        Base = basecol;
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
