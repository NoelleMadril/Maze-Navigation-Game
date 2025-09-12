using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeysFix : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody RB3D;



    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            move += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;
        }

        transform.Translate(move * moveSpeed * Time.deltaTime);
        
        
    } 
}
