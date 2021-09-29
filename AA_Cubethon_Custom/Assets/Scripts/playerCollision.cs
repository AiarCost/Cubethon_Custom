using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement movement;

    public delegate void CollisionOccured();
    public static event CollisionOccured OnCollisionOccured;

    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Obsticle")
        {
            GetComponent<playerMovement>().enabled = false;

            FindObjectOfType<GameManager>().GameOver();

            if(OnCollisionOccured != null)
            { 
                OnCollisionOccured();
            }
            else
            {
                Debug.Log("Collision has no subscribers");
            }
        }
    }
}
