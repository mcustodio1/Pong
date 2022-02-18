using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float movementPerSecond = 20f;
    public AudioClip hitSound;
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
            transform.Translate(Vector3.up * movementPerSecond * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.DownArrow))
            transform.Translate(-Vector3.up * movementPerSecond * Time.deltaTime);
        }
    
    private void OnCollisionEnter(Collision collision)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = hitSound;
        audioSource.Play();
        }
    }