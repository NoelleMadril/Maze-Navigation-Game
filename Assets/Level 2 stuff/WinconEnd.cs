using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinconEnd : MonoBehaviour
{
    public Transform winPoint;
    public float winDist = 1.0f;
    // reference to player
    public Transform player;
    // scene to load
    public string sceneToLoad = "WinScreen";

    // Update is called once per frame
    void Update()
    {
        Vector3 winPoint = new Vector3(4.86f, 1.55f, -11.9f);
        float distToWin = Vector3.Distance(player.position, winPoint);
        if(distToWin <= winDist)
        {
            Debug.Log("WinpointEnd reached");
            SceneManager.LoadScene("WinScreen");
        }
        else
        {
            // Do nothing
        }
    }
}
