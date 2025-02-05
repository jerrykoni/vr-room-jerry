using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayVelocity : MonoBehaviour
{
    private Rigidbody rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Velocity: " + rigidBody.velocity.magnitude);
    }
}