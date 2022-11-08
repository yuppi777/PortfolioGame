using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PlayerPresenter : BasePlayer
{
    MyPlayerAnimator Animator;
    MyPlayerMover Mover;
    PlayerModel Model;
    IInputEventProvider InputEventProvider;

    protected override void OnInitialize()
    {
        Animator = GetComponent<MyPlayerAnimator>();
        Mover = GetComponent<MyPlayerMover>();
        InputEventProvider = GetComponent<IInputEventProvider>();
        Model = new PlayerModel();

        InputEventProvider.OnInitialize();

        InputEventProvider.MoveDirection
            .Subscribe(x =>
            {
                Mover.Move(Model.Speed,x);
                Animator.Walk = true;
            });

        InputEventProvider.IsMove
            .Where(x => x == false)
            .Subscribe(x => Animator.Walk = false);


        InputEventProvider.Jump
            .Where(x => x == true)
            .Subscribe(x => Mover.Jump(Model.JumpPower));
    }
}
