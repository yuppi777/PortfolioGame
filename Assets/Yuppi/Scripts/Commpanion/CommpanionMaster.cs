using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "ScriptableObject/CreateAsset")]
public class CommpanionMaster : ScriptableObject
{
    public List<CommpanionMasterRecord> sheet;

    public enum JobPost
    {
        Programer,
        Farmers,
        Idol,
    }


    [Serializable]
    public class CommpanionMasterRecord
    {
        public string Name;
        public Sprite sprite;
        public TextAsset CsvFile;
        public CommpanionMaster.JobPost Post;
        
    }
}
