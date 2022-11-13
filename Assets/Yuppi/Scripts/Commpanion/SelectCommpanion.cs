using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SelectCommpanion : MonoBehaviour,ICommpanion
{
   
    [SerializeField] CommpanionMaster data;
    public TextAsset NowCommpanionSerif => nowcommpanionserif ;
    private TextAsset nowcommpanionserif;
    public Sprite NowCommpanionFace => nowcommpanionface;
    private Sprite nowcommpanionface;


    public void SelifData(string nowCommpanionName)
    {
         var query = data.sheet;
        
           var nowCommpanionData = query.Where(x => x.Name == nowCommpanionName).First();
            nowcommpanionserif = nowCommpanionData.CsvFile;
            nowcommpanionface = nowCommpanionData.sprite;
        
        
    }
}


