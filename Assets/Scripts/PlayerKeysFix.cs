using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeysFix : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody RB3D;
    public Camera playerCamera;
    public float speed = 5.0f;
    public float walkSpeed = 6f;
    public float runSpeed = 12f;
    public float jumpPower = 7f;
    public float gravity = 10f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    public float defaultHeight = 2f;



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

            RB3D.AddForce(-50, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            move += Vector3.right;

            RB3D.AddForce(0, 0, -50);
        }

        transform.Translate(move * moveSpeed * Time.deltaTime);
        
        
    } 
}
