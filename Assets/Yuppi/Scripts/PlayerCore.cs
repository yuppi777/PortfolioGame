using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCore : MonoBehaviour
{
    [SerializeField]
    [Header("�v���C���[�̓����̃X�N���v�g")]
    private PlayerMover playerMover;

    private PlayerParametor playerParametor;

    private void Update()
    {
        playerMover.PlayerMove(playerParametor.PlayerMoveSpeed);
    }
}
