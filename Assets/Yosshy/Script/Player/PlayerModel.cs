using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using System;

public  class PlayerModel
{
    public readonly float Speed = 5;
    public readonly float JumpPower = 5;
    public IObservable<long> UpdateObservable => Observable.EveryUpdate();
    public IObservable<long> JumpObservable => Observable.EveryUpdate();

    public float Horizontal()
    {
        return Input.GetAxis("Horizontal");
    }

    public float Vertical()
    {
        return Input.GetAxis("Vertical");
    }

    public bool Jump()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}
