using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdventureCore :MonoBehaviour
{
    [SerializeField] CSVRoader CSVRoader;
    [SerializeField] SelectCommpanion selectCommpanion;

    public string NowCommpanionName;

    private void Awake()
    {
        //DontDestroyOnLoad(this.gameObject);

        
    }
    private void Start()
    {
        selectCommpanion.SelifData(NowCommpanionName);

        //Debug.Log(NowCommpanionName);


        //if (selectCommpanion.NowCommpanionSerif != null)
        //{
        //    Debug.Log("ê¨å˜");

        //}

       CSVRoader.CSVRoad(selectCommpanion.NowCommpanionSerif);
        StartCoroutine(CSVRoader.TextView());
    }

  

}
