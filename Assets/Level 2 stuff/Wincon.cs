using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wincon : MonoBehaviour
{
    public Transform winPoint;
    public float winDist = 1.0f;
    // reference to player
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 winPoint = new Vector3(-0.33f, 0.82f, -10.75f);
        float distToWin = Vector3.Distance(player.position, winPoint);
        if(distToWin <= winDist)
        {
            Debug.Log("WOAHHHHHHH");
                }
        else
        {
            // Do nothing
        }
    }
}
