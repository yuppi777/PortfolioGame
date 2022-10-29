using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player.Mover;

public class PlayerCore : MonoBehaviour
{
    [SerializeField]
    [Header("プレイヤーの動きのスクリプト")]
    private PlayerMover PlayerMover;

    private PlayerParametor PlayerParametor;

    private void Start()
    {
        PlayerMover.OnInitialize();
        PlayerParametor.PlayerMoveSpeed = 8f;
        PlayerParametor.PlayerJumpPower = 80f;
    }

    private void Update()
    {
        PlayerMover.PlayerMove(PlayerParametor.PlayerMoveSpeed);
        PlayerMover.PlayerJump(PlayerParametor.PlayerJumpPower);
    }
}
