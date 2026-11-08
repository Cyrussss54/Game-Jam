using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float movementSpeed = 10f; 
    
    private Rigidbody rb;
    private float moveX;
    private float moveY;

    public Transform SpawnPoint;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter:" + other.gameObject.tag); 

        if (other.gameObject.tag == "FinishZone")
        {
            rb.isKinematic = true;
            transform.position = SpawnPoint.position;
            rb.isKinematic = false;
        }
    }
}

