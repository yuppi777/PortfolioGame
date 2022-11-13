using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class BaseCollider : MonoBehaviour 
{
    protected virtual void OnCollisionEnter(Collision collision) { }
    protected virtual void OnCollisionStay(Collision collision) { }
    protected virtual void OnCollisionExit(Collision collision) { }
    protected virtual void OnTriggerEnter(Collider other) { }
    protected virtual void OnTriggerStay(Collider other) { }
    protected virtual void OnTriggerExit(Collider other) { }
  
    
}
