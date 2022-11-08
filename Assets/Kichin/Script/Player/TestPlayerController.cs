using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TestPlayerController : MonoBehaviour
{

    [SerializeField] private TestPlayerMove PlayerMove;

    private void Start()
    {
        Observable.EveryUpdate()
            .Subscribe(_ => MoveUpdate()).AddTo(gameObject);
            
    }


    private void MoveUpdate()
    {
        PlayerMove.Mover();
    }

    
}
