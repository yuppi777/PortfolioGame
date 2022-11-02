using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureCore : MonoBehaviour
{
    [SerializeField] CSVRoader CSVRoader;
    private void Start()
    {
       CSVRoader.CSVRoad();
        StartCoroutine(CSVRoader.TextView());
    }
}
