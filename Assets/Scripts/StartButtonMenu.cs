using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonMenu : MonoBehaviour
{

    public void switchScenes(string LEVEL1)
    {
        SceneManager.LoadScene(LEVEL1);
    }

  
}