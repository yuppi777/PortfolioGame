using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerMover : BasePlayer
{
    Rigidbody PlayerRb;
    Vector3 PlayerTf;

    protected override void OnInitialize()
    {
        PlayerRb = GetComponent<Rigidbody>();
        PlayerTf = GetComponent<Transform>().position;
    }

    public void Move(float speed,float intensity_x,float intensity_z)
    {
        var newvector = ((-Vector3.forward + new Vector3(1,0,0)) * intensity_x +( Vector3.forward + new Vector3(1,0,0))* intensity_z) * Time.deltaTime;
        //newvector.y = transform.position.y;
        PlayerRb.velocity = newvector.normalized * speed;

        
        Vector3 diff = transform.position - PlayerTf;

        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(diff);
        }
        


        PlayerTf = transform.position;
    }

    public void Jump(float jump)
    {
        PlayerRb.velocity += transform.up * jump;
    }
}
