using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerMove : MonoBehaviour
{

    Rigidbody P_rb;

    private void Start()
    {
        P_rb = GetComponent<Rigidbody>();
    }

    public void Mover()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        P_rb.velocity = new Vector3(x, 0, z) * 3;

    }
}
