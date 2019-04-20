using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
[RequireComponent (typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{

    private Rigidbody rb;

    [Tooltip ("How fast the ball moves left/right.")]
    [Range (0,10)]
    public float dodgeSpeed = 5;

    [Tooltip ("How fast the ball rolls forward.")]
    public float rollSpeed = 5; 
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

    void FixedUpdate()
    {
         if(rb.position.y <= 0)
        {
            rb.transform.position = new Vector3(0,0.55f,-5);
            rb.velocity = new Vector3(0,0,1);
            rb.angularVelocity = new Vector3(0,0,0);
        }
        var horizontalSpeed = Input.GetAxisRaw("Horizontal") * dodgeSpeed;
        rb.AddForce(horizontalSpeed, 0, rollSpeed);
        
        //Debug.Log("Pos [y]: " + rb.transform.position.y + "Pos [z]: " + rb.transform.position.z);
        // using (StreamWriter sr = new StreamWriter(Path.Combine(filePath, "cosiezjebalo.txt"),true))
        // {
        //     sr.WriteLine(rb.transform.position.y + " " + rb.transform.position.z);
        // }
        // if(rb.transform.position.x > 0.55)
        // {
        //    Debug.Break();
        // }

    }
}
