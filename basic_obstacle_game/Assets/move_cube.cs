// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class move_cube : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 80f;
    public float sidewaysForce = 50f;
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
        //  // rb.AddForce(0,0,2000);
        // rb.AddForce(0,0, 1000 * Time.deltaTime);
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
            rb.AddForce(0* Time.deltaTime,0, 0, ForceMode.VelocityChange);
    }
}
