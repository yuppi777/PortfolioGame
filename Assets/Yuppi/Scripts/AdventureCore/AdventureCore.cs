using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdventureCore : SingletonMonoBehaviour<AdventureCore>
{
    [SerializeField] CSVRoader CSVRoader;
    [SerializeField] SelectCommpanion SelectCommpanion;

    public string NowCommpanionName;
    
    private void Start()
    {
        SelectCommpanion.CommpanionSelect(NowCommpanionName);

       CSVRoader.CSVRoad(SelectCommpanion.NowCommpanionSerif);
        StartCoroutine(CSVRoader.TextView());
    }

  


}
