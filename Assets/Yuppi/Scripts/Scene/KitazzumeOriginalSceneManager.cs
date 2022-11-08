using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KitazzumeOriginalSceneManager : SingletonMonoBehaviour<KitazzumeOriginalSceneManager>
{
    public string CommpanionName;
    public string AddSceneName;
    
    public void SceneAdd(string scenename)
    {
        SceneManager.LoadScene(scenename,LoadSceneMode.Additive);
        
    }
    public void SceneUnloadAddtive(string scenename)
    {
        SceneManager.UnloadSceneAsync(scenename);
    }
    
}
