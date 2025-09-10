using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class example2 : MonoBehaviour
{
    public float speed = 5f;
    public int PlayerNetWorth = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v);
        transform.Translate(move * speed * Time.deltaTime);
    }
}
