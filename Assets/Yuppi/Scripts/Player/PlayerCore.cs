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

    public string NowCommpanionName;

    private void Awake()
    {
        /*テスト*/
        SceneManager.LoadScene("TestScene", LoadSceneMode.Additive);
    }
    private void Start()
    {
        PlayerMover.OnInitialize();
        PlayerParametor.PlayerMoveSpeed = 8f;
        //PlayerParametor.PlayerJumpPower = 80f;

       
    }

    private void Update()
    {
        PlayerMover.PlayerMove(PlayerParametor.PlayerMoveSpeed);
        //PlayerMover.PlayerJump(PlayerParametor.PlayerJumpPower);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Commpanion" && Input.GetKeyDown(KeyCode.P))
        {
           
           var name  =  other.GetComponent<MyCommpanion>();
            NowCommpanionName = name.MyName;
            //SceneManager.LoadScene("TestScene", LoadSceneMode.Additive);
        }

    }


}
