using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour

{
    public float movementPerSecond = 20f;
    public AudioClip hitSound;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * movementPerSecond * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.up * movementPerSecond * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = hitSound;
        audioSource.Play();
        // BoxCollider bbox = GetComponent<BoxCollider>();
        // float xCenter = bbox.bounds.center.x;
        //
        // Debug.Log("Center at " + xCenter + "collided object at " + collision.transform.position.x);
    }
}
