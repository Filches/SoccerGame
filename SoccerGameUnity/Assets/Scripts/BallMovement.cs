using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float ballThrust;

    // Start is called before the first frame update
    void Start()
    {
        new Vector3(1, 0, 0);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * ballThrust, ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
