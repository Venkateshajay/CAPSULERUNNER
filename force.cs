using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour
{
    // Start is called before the first frame update
    public float addforce=500f;
    public Rigidbody rb;
    private bool keyispressed;
    private bool keyispressed1;
    public float movement=500f;
    public float jumpforce=7f;
    public LayerMask groundlayer;
    public SphereCollider col;
    private bool keyispressed3;
    



    void Start()
    {
        col = GetComponent<SphereCollider>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            keyispressed = true;
        }
        else
        {
            keyispressed = false;
        }
        if (Input.GetKey("d"))
        {
            keyispressed1 = true; 
        }
        else
        {
            keyispressed1 = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            keyispressed3 = true;
        }
        
       
        
    }
   
    void FixedUpdate()
    {
        rb.AddForce(addforce*Time.deltaTime, 0, 0);
        if (keyispressed)
        {
            rb.AddForce(0, 0, movement * Time.deltaTime);
        }
        if (keyispressed1)
        {
            rb.AddForce(0, 0, -movement * Time.deltaTime);
        }
        if (keyispressed3)
        {
            rb.AddForce(0, 10*Time.deltaTime, 0, ForceMode.Impulse);
        }
       
    }
    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z),col.radius*.9f,groundlayer);
    }
}
