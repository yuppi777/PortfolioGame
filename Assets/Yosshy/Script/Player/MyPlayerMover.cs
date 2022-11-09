using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerMover : BasePlayer
{
    Rigidbody PlayerRb;
    Vector3 PlayerTf;
    readonly float RotateMag = 0.065f;

    protected override void OnInitialize()
    {
        PlayerRb = GetComponent<Rigidbody>();
        PlayerTf = GetComponent<Transform>().position;
    }

    public void Move(float speed,Vector3 direction)
    {
        var newvector = ((-Vector3.forward + new Vector3(1,0,0)) * direction.x +( Vector3.forward + new Vector3(1,0,0))* direction.z) * Time.deltaTime;
        PlayerRb.velocity = newvector.normalized * speed;
        Debug.Log(newvector);
        Rotate();
    }

    void Rotate()
    {
        var newpos = transform.position;
        newpos.y = 0;
        Vector3 diff = newpos - PlayerTf;

        if (diff.magnitude > RotateMag)
        {
            transform.rotation = Quaternion.LookRotation(diff);
        }

        PlayerTf = newpos;
    }

    public void Jump(float jump)
    {
        PlayerRb.velocity += transform.up * jump;
    }
}
