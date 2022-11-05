using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MyPlayerAnimator : BasePlayer
{

    private Animator PlayerAnimator;

    protected override void OnInitialize()
    {
        PlayerAnimator = GetComponent<Animator>();
    }

    public bool Jump {set { PlayerAnimator.SetBool("Jump", value); } }
    public  bool Walk {set { PlayerAnimator.SetBool("Walk", value); } }
    public  bool Action {set { PlayerAnimator.SetBool("Action", value); } }
}
