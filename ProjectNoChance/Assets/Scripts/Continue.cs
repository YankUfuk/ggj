using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public string sceneName;

    public void NextScene()
    {
        
            SceneManager.LoadScene(sceneName);
        
    }
}
