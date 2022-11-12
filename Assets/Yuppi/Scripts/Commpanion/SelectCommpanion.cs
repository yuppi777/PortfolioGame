using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SelectCommpanion : MonoBehaviour,ICommpanion
{
   
    [SerializeField] CommpanionMaster data;
    public TextAsset NowCommpanionSerif;

    //public void CommpanionSelect( string nowCommpanionName)
    //{
       
    //}

  

    public void SelifData(string nowCommpanionName)
    {
         var query = data.sheet;
        if (nowCommpanionName == "Kichin")
        {
           var nowCommpanionSerif = query.Where(x => x.Name == "Kichin").First();
            NowCommpanionSerif = nowCommpanionSerif.CsvFile;
        }
        if (nowCommpanionName == "Soyo")
        {
           
            var nowCommpanionSerif = query.Where(x => x.Name == "Soyo").First();
            NowCommpanionSerif = nowCommpanionSerif.CsvFile;

        }
     
        
    }
}
