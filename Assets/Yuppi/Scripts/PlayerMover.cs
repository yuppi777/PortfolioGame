using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    Rigidbody rb;
    float x;
    float z;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    public void PlayerMove(float moveSpeed)
    {
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector3(x, 0, z) * moveSpeed;
    }
    
}
