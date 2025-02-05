using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class BallBounceSound : MonoBehaviour
{
    public AudioClip bounceSound;
    public AudioSource audioSource;
    public float volumeSensitivity = 10f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        float volume = rb.velocity.magnitude / volumeSensitivity;
        audioSource.PlayOneShot(bounceSound, volume);
    }
}
