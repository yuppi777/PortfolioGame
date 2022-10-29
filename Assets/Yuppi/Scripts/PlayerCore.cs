using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{
    [SerializeField]
    [Header("プレイヤーの動きのスクリプト")]
    private PlayerMover playerMover;

    private PlayerParametor playerParametor;

    private void Update()
    {
        playerMover.PlayerMove(playerParametor.PlayerMoveSpeed);
    }
}
