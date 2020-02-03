// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class move_cube : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 80f;
    public float sidewaysForce = 50f;
    bool jump_enable = true;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello world");
        // // rb.AddForce(0,0,2000);
        // rb.AddForce(0,0,200 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
         if(transform.position[1] < 2.0)
            jump_enable = true;
        if(transform.position[1] >= 13)
            jump_enable = false;
    }

     void FixedUpdate()
    {
        // rb.AddForce(0,0,2000);
        rb.AddForce(0,0, forwardForce * Time.deltaTime);
        if(Input.GetKey("right"))
            rb.AddForce(sidewaysForce* Time.deltaTime,0, 0, ForceMode.VelocityChange);
        else if(Input.GetKey("left"))
            rb.AddForce(-sidewaysForce* Time.deltaTime,0, 0, ForceMode.VelocityChange);
        else
        {
            rb.AddForce(0* Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }
        
        if(Input.GetKey("space")  && jump_enable)
            rb.AddForce(0, 5*forwardForce * Time.deltaTime, 0);
        else
            rb.AddForce(0, -5*forwardForce * Time.deltaTime, 0);
    }
}
