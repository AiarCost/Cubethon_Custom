using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 0f;
    public float AddingForce = 50f;
    public float sidewayForce = 500f;

 
    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.transform.position.z <= 300)
            Movement();

    }

    void Movement()
    {
        //The Change of forward force overtime of the game
        forwardForce += AddingForce;

        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);


        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
