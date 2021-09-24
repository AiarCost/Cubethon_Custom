using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 0f;
    public float AddingForce = 50f;
    public float sidewayForce = 500f;

    public CommandUI commandUI;

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
            //Command code to give replay section
            Command moveRight = new MoveRight(rb, sidewayForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(moveRight);
            invoker.ExecuteCommand();

            commandUI.AddToText(moveRight.ToString());

            //rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            //Command code to give replay section
            Command moveLeft = new MoveLeft(rb, sidewayForce);
            Invoker invoker = new Invoker();
            invoker.SetCommand(moveLeft);
            invoker.ExecuteCommand();

            commandUI.AddToText(moveLeft.ToString());

           // rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
