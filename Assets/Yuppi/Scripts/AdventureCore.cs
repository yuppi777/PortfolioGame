using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AdventureCore : MonoBehaviour
{
    [SerializeField] CSVRoader CSVRoader;
    private void Start()
    {
       CSVRoader.CSVRoad();
        StartCoroutine(CSVRoader.TextView());
    }

    


}
