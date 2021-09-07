using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private BoxCollider boxCol;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        boxCol = GetComponent<BoxCollider>();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(speed, 0, 0);
    }

    public void OnTriggerEnter(Collider col)
    {
        //If it hits another obsticle of the end of the platform, go in reverse
        if(col.CompareTag("Wall") || col.CompareTag("Obsticle"))
        {
            speed *= -1;
        }

        //If the player hits the obsticle, change it to not be trigger so the obsticle feels impacts
        else if (col.CompareTag("Player"))
        {
            boxCol.isTrigger = false;
        }

    }


}
