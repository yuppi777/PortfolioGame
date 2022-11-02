using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class CSVRoader : MonoBehaviour
{
    [SerializeField] private Text TextViewer;
    [SerializeField] private TextAsset CsvFile;
    [SerializeField] private Text NameTextViewer;

    //[SerializeField] private GameObject Adbentya;
    List<string[]> CsvDate = new List<string[]>();
    int TextKey = 0;
    public string ToScene;



   public void CSVRoad()
    {
        StringReader reader = new StringReader(CsvFile.text);

        while (reader.Peek() != -1)
        {
            string liner = reader.ReadLine();
            CsvDate.Add(liner.Split(','));
        }

    }

   public IEnumerator TextView()
    {
        while (true)
        {
            TextViewer.text = " ";
            TextViewer.DOText(CsvDate[TextKey][0], 0.5f);
            NameTextViewer.text = CsvDate[TextKey][1];
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Return));

            if (TextKey == CsvDate.Count - 1)
            {
                break;
            }

            TextUpdate();

            yield return null;
        }

       
        TitleBack();
    }


   public void TextUpdate()
    {
        TextKey += 1;
    }

   
   public void TitleBack()
    {
        SceneManager.LoadScene(ToScene);
    }
}
