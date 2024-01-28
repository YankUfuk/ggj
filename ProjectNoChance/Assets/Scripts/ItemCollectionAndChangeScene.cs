using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemCollectionAndChangeScene : MonoBehaviour
{
    public string sceneName;

    private void Update()
    {
    if(Score.score >= 10)
        {
            SceneManager.LoadScene(sceneName);

        }
            
}
        
}

