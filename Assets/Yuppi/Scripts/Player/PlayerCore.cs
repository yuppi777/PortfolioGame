using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player.Mover;
using UnityEngine.SceneManagement;

public class PlayerCore : MonoBehaviour
{
    [SerializeField]
    [Header("�v���C���[�̓����̃X�N���v�g")]
    private PlayerMover PlayerMover;
    [SerializeField]
    [Header("�v���C���[�̃A�j���[�V�����̃X�N���v�g")]
    private PlayerAnimator PlayerAnimator;
    [SerializeField]
    [Header("�v���C���[�̃G�t�F�N�g�̃X�N���v�g")]
    private PlayerEffecter PlayerEffecter;


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

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Commpanion" && Input.GetKeyDown(KeyCode.P))
        {
            KitazzumeOriginalSceneManager.Instance.SceneAdd("TestScene");
        }
      
    }
  

}