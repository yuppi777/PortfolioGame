using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class PlayerPresenter : BasePlayer
{
    MyPlayerAnimator Animator;
    MyPlayerMover Mover;
    PlayerModel Model;

    protected override void OnInitialize()
    {
        Animator = GetComponent<MyPlayerAnimator>();
        Mover = GetComponent<MyPlayerMover>();
        Model = new PlayerModel();

        Model.UpdateObservable
            .Where(x => Model.Horizontal() != 0 || Model.Vertical() != 0)
            .Subscribe(x =>
            {
                Mover.Move(Model.Speed, Model.Horizontal(), Model.Vertical());
                Animator.Walk = true;
            });

        Model.UpdateObservable
            .Where(x => Model.Horizontal() == 0 && Model.Vertical() == 0)
            .Subscribe(x => Animator.Walk = false);


       Model.JumpObservable
            .Where(x => Model.Jump())
            .Subscribe(x => Mover.Jump(Model.JumpPower));
    }
}
