using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UseCase : MonoBehaviour
{
    [SerializeField] PlayerCore PlayerCore;
    //[SerializeField] AdventureCore AdventureCore;

    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.gameObject.tag == "Commpanion" && Input.GetKeyDown(KeyCode.P))
    //    {
    //        SceneManager.LoadScene("TestScene", LoadSceneMode.Additive);
    //    }

    //}

    private void Update()
    {
        AdventureCore.Instance.NowCommpanionName = PlayerCore.NowCommpanionName;
    }



}
