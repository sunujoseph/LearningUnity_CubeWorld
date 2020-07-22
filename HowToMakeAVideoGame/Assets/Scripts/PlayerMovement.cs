using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    //void Start()  {}

    // Update is called once per frame
    //void Update() 
    // better for input

    // Fixed Update is better for physic and velocity. use this if we are messing with physics
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add a forward force to the z-axis 
        // Time.deltaTime - the amount of secs the pc drew the last frame
        // if pc 10 times a sec, value is point 0.1
        // 20 times a sec, value is 0.5
        // the higer the frame rate, the lower the value
        // used so that the movement does not match the framerate.

        //keyboard keys

        if ( Input.GetKey("d") ) 
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
