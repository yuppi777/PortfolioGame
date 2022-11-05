using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player.Mover;
using UnityEngine.SceneManagement;

public class PlayerCore : MonoBehaviour
{
    [SerializeField]
    [Header("プレイヤーの動きのスクリプト")]
    private PlayerMover PlayerMover;
    [SerializeField]
    [Header("プレイヤーのアニメーションのスクリプト")]
    private PlayerAnimator PlayerAnimator;
    [SerializeField]
    [Header("プレイヤーのエフェクトのスクリプト")]
    private PlayerEffecter PlayerEffecter;


    private PlayerParametor PlayerParametor;


    private void Start()
    {
        PlayerMover.OnInitialize();
        PlayerParametor.PlayerMoveSpeed = 5;
    }

    private void FixedUpdate()
    {
        PlayerMover.PlayerMove(PlayerParametor.PlayerMoveSpeed);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Commpanion" && Input.GetKeyDown(KeyCode.P))
        {
            KitazzumeOriginalSceneManager.Instance.SceneAdd("TestScene");
        }
      
    }
  

}
