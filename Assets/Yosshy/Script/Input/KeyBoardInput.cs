using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class KeyBoardInput : MonoBehaviour,IInputEventProvider
{
    IReactiveProperty<bool> IInputEventProvider.Jump => KeyJump;
    IReactiveProperty<bool> IInputEventProvider.Action => KeyAction;
    IReactiveProperty<bool> IInputEventProvider.IsMove => KeyIsMove;
    IReactiveProperty<Vector3> IInputEventProvider.MoveDirection => KeyMove;

    ReactiveProperty<bool> KeyJump = new ReactiveProperty<bool>();
    ReactiveProperty<bool> KeyAction = new ReactiveProperty<bool>();
    ReactiveProperty<bool> KeyIsMove = new ReactiveProperty<bool>();
    ReactiveProperty<Vector3> KeyMove = new ReactiveProperty<Vector3>();

    void IInputEventProvider.OnInitialize()
    {
        this.UpdateAsObservable()
            .Select(x => Input.GetKey(KeyCode.Space))
            .DistinctUntilChanged()
            .Subscribe(x => KeyJump.Value = true);

        this.UpdateAsObservable()
            .Select(x => new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")))
            .Subscribe(x => KeyMove.SetValueAndForceNotify(x));

        this.UpdateAsObservable()
            .Select(x => new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical")))
            .Select(x => x.magnitude > 0.01f)
            .Subscribe(x => KeyIsMove.Value = x);


    }
}
