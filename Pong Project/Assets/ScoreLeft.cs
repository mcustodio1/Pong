using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreLeft : MonoBehaviour
{
    public int scoreLeft = 0;
    public AudioClip scoreSound;
    public AudioClip pointSound;
    public TextMeshProUGUI scoreTextRight;
    void Start()
    {
        
    }
    
    void Update()
    {
        // UnityEngine.Debug.Log("The Left Score is " + scoreLeft);
        
    }
    void OnTriggerEnter(Collider other)
    {
        
        // UnityEngine.Debug.Log("Collider is working ");
        if (other.gameObject.tag == "Score Left") 
        {
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = scoreSound;
            audioSource.Play();
            scoreLeft ++;
            UnityEngine.Debug.Log("The Left Score is " + scoreLeft);
            scoreTextRight.text = "" + scoreLeft;
            if ((scoreLeft % 5) == 0)
            {
                scoreTextRight.text = "Winner!";
                audioSource.clip = pointSound;
                audioSource.Play();
                
            }
        }
        
    }
    

}
